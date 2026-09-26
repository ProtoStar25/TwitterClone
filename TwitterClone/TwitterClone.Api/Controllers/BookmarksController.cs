using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookmarksController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public BookmarksController()
        {

        }
        [HttpGet]
        public IActionResult GetBookmarks()
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() }
            });
        }

        [HttpPost]
        public IActionResult CreateBookmark()
        {
            return Ok(new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid() });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBookmark([FromRoute] Guid id)
        {
            return Ok(new { Message = $"Bookmark with ID {id} deleted successfully." });

        }
    }
}
