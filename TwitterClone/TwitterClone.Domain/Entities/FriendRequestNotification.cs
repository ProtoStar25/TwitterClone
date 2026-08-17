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

        public override string GetMessage()
        {
            return $"User with ID {FriendRequestByUserId} sent you a friend request";
        }
    }
}
