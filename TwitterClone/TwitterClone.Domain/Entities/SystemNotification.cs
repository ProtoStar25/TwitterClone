namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public Guid SystemId { get; set; }
        public SystemNotification(Guid systemId) : base("System")
        {
            SystemId = systemId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string GetMessage()
        {
            return $"System notification from ID {SystemId}: {Message}";
        }
    }
}
