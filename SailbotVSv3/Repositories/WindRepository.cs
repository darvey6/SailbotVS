using System;
using System.Collections.Generic;
using SailbotVSv3.Models;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class WindRepository
    {
        private SailbotContext context;

        public WindRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<Wind> GetAllWind()
        {
            return new List<Wind>
            {
                context.Wind.First(i => i.SensorID == 1)
            };
            
        }
    }
}
