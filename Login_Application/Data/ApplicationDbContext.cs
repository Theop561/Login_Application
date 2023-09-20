using Login_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_Application.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<RegisterViewModel> Accounts { get; set; }
    }
}
