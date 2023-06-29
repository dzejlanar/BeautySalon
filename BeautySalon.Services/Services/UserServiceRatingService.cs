using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Services.Services
{
    public class UserServiceRatingService : CRUDService<UserServiceRatingVM, UserServiceRating, BaseSearchObject, UserServiceRatingInsertRequest, UserServiceRatingInsertRequest>, IUserServiceRatingService
    {
        public UserServiceRatingService(BeautySalonContext context, IMapper mapper) : base(context, mapper) { }

        public override void BeforeInsert(UserServiceRating entity, UserServiceRatingInsertRequest insertObject)
        {
            entity.CreatedDate = DateTime.UtcNow;
        }
    }
}
