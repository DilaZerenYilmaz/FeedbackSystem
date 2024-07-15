using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
	public interface IUserRepository : IRepository<User>, IAsyncRepository<User>
	{
	}
}
