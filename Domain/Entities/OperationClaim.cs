
namespace Domain.Entities
{
	public class OperationClaim : Core.Entities.OperationClaim
	{
		public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
	}
}
