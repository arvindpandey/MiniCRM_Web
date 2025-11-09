using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniCRM_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IActionResult GetUser()
        {
            return Ok(new { Name = "Arvind Pndey", Role = "Administrator" });
        }
    }
}
