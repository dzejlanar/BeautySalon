using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BeautySalon.Services.Services
{
    public class ServiceService : CRUDService<ServiceVM, Service, ServiceSearchObject, ServiceUpsertRequest, ServiceUpsertRequest>, IServiceService
    {
        public ServiceService(BeautySalonContext context, IMapper mapper) : base(context, mapper) { }

        public override IQueryable<Service> AddFilter(IQueryable<Service> query, ServiceSearchObject? searchObject)
        {
            var queryable = base.AddFilter(query, searchObject);

            if (!string.IsNullOrWhiteSpace(searchObject?.NameGT))
            {
                queryable = queryable.Where(q => q.Name.StartsWith(searchObject.NameGT));
            }

            return queryable.Include(q => q.Category);
        }

        public override void BeforeInsert(Service entity, ServiceUpsertRequest insertObject)
        {
            entity.CreatedDate = DateTime.UtcNow;
        }

        public override void BeforeUpdate(Service entity, ServiceUpsertRequest updateObject)
        {
            entity.UpdatedDate = DateTime.UtcNow;
        }

        public List<ServiceVM> GetServicesFromSameCategory(Service service)
        {
            var services = _context.Services.Where(s => s.CategoryId == service.CategoryId).Take(3).ToList();

            return _mapper.Map<List<ServiceVM>>(services);
        }
    }
}
