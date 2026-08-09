namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private string _message;
        private bool _isRead;
        private DateTime _created;

        public Notification(Guid id, Guid userId, string message)
        {
            _id = id;
            _userId = userId;
            _message = message;
            _isRead = false;
            _created = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid UserId
        {
            get { return _userId; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime Created
        {
            get { return _created; }
        }

    }
}
