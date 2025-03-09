using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;
using BeautySalon.Services.ServiceStateMachine;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Services.Services
{
    public class ServiceService : CRUDService<ServiceVM, Service, ServiceSearchObject, ServiceUpsertRequest, ServiceUpsertRequest>, IServiceService
    {
        public BaseServiceState _state { get; set; }
        public ServiceService(BeautySalonContext context, IMapper mapper, BaseServiceState state) : base(context, mapper) 
        {
            _state = state;
        }

        public override IQueryable<Service> AddFilter(IQueryable<Service> query, ServiceSearchObject? searchObject)
        {
            var queryable = base.AddFilter(query, searchObject);

            if (!string.IsNullOrWhiteSpace(searchObject?.NameGT))
            {
                queryable = queryable.Where(q => q.Name.StartsWith(searchObject.NameGT));
            }

            return queryable.Include(q => q.Category);
        }

        public override ServiceVM Insert(ServiceUpsertRequest insertObject)
        {
            var state = _state.CreateState("initial");
            return state.Insert(insertObject);
        }

        public override ServiceVM? Update(int id, ServiceUpsertRequest updateObject)
        {
            var entity = _context.Services.Find(id);
            if (entity != null)
            {
                var state = _state.CreateState(entity.Status);
                return state.Update(id, updateObject);
            }

            return null;
        }

        public List<ServiceVM> GetServicesByIds(List<int> ids)
        {
            var services = _context.Services.Include(s => s.Category)
                                            .Include(s => s.UserServiceRatings).ThenInclude(usr => usr.User)
                                            .Where(s => ids.Contains(s.ServiceId))
                                            .OrderBy(s => ids.IndexOf(s.ServiceId))
                                            .ToList();

            return _mapper.Map<List<ServiceVM>>(services);
        }

        public List<ServiceVM> GetServicesFromSameCategory(Service service)
        {
            var services = _context.Services.Where(s => s.CategoryId == service.CategoryId).Take(3).ToList();

            return _mapper.Map<List<ServiceVM>>(services);
        }

        public List<ServiceVM> GetTopRatedServices()
        {
            var services = _context.Services.Include(s => s.Category)
                                            .Include(s => s.UserServiceRatings).ThenInclude(usr => usr.User)
                                            .OrderByDescending(s => s.UserServiceRatings.Average(usr => usr.Rating))
                                            .ToList();

            return _mapper.Map<List<ServiceVM>>(services);
        }

        public ServiceVM? Activate(int id)
        {
            var entity = _context.Services.Find(id);
            if (entity != null)
            {
                var state = _state.CreateState(entity.Status);
                return state.Activate(id);
            }

            return null;
        }

        public ServiceVM? Hide(int id)
        {
            var entity = _context.Services.Find(id);
            if (entity != null)
            {
                var state = _state.CreateState(entity.Status);
                return state.Hide(id);
            }

            return null;
        }

        public List<string>? AllowedActions(int id)
        {
            if (id <= 0)
            {
                var state = _state.CreateState("initial");
                return state.AllowedActions(null);
            }

            var entity = _context.Services.Find(id);

            if (entity != null)
            {
                var state = _state.CreateState(entity.Status);
                return state.AllowedActions(entity);
            }

            return null;
        }
    }
}
