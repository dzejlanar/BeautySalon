using AutoMapper;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Services.Services
{
    public class CRUDService<T, TDb, TSearch, TInsert, TUpdate> : ReadService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate>
        where T : class where TDb : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        public CRUDService(BeautySalonContext context, IMapper mapper) : base(context, mapper) { }

        public virtual T Insert(TInsert insertObject)
        {
            var entity = _mapper.Map<TDb>(insertObject);
            _context.Set<TDb>().Add(entity);

            BeforeInsert(entity, insertObject);

            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T? Update(int id, TUpdate updateObject)
        {
            var entityToUpdate = _context.Set<TDb>().Find(id);
            if (entityToUpdate != null)
            {
                _mapper.Map(updateObject, entityToUpdate);
            }
            else
            {
                return null;
            }

            _context.SaveChanges();

            return _mapper.Map<T>(entityToUpdate);
        }

        public virtual T? Delete(int id)
        {
            var entityToDelete = _context.Set<TDb>().Find(id);
            if (entityToDelete != null)
            {
                _context.Remove(entityToDelete);
            }
            else
            {
                return null;
            }

            _context.SaveChanges();

            return _mapper.Map<T>(entityToDelete);
        }

        public virtual void BeforeInsert(TDb entity, TInsert insertObject) { }
    }
}
