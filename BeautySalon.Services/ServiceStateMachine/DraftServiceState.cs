using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;

namespace BeautySalon.Services.ServiceStateMachine
{
    public class DraftServiceState : BaseServiceState
    {
        public DraftServiceState(IServiceProvider serviceProvider, BeautySalonContext context, IMapper mapper) : base(serviceProvider, context, mapper) { }

        public override ServiceVM Update(int id, ServiceUpsertRequest request)
        {
            var entity = _context.Services.Find(id);

            _mapper.Map(request, entity);
            entity.UpdatedDate = DateTime.UtcNow;

            _context.SaveChanges();

            return _mapper.Map<ServiceVM>(entity);
        }

        public override ServiceVM Activate(int id)
        {
            var entity = _context.Services.Find(id);
            
            entity.Status = "active";
            entity.UpdatedDate = DateTime.UtcNow;

            _context.SaveChanges();

            return _mapper.Map<ServiceVM>(entity);
        }

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
            return new List<string> { nameof(Activate), nameof(Update), nameof(Hide) };
        }
    }
}
