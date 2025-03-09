using BeautySalon.Controllers;
using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.API.Controllers
{
    public class AppointmentController : CRUDController<AppointmentVM, AppointmentSearchObject, AppointmentInsertRequest, AppointmentUpdateRequest>
    {
        public AppointmentController(ICRUDService<AppointmentVM, AppointmentSearchObject, AppointmentInsertRequest, AppointmentUpdateRequest> service) : base(service) { }
    }
}
