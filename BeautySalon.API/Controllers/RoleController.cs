using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Controllers
{
    public class RoleController : ReadController<RoleVM, BaseSearchObject>
    {
        public RoleController(IReadService<RoleVM, BaseSearchObject> service) : base(service) { }
    }
}
