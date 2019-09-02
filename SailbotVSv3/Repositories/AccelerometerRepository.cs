using SailbotVSv3.Models;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class AccelerometerRepository
    {
        private readonly SailbotContext context;

        public AccelerometerRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<Accelerometer> GetAllAccelerometer()
        {
            var a = (from w in context.Accelerometer
                     select w).ToList();
            return a;
        }
    }
}
