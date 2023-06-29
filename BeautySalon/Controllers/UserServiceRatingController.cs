using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    public class UserServiceRatingController : CRUDController<UserServiceRatingVM, BaseSearchObject, UserServiceRatingInsertRequest, UserServiceRatingInsertRequest>
    {
        public UserServiceRatingController(IUserServiceRatingService service) : base(service) { }

        [Authorize]
        public override UserServiceRatingVM Insert([FromBody] UserServiceRatingInsertRequest insertObject)
        {
            return base.Insert(insertObject);
        }
    }
}
