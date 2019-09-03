using Microsoft.EntityFrameworkCore;
using SailbotVSv3.Managers;
using System;

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

        public static Type GetSensorType(string sensorType)
        {
            switch (sensorType)
            {
                case "Wind":
                    return typeof(Wind);
                case "WinchMotor":
                    return typeof(WinchMotor);
                case "RudderMotor":
                    return typeof(RudderMotor);
                case "GPS":
                    return typeof(GPS);
                case "BoomAngle":
                    return typeof(BoomAngle);
                case "BMS":
                    return typeof(BMS);
                case "Accelerometer":
                    return typeof(Accelerometer);
                default:
                    return null;
            }
        }
    }
}
