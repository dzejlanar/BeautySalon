using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;

namespace BeautySalon.Services.Interfaces
{
    public interface IServiceCategoryService : 
        ICRUDService<ServiceCategoryVM, ServiceCategorySearchObject, ServiceCategoryUpsertRequest, ServiceCategoryUpsertRequest> 
    { }
}
