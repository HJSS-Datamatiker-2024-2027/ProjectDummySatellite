using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDummySatellite.API.DAL;
using System.Reflection.Metadata.Ecma335;

namespace ProjectDummySatellite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicensesController : ControllerBase
    {
        private readonly ExtensionLicenseDAO _dao;

        public LicensesController()
        {
            _dao = new ExtensionLicenseDAO();
        }

        [HttpGet]
        public ActionResult GetAll(Guid tenantId)
        {
            try
            {
                return Ok(_dao.GetAll(tenantId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("one")]
        public ActionResult Get(Guid tenantId, int extensionId)
        {
            try
            {
                return Ok(_dao.Get(tenantId, extensionId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
