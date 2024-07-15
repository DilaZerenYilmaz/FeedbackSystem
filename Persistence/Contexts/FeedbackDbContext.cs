using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
	public class FeedbackDbContext : DbContext
	{
		public DbSet<Feedback> Feedbacks { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<OperationClaim> OperationClaims { get; set; }
		public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source = DILA; User ID = sa; Password = YourStrongPassword123!; TrustServerCertificate=true; Database = FeedbackDb; Trusted_Connection = false");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
