using Microsoft.EntityFrameworkCore;
namespace SailbotVSv3.Models
{
    public class SailbotContext : DbContext
    {
        public SailbotContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Wind> Wind { get; set; }
    }
}
