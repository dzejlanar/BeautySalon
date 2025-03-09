using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Services.Services
{
    public class AppointmentService :
        CRUDService<AppointmentVM, Appointment, AppointmentSearchObject, AppointmentInsertRequest, AppointmentUpdateRequest>, IAppointmentService
    {
        public AppointmentService(BeautySalonContext context, IMapper mapper) : base(context, mapper) { }
    }
}
