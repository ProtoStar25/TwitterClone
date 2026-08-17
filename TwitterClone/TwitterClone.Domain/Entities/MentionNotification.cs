namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public Guid MentionByUserId{ get; set; }
        
        public MentionNotification(Guid mentionByUserId) : base("Mention")
        {
            MentionByUserId = mentionByUserId;
        }


        public override string GetMessage()
        {
            return $"User with ID {MentionByUserId} mentioned you in a post";
        }
    }
}
