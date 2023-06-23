using BeautySalon.Model.SearchObjects;

namespace BeautySalon.Services.Interfaces
{
    public interface IReadService<T, TSearch> 
        where T : class where TSearch : BaseSearchObject
    {
        IEnumerable<T> Get(TSearch? searchObject);
        T GetOne(int id);
    }
}
