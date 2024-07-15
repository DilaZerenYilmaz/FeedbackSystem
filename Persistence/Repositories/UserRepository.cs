using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
	public class UserRepository : EfRepositoryBase<User, FeedbackDbContext>, IUserRepository
	{
		public UserRepository(FeedbackDbContext context) : base(context)
		{
		}
	}
}
