using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;

namespace BeautySalon.Services.Interfaces
{
    public interface IUserService
        : ICRUDService<UserVM, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        UserVM? Login(string username, string password);
    }
}
