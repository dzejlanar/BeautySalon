using BeautySalon.Model.SearchObjects;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    public class CRUDController<T, TSearch, TInsert, TUpdate> : ReadController<T, TSearch>
        where T : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        public CRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service) { }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public virtual T Insert([FromBody] TInsert insertObject) 
        {
            return ((ICRUDService<T, TSearch, TInsert, TUpdate>)_service).Insert(insertObject);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public virtual ActionResult<T> Update(int id, [FromBody] TUpdate updateObject)
        {
            var result = ((ICRUDService<T, TSearch, TInsert, TUpdate>)_service).Update(id, updateObject);

            if (result == null)
                return BadRequest();

            return result;
        }
    }
}
