using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthTaskJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [Authorize]
        [HttpGet("profile")]
        public IActionResult Profile()
        {
            var username = User.Identity.Name;
            return Ok($"Welcome {username}");
        }

        [Authorize(Roles = "admin")]
        [HttpGet("admin")]
        public IActionResult AdminOnly()
        {
            return Ok("Only accessible to admins.");
        }
        [HttpGet("owner")]
        [Authorize(Roles = "owner")]
        public IActionResult OwnerOnly()
        {
            return Ok("This is only for owners.");
        }

    }
}
