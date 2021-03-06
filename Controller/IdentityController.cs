using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace Api1Resource.Controllers
{
    [Route("identity")]
    [Authorize]
    public class IdentityController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new {c.Type,c.Value});
        }
    }
}