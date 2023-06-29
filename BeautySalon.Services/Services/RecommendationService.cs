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
        private readonly IMapper _mapper;
        private readonly IServiceService _service;

        static MLContext? mlContext = null;
        static ITransformer? model = null;

        public RecommendationService(BeautySalonContext context, IMapper mapper, IServiceService service)
        {
            _context = context;
            _mapper = mapper;
            _service = service;
        }

        public void CreateModel()
        {
            throw new NotImplementedException();
        }

        public List<ServiceVM> Recommend(int serviceId)
        {
            var service = _context.Services.FirstOrDefault(s => s.ServiceId == serviceId) ?? throw new Exception("Service doesn't exist");

            if (mlContext == null)
            {
                mlContext = new MLContext();

                var users = _context.Users.Include(u => u.UserServicesRatings.Where(usr => usr.Rating >= 3)).ToList();
                var data = new List<ServiceEntry>();

                users.ForEach(u =>
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

                if (!data.Any())
                    return _service.GetServicesFromSameCategory(service);

                var dataToTrain = mlContext.Data.LoadFromEnumerable(data);

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

                model = est.Fit(dataToTrain);
            }

            var allItems = _context.Services.Where(s => s.ServiceId != serviceId).ToList();

            var predictionResult = new List<Tuple<Service, float>>();

            allItems.ForEach(item =>
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ServiceEntry, Prediction>(model);
                var prediction = predictionEngine.Predict(new ServiceEntry()
                {
                    ServiceId = (uint)serviceId,
                    CoRatedServiceId = (uint)item.ServiceId
                });

                predictionResult.Add(new Tuple<Service, float>(item, prediction.Score));
            });

            var finalResult = predictionResult.OrderByDescending(pr => pr.Item2)
               .Select(pr => pr.Item1).Take(3).ToList();

            return _mapper.Map<List<ServiceVM>>(finalResult);
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
