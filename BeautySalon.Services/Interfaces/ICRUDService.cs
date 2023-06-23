using BeautySalon.Model.SearchObjects;

namespace BeautySalon.Services.Interfaces
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IReadService<T, TSearch> 
        where T : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        T Insert(TInsert insertObject);
        T? Update(int id, TUpdate updateObject);
        T? Delete(int id);
    }
}
