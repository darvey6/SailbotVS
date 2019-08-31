using System;
using System.Collections.Generic;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;

namespace SailbotVSv3.Managers
{
    public class GPSManager
    {
        private GPSRepository gpsRepository;

        public GPSManager(SailbotContext context)
        {
            gpsRepository = new GPSRepository(context);
        }

        public List<GPS> GetAllGPS()
        {
            return gpsRepository.GetAllGPS();
        }
    }
}
