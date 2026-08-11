namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public Guid FriendRequestByUserId { get; set; }
        public FriendRequestNotification(Guid friendRequestByUserId) : base("FriendRequest")
        {
            FriendRequestByUserId = friendRequestByUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}
