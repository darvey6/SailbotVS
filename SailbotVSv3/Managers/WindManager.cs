using System;
using System.Collections.Generic;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;

namespace SailbotVSv3.Managers
{
    public class WindManager
    {
        private WindRepository windRepository;

        public WindManager()
        {
            windRepository = new WindRepository(ContextManager.GetContext());
        }

        public List<Wind> GetAllWind()
        {

            // Do some modification
            // Do post processing 
            return windRepository.GetAllWind();
        }
    }
}
