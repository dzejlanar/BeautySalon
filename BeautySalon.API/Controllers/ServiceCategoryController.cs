using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Controllers
{
    public class ServiceCategoryController : CRUDController<ServiceCategoryVM, ServiceCategorySearchObject, ServiceCategoryUpsertRequest, ServiceCategoryUpsertRequest>
    {
        public ServiceCategoryController(IServiceCategoryService service) : base(service) { }

        [HttpDelete("{id}")]
        [Authorize("Admin")]
        public virtual ActionResult<ServiceCategoryVM> Delete(int id)
        {
            var result = ((ICRUDService<ServiceCategoryVM, ServiceCategorySearchObject, ServiceCategoryUpsertRequest, ServiceCategoryUpsertRequest>)_service).Delete(id);

            if (result == null)
                return BadRequest();

            return result;
        }
    }
}
