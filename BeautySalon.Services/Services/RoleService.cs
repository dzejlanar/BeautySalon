using AutoMapper;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Services.Services
{
    public class RoleService : ReadService<RoleVM, Role, BaseSearchObject>, IRoleService
    {
        public RoleService(BeautySalonContext context, IMapper mapper) : base(context, mapper) { }
    }
}
