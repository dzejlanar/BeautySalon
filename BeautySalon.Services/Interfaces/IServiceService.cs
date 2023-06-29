using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;

namespace BeautySalon.Services.Interfaces
{
    public interface IServiceService 
        : ICRUDService<ServiceVM, ServiceSearchObject, ServiceUpsertRequest, ServiceUpsertRequest> 
    {
        List<ServiceVM> GetServicesFromSameCategory(Service service);
    }
}
