﻿using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;

namespace BeautySalon.Services.Interfaces
{
    public interface IAppointmentService : 
        ICRUDService<AppointmentVM, AppointmentSearchObject, AppointmentInsertRequest, AppointmentUpdateRequest>
    { }
}
