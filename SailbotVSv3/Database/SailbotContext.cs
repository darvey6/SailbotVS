using Microsoft.EntityFrameworkCore;
namespace SailbotVSv3.Models
{
    public class SailbotContext : DbContext
    {
        public SailbotContext(DbContextOptions<SailbotContext> options) : base(options)
        {
        }

        public DbSet<Wind> Wind { get; set; }
        public DbSet<WinchMotor> WinchMotor { get; set; }
        public DbSet<RudderMotor> RudderMotor { get; set; }
        public DbSet<GPS> GPS { get; set; }
        public DbSet<BoomAngle> BoomAngle { get; set; }
        public DbSet<BMS> BMS { get; set; }
        public DbSet<Accelerometer> Accelerometer { get; set; }
        public DbSet<ModifiableColumns> ModifiableColumns { get; set; }
    }
}
