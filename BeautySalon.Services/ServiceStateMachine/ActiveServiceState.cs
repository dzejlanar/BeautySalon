using AutoMapper;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;

namespace BeautySalon.Services.ServiceStateMachine
{
    public class ActiveServiceState : BaseServiceState
    {
        public ActiveServiceState(IServiceProvider serviceProvider, BeautySalonContext context, IMapper mapper) : base(serviceProvider, context, mapper) { }

        public override ServiceVM Hide(int id)
        {
            var entity = _context.Services.Find(id);

            entity.Status = "hidden";
            entity.UpdatedDate = DateTime.UtcNow;

            _context.SaveChanges();
            
            return _mapper.Map<ServiceVM>(entity);
        }

        public override List<string> AllowedActions(Service service)
        {
            return new List<string> { nameof(Hide) };
        }
    }
}
