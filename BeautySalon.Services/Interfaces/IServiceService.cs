using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;

namespace BeautySalon.Services.Interfaces
{
    public interface IServiceService 
        : ICRUDService<ServiceVM, ServiceSearchObject, ServiceUpsertRequest, ServiceUpsertRequest> { }
}
