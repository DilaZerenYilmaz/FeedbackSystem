using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
	public class FeedbackRepository : EfRepositoryBase<Feedback, FeedbackDbContext>, IFeedbackRepository
	{
		public FeedbackRepository(FeedbackDbContext context) : base(context)
		{
		}
	}
}
