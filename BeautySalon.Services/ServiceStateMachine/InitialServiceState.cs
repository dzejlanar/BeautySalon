using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;

namespace BeautySalon.Services.ServiceStateMachine
{
    public class InitialServiceState : BaseServiceState
    {
        public InitialServiceState(IServiceProvider serviceProvider, BeautySalonContext context, IMapper mapper) : base(serviceProvider, context, mapper) { }

        public override ServiceVM Insert(ServiceUpsertRequest request)
        {
            var set = _context.Set<Service>();

            var entity = _mapper.Map<Service>(request);
            entity.Status = "draft";
            entity.CreatedDate = DateTime.UtcNow;

            set.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<ServiceVM>(entity);
        }

        public override List<string> AllowedActions(Service service)
        {
            return new List<string> { nameof(Insert) };
        }
    }
}
