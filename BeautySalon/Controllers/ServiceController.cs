using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Controllers
{
    public class ServiceController : CRUDController<ServiceVM, ServiceSearchObject, ServiceUpsertRequest, ServiceUpsertRequest>
    {
        public ServiceController(IServiceService service) : base(service) { }
    }
}
