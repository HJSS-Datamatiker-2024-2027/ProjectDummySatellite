using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectDummySatellite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicensesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAllAsync(Guid tenantId)
        {
            
        }
    }
}
