using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    public class UserController : CRUDController<UserVM, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        public UserController(IUserService service) : base(service) { }

        [HttpPost("login")]
        [AllowAnonymous]
        public UserVM Login(string username, string password)
        {
            return ((IUserService)_service).Login(username, password);
        }

        [AllowAnonymous]
        public override UserVM Insert(UserInsertRequest userInsertRequest)
        {
            return base.Insert(userInsertRequest);
        }
    }
}
