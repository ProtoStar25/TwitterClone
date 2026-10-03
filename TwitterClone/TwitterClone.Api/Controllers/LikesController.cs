using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        public LikesController()
        {
        }
        [HttpGet]
        public IActionResult GetLikes()
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() }
            });
        }
        [HttpPost]
        public IActionResult CreateLike()
        {
            return Ok(new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() });
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLike([FromRoute] Guid id)
        {
            return Ok(new { Message = $"Like with ID {id} deleted successfully." });
        }
    }
}
