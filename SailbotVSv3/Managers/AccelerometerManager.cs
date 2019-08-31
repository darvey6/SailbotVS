using System;
using System.Collections.Generic;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;

namespace SailbotVSv3.Managers
{
    public class AccelerometerManager
    {
        private AccelerometerRepository accelerometerRepository;

        public AccelerometerManager(SailbotContext context)
        {
            accelerometerRepository = new AccelerometerRepository(context);
        }

        public List<Accelerometer> GetAllAccelerometer()
        {
            return accelerometerRepository.GetAllAccelerometer();
        }
    }
}
