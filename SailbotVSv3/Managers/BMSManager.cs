using System;
using System.Collections.Generic;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;

namespace SailbotVSv3.Managers
{
    public class BMSManager
    {
        private BMSRepository bmsRepository;

        public BMSManager(SailbotContext context)
        {
            bmsRepository = new BMSRepository(context);
        }

        public List<BMS> GetAllBMS()
        {
            return bmsRepository.GetAllBMS();
        }
    }
}
