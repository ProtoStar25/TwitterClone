
namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        private Guid _followerId;
        private Guid _followingId;

        public Follow() : base(Guid.NewGuid())
        {

        }

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
        }
    }
}
