using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TwitterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public IActionResult GetTweets()
        {
            var maxLength = _configuration.GetValue<int>("TwitterSettings:MaxTweetLength");
            var tweets = new List<object>
            {
                new
                { UserId = Guid.NewGuid(), Content = "Hello, world!"  },
                new
                { UserId = Guid.NewGuid(), Content = "This is a tweet."  },
                new
                { UserId = Guid.NewGuid(), Content = "Another tweet here."  }
            };
            return Ok(tweets);
        }
    }
}
