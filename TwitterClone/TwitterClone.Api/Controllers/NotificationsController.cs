using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        public NotificationsController() { }

        [HttpGet]
        public IActionResult GetNotifications()
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Message = "You have a new follower!" },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Message = "Your tweet has been liked!" },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Message = "You have a new mention!" }
            });
        }

        [HttpPost]
        public IActionResult CreateNotification([FromBody] object notification)
        {
            return Ok(new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), Message = "New notification created!" });
        }

    }
}
