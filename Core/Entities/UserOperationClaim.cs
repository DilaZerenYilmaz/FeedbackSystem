using Core.DataAccess;

namespace Core.Entities
{
    public class UserOperationClaim : Entity<int>
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
//