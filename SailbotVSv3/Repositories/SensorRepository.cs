using SailbotVSv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailbotVSv3.Repositories
{
    public class SensorRepository<T> where T : class
    {
        private readonly SailbotContext context;

        public SensorRepository(SailbotContext context)
        {
            this.context = context;
        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetSensor(int sensorID)
        {
            return context.Find<T>(sensorID);
        }
    }
}
