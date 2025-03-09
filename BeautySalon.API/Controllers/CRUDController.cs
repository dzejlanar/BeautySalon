using BeautySalon.Model.SearchObjects;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    [Authorize]
    public class CRUDController<T, TSearch, TInsert, TUpdate> : ReadController<T, TSearch>
        where T : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        protected new ICRUDService<T, TSearch, TInsert, TUpdate> _service;

        public CRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service) 
        {
            _service = service;
        }

        [HttpPost]
        public virtual T Insert([FromBody] TInsert insertObject) 
        {
            return _service.Insert(insertObject);
        }

        [HttpPut("{id}")]
        public virtual ActionResult<T> Update(int id, [FromBody] TUpdate updateObject)
        {
            var result = _service.Update(id, updateObject);

            if (result == null)
                return BadRequest();

            return result;
        }
    }
}
