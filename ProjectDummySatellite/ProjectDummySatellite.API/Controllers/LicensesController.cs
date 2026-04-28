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

        [HttpGet("{extensionId}")]
        public ActionResult Get(Guid tenantId, Guid extensionId)
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

        [HttpDelete]
        public ActionResult Delete(Guid tenantId, Guid extensionId)
        {
            try
            {
                Random rnd = new Random();
                int randomInt = rnd.Next(0, 2);

                bool success = randomInt == 1;

                return Ok(success);
                //return Ok(_dao.Delete(tenantId, extensionId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
