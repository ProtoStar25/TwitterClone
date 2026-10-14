using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Services
{
    public class TweetService : ITweetService
    {
        private readonly ITweetRepository _tweetRepository;

        public TweetService(ITweetRepository tweetRepository)
        {
            _tweetRepository = tweetRepository;
        }

        public TweetDto? CreateTweet(CreateTweetDto createTweetDto)
        {
            if (string.IsNullOrWhiteSpace(createTweetDto.Content))
            {
                return null;
            }
            var createdTweet = _tweetRepository.AddTweet(new Tweet
            {
                Content = createTweetDto.Content,
                UserId = createTweetDto.UserId,
            });
            return new TweetDto
            {
                Id = createdTweet.Id,
                Content = createdTweet.Content,
                UserId = createdTweet.UserId,
            };
        }
        public TweetDto GetTweetById(Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);
            if (tweet == null)
            {
                return null;
            }
            return new TweetDto
            {
                Id = tweet.Id,
                Content = tweet.Content,
                UserId = tweet.UserId,
            };
        }
        
        public TweetDto UpdateTweet(Guid id, UpdateTweetDto updateTweetDto)
        {
            var tweet = _tweetRepository.GetTweetById(id);
            if (tweet == null)
            {
                return null;
            }
            tweet.Content = updateTweetDto.Content;
            var updatedTweet = _tweetRepository.UpdateTweet(tweet);
            return new TweetDto
            {
                Id = updatedTweet.Id,
                Content = updatedTweet.Content,
                UserId = updatedTweet.UserId,
            };
        }

        public List<TweetDto> GetTweets()
        {
            var tweets = _tweetRepository.GetTweets();
            return tweets.Select(tweet => new TweetDto
            {
                Id = tweet.Id,
                Content = tweet.Content,
                UserId = tweet.UserId,
            }).ToList();
        }

        public bool DeleteTweet(Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);
            if (tweet == null)
            {
                return false;
            }
            return _tweetRepository.DeleteTweet(tweet);
        }
    }
}
