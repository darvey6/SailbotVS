using System;
using System.Collections.Generic;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;

namespace SailbotVSv3.Managers
{
    public class RudderMotorManager
    {
        private RudderMotorRepository rudderMotorRepository;

        public RudderMotorManager(SailbotContext context)
        {
            rudderMotorRepository = new RudderMotorRepository(context);
        }

        public List<RudderMotor> GetAllRudderMotor()
        {
            return rudderMotorRepository.GetAllRudderMotor();
        }
    }
}
