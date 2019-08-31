using System.Collections.Generic;
using SailbotVSv3.Models;
using SailbotVSv3.Repositories;

namespace SailbotVSv3.Managers
{
    public class WinchMotorManager
    {
        private WinchMotorRepository winchMotorRepository;

        public WinchMotorManager(SailbotContext context)
        {
            winchMotorRepository = new WinchMotorRepository(context);
        }

        public List<WinchMotor> GetAllWinchMotor()
        {
            return winchMotorRepository.GetAllWinchMotor();
        }
    }
}
