using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        public TweetsController()
        {
        }
        [HttpGet]
        public IActionResult GetTweets()
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Content = "Hello, world!" },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Content = "This is a tweet." },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Content = "Another tweet here." }
            });
        }
    }
}
