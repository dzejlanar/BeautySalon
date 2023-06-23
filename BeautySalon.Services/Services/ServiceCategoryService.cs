using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Services.Services
{
    public class ServiceCategoryService : CRUDService<ServiceCategoryVM, ServiceCategory, ServiceCategorySearchObject, ServiceCategoryUpsertRequest, ServiceCategoryUpsertRequest>, IServiceCategoryService
    {
        public ServiceCategoryService(BeautySalonContext context, IMapper mapper) : base(context, mapper) { }

        public override IQueryable<ServiceCategory> AddFilter(IQueryable<ServiceCategory> query, ServiceCategorySearchObject? searchObject)
        {
            var entities = base.AddFilter(query, searchObject);

            if (!string.IsNullOrWhiteSpace(searchObject?.NameGT))
            {
                return entities.Where(e => e.Name.StartsWith(searchObject.NameGT));
            }

            return entities;
        }
    }
}
