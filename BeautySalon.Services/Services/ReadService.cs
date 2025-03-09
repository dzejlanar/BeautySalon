using AutoMapper;
using BeautySalon.Model.Pagination;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;

namespace BeautySalon.Services.Services
{
    public abstract class ReadService<T, TDb, TSearch> : IReadService<T, TSearch> 
        where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public readonly BeautySalonContext _context;
        public readonly IMapper _mapper;

        public ReadService(BeautySalonContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual PagedResult<T> Get(TSearch? searchObject)
        {
            var entities = _context.Set<TDb>().AsQueryable();
            entities = AddFilter(entities, searchObject);

            if (searchObject?.pageNumber.HasValue == true && searchObject?.pageSize.HasValue == true)
            {
                entities = entities.Skip((searchObject.pageNumber.Value - 1) * searchObject.pageSize.Value).Take(searchObject.pageSize.Value);
            }

            var pagedResult = new PagedResult<T>
            {
                contentItems = _mapper.Map<List<T>>(entities.ToList()),
                totalItems = entities.Count()
            };

            return pagedResult;
        }

        public virtual T GetOne(int id)
        {
            var entity = _context.Set<TDb>().Find(id);
            return _mapper.Map<T>(entity);
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch? searchObject)
        {
            return query;
        }
    }
}
