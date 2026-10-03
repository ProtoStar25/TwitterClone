using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        public MessagesController()
        {
        }

        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "Hello!" },
                new { Id = Guid.NewGuid(), SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "How are you?" },
                new { Id = Guid.NewGuid(), SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "Goodbye!" }
            });
        }
        [HttpPost]
        public IActionResult SendMessage()
        {
            return Ok(new { Id = Guid.NewGuid(), SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "New message sent!" });

        }

        [HttpPut("{id}")]
        public IActionResult UpdateMessage([FromRoute]Guid id)
        {
            return Ok(new { Id = id, SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "Message updated!" });
        }

        [HttpPatch("{id}/read")]
        public IActionResult MarkMessageAsRead([FromRoute]Guid id)
        {
            return Ok(new { Id = id, SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "Message marked as read!" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage([FromRoute]Guid id)
        {
            return Ok(new { Id = id, SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "Message deleted!" });
        }
    }
}
