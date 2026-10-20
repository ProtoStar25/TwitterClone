using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Interfaces
{
    public interface ITweetRepository
    {
        Tweet AddTweet(Tweet tweet);
        Tweet UpdateTweet(Tweet tweet);
        bool DeleteTweet(Tweet tweet);
        Tweet? GetTweetById(Guid id);
        List<Tweet> GetTweets();
    }
}
