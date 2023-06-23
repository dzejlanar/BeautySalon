using BeautySalon.Model.SearchObjects;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class ReadController<T, TSearch> : ControllerBase where T : class where TSearch : BaseSearchObject
    {
        public readonly IReadService<T, TSearch> _service;

        public ReadController(IReadService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet] 
        public virtual IEnumerable<T> Get([FromQuery] TSearch? searchObject) 
        {
            return _service.Get(searchObject);
        }

        [HttpGet("{id}")]
        public virtual T GetOne(int id)
        {
            return _service.GetOne(id);
        }
    }
}
