using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowsController : ControllerBase
    {
        public FollowsController()
        {
        }

        [HttpGet]
        public IActionResult GetFollows()
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), FollowerId = Guid.NewGuid(), FollowingId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), FollowerId = Guid.NewGuid(), FollowingId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), FollowerId = Guid.NewGuid(), FollowingId = Guid.NewGuid() }
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetFollowById([FromRoute] Guid id)
        {
            return Ok(new { Id = id, FollowerId = Guid.NewGuid(), FollowingId = Guid.NewGuid() });
        }

        [HttpGet("followers/{userId}")]
        public IActionResult GetFollowers([FromRoute] Guid userId)
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), FollowerId = Guid.NewGuid(), FollowingId = userId },
                new { Id = Guid.NewGuid(), FollowerId = Guid.NewGuid(), FollowingId = userId }
            });
        }

        [HttpGet("following/{userId}")]
        public IActionResult GetFollowing([FromRoute] Guid userId)
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), FollowerId = userId, FollowingId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), FollowerId = userId, FollowingId = Guid.NewGuid() }
            });
        }

        [HttpPost]
        public IActionResult CreateFollow([FromBody] object follow)
        {
            return Ok(new
            { Id = Guid.NewGuid(), FollowerId = Guid.NewGuid(), FollowingId = Guid.NewGuid() });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFollow([FromRoute] Guid id)
        {
            return Ok(new { Message = $"Follow with ID {id} deleted successfully." });
        }
    }
}
