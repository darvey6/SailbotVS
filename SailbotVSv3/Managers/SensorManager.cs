using SailbotVSv3.Models;
using SailbotVSv3.Repositories;
using System;
using System.Collections.Generic;

namespace SailbotVSv3.Managers
{
    public class SensorManager<T> where T : class
    {
        private readonly SensorRepository<T> sensorRepository;

        public SensorManager(SailbotContext context)
        {
            sensorRepository = new SensorRepository<T>(context);
        }

        public List<T> GetAll()
        {
            return sensorRepository.GetAll();
        }

        public T GetSensor(int sensorID)
        {
            return sensorRepository.GetSensor(sensorID);
        }
    }
}
