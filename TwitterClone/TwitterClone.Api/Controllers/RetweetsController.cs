using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetweetsController : ControllerBase
    {
        public RetweetsController()
        {
        }

        [HttpGet]
        public IActionResult GetRetweets()
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() }
            });
        }
        [HttpPost]
        public IActionResult CreateRetweet()
        {
            return Ok(new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRetweet([FromRoute]Guid id)
        {
            return Ok(new { Id = id, UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() });
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRetweet([FromRoute]Guid id)
        {
            return Ok(new { Id = id });
        }
    }
}
