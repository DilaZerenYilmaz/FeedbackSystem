using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence
{
	public static class PersistenceServiceRegistration
	{
		public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
		{
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IFeedbackRepository, FeedbackRepository>();
			services.AddDbContext<FeedbackDbContext>();

			return services;
		}
	}
}
