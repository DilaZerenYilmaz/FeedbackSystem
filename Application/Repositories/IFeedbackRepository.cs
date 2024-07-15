using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
	public interface IFeedbackRepository : IRepository<Feedback>, IAsyncRepository<Feedback>
	{
	}
}
