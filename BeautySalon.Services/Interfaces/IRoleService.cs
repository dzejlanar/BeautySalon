using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Services.Interfaces
{
    public interface IRoleService : IReadService<RoleVM, BaseSearchObject>
    {
    }
}
