using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<object>
            {
                new { Id = Guid.NewGuid(), Username = "pesssi", Email = "example1@gmail.com" },
                new { Id = Guid.NewGuid(), Username = "penaldo", Email = "example2@gmail.com" },
                new { Id = Guid.NewGuid(), Username = "neymar", Email = "example3@gmail.com" }
            };
            return Ok(users);
        }
    }
}
