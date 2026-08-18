
using System.Security;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikeable
    {
        private Guid _userid;
        private string _content;

        public Tweet() : base(Guid.NewGuid())
        {
            
        }

        public Guid _userId
        {
            get { return _userId; }
            set { _userId = value; }
        }
   
        public string Content
        {
            get { return _content; }
            set { _content = value; }
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
