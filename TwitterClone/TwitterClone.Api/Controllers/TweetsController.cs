using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly ITweetService _tweetService;
        public TweetsController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }
        [HttpGet]
        public IActionResult GetTweets()
        {
            return Ok(_tweetService.GetTweets());
        }

        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute]Guid id)
        {
            var tweet = _tweetService.GetTweetById(id);
            if(tweet == null)
            {
                return NotFound();
            }

            return Ok(tweet);
        }

        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetDto createTweetDto)
        {
            var createdTweet = _tweetService.CreateTweet(createTweetDto);
            if (createdTweet == null)
            {
                return BadRequest("Tweet Cannot be created");
            }
            return Ok(createdTweet);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute]Guid id, [FromBody] UpdateTweetDto updateTweetDto)
        {
            var tweet = _tweetService.GetTweetById(id);
            if (tweet == null)
            {
                return NotFound();
            }
            
            return Ok(tweet);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute]Guid id)
        {
            var isDeleted = _tweetService.DeleteTweet(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return Ok(isDeleted);
        }
    }
}
