using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ServiceRecommendationController : ControllerBase
    {
        private readonly IRecommendationService _service;

        public ServiceRecommendationController(IRecommendationService service) 
        {
            _service = service;
        }

        [HttpGet("serviceId")]
        public List<ServiceVM> Recommend(int serviceId)
        {
            return _service.Recommend(serviceId);
        }
    }
}
