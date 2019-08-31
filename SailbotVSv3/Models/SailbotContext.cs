using Microsoft.EntityFrameworkCore;
namespace SailbotVSv3.Models
{
    public class SailbotContext : DbContext
    {
        public SailbotContext(DbContextOptions<SailbotContext> options) : base(options)
        {
            Database.EnsureCreated();  
        }

        public DbSet<Wind> Wind { get; set; }
    }
}
