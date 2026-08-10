
namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikeByUserId { get; set; }

        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}
