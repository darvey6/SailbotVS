using System;
using System.Collections.Generic;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;

namespace SailbotVSv3.Managers
{
    public class BoomAngleManager
    {
        private BoomAngleRepository boomAngleRepository;

        public BoomAngleManager(SailbotContext context)
        {
            boomAngleRepository = new BoomAngleRepository(context);
        }

        public List<BoomAngle> GetAllBoomAngle()
        {
            return boomAngleRepository.GetAllBoomAngle();
        }
    }
}
