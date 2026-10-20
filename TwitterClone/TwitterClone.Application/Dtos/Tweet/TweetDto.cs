using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Dtos
{
    public class TweetDto
    {
        public required Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required string Content { get; set; }

    }
}
