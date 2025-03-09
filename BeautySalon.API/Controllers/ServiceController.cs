using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    public class ServiceController : CRUDController<ServiceVM, ServiceSearchObject, ServiceUpsertRequest, ServiceUpsertRequest>
    {
        public ServiceController(IServiceService service) : base(service) { }

        [HttpPut("{id}/activate")]
        public ServiceVM? Activate(int id)
        {
            return ((IServiceService)_service).Activate(id);
        }

        [HttpPut("{id}/hide")]
        public ServiceVM? Hide(int id)
        {
            return ((IServiceService)_service).Hide(id);
        }

        [HttpPut("{id}/allowed-actions")]
        public List<string>? AlowedActions(int id)
        {
            return ((IServiceService)_service).AllowedActions(id);
        }
    }
}
