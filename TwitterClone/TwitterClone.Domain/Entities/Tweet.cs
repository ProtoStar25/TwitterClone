
using System.Security;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikeable
    {
        private Guid _userId;
        private string _content;
        public static int MaxContentLength = 200;
        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }
        public Tweet(Guid userId, string content) : base(Guid.NewGuid())
        {
            _userId = userId;
            _content = content;
        }

        public Tweet() : base(Guid.NewGuid())
        {
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
   
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public void AddContent(string content)
        {
            _content = content;
        }
        public void AddContent(string content, Guid userId)
        {
            _content = content;
            _userId = userId;
        }
        public bool CanBeLiked()
        {
            if(String.IsNullOrWhiteSpace(Content))
            {
                return false;
            }
            return true;
        }
    }
}
