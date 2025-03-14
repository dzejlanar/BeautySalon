﻿using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;

namespace BeautySalon.Services.Interfaces
{
    public interface IServiceService 
        : ICRUDService<ServiceVM, ServiceSearchObject, ServiceUpsertRequest, ServiceUpsertRequest> 
    {
        List<ServiceVM> GetServicesFromSameCategory(Service service);
        List<ServiceVM> GetTopRatedServices();
        List<ServiceVM> GetServicesByIds(List<int> ids);
        ServiceVM? Activate(int id);
        ServiceVM? Hide(int id);
        List<string>? AllowedActions(int id);
    }
}
