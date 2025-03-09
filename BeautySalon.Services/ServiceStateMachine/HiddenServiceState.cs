using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;

namespace BeautySalon.Services.ServiceStateMachine
{
    public class HiddenServiceState : BaseServiceState
    {
        public HiddenServiceState(IServiceProvider serviceProvider, BeautySalonContext context, IMapper mapper) : base(serviceProvider, context, mapper) { }

        public override ServiceVM Update(int id, ServiceUpsertRequest request)
        {
            var entity = _context.Services.Find(id);

            _mapper.Map(request, entity);
            entity.Status = "draft";
            entity.UpdatedDate = DateTime.UtcNow;

            _context.SaveChanges();

            return _mapper.Map<ServiceVM>(entity);
        }

        public override List<string> AllowedActions(Service service)
        {
            return new List<string> { nameof(Update) };
        }
    }
}
