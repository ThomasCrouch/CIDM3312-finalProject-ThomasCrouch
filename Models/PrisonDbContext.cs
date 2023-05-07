using Microsoft.EntityFrameworkCore;

namespace finalProject_ThomasCrouch.Models
{
	public class PrisonDbContext : DbContext
	{
		public PrisonDbContext (DbContextOptions<PrisonDbContext> options)
			: base(options)
		{
		}

		public DbSet<Prison> Prisons {get; set;} = default!;
        public DbSet<Prisoner> Prisoners {get; set;} = default!;
	}
}
