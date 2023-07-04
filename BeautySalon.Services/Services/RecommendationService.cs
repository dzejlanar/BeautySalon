using AutoMapper;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace BeautySalon.Services.Services
{
    public class RecommendationService : IRecommendationService
    {
        private readonly BeautySalonContext _context;
        private readonly IServiceService _service;

        public RecommendationService(BeautySalonContext context, IServiceService service)
        {
            _context = context;
            _service = service;
        }

        public List<ServiceVM> Recommend(int serviceId)
        {
            var service = _context.Services.Include(s => s.UserServiceRatings).FirstOrDefault(s => s.ServiceId == serviceId) ?? throw new Exception("Service doesn't exist");

            if (!service.UserServiceRatings.Any()) {
                return _service.GetTopRatedServices();
            }

            var mlContext = new MLContext();

            var model = LoadModel(mlContext);

            var serviceIds = _context.Services.Where(s => s.ServiceId != serviceId).Select(s => s.ServiceId).ToList();

            var predictionEngine = mlContext.Model.CreatePredictionEngine<ServiceEntry, Prediction>(model);
            var predictionResult = new List<Tuple<int, float>>();

            serviceIds.ForEach(id =>
            {
                var prediction = predictionEngine.Predict(new ServiceEntry()
                {
                    ServiceId = (uint)serviceId,
                    CoRatedServiceId = (uint)id
                });

                predictionResult.Add(new Tuple<int, float>(id, prediction.Score));
            });

            var finalResult = predictionResult.OrderByDescending(pr => pr.Item2)
               .Select(pr => pr.Item1).Take(3).ToList();

            return _service.GetServicesByIds(finalResult);
        }

        ITransformer LoadModel(MLContext mlContext)
        {
            DataViewSchema modelSchema;

            var modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "ServiceRecommender.zip");

            ITransformer trainedModel = mlContext.Model.Load(modelPath, out modelSchema);
            return trainedModel;
        }

        public async Task CreateModel()
        {
            var mlContext = new MLContext();
            var users = _context.Users.Include(u => u.UserServicesRatings.Where(usr => usr.Rating >= 3)).ToList();
            var data = new List<ServiceEntry>();

            users?.ForEach(u =>
            {
                if (u.UserServicesRatings.Count > 1)
                {
                    var userServicesIds = u.UserServicesRatings.Select(usr => usr.ServiceId).ToList();

                    userServicesIds.ForEach(usId =>
                    {
                        var relatedServices = u.UserServicesRatings.Where(usr => usr.ServiceId != usId).ToList();

                        relatedServices.ForEach(rs =>
                        {
                            data.Add(new ServiceEntry
                            {
                                ServiceId = (uint)usId,
                                CoRatedServiceId = (uint)rs.ServiceId
                            });
                        });
                    });
                }
            });

            var dataToTrain = mlContext.Data.LoadFromEnumerable(data);
            ITransformer model = BuildAndTrainModel(mlContext, dataToTrain);
            SaveModel(mlContext, dataToTrain.Schema, model);
        }

        ITransformer BuildAndTrainModel(MLContext mlContext, IDataView dataToTrain)
        {
            MatrixFactorizationTrainer.Options options = new()
            {
                MatrixColumnIndexColumnName = nameof(ServiceEntry.ServiceId),
                MatrixRowIndexColumnName = nameof(ServiceEntry.CoRatedServiceId),
                LabelColumnName = "Label",

                LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                Alpha = 0.01,
                Lambda = 0.025,

                NumberOfIterations = 100,
                C = 0.00001
            };


            var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

            var model = est.Fit(dataToTrain);
            return model;
        }

        void SaveModel(MLContext mlContext, DataViewSchema trainingDataViewSchema, ITransformer model)
        {
            var modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "ServiceRecommender.zip");
            mlContext.Model.Save(model, trainingDataViewSchema, modelPath);
        }

        public class Prediction
        {
            public float Score { get; set; }
        }

        public class ServiceEntry
        {
            [KeyType(count: 10)]
            public uint ServiceId { get; set; }

            [KeyType(count: 10)]
            public uint CoRatedServiceId { get; set; }

            public float Label { get; set; }
        }

    }
}
