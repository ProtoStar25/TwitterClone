using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Api.Data;
using TwitterClone.Api.Dtos;
using TwitterClone.Api.Dtos.Tweet;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly TweetRepository _tweetRepository;
        public TweetsController(TweetRepository tweetRepository)
        {
            _tweetRepository = tweetRepository;
        }
        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = _tweetRepository.GetTweets();
            return Ok(tweets.Select(tweet => new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content
            }));
        }

        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute]Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);
            if(tweet == null)
            {
                return NotFound();
            }

            return Ok(new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content
            });
        }

        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetDto createTweetDto)
        {
            if (string.IsNullOrWhiteSpace(createTweetDto.Content))
            {
                return BadRequest("Content cannot be empty.");
            }
            
            var createdTweet = _tweetRepository.AddTweet(new Tweet
            {
                UserId = createTweetDto.UserId,
                Content = createTweetDto.Content
            });

            return Ok(new TweetDto
            {
                Id = createdTweet.Id,
                UserId = createdTweet.UserId,
                Content = createdTweet.Content
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute]Guid id, [FromBody] UpdateTweetDto updateTweetDto)
        {
            var tweet = _tweetRepository.GetTweetById(id);
            if (tweet == null)
            {
                return NotFound();
            }
            tweet.Content = updateTweetDto.Content;
            return Ok(new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute]Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);
            if(tweet == null)
            {
                return NotFound();
            }
            var isDeleted = _tweetRepository.DeleteTweet(tweet);
            return Ok(isDeleted);
        }
    }
}
