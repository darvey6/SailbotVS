using SailbotVSv3.Models;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class WinchMotorRepository
    {
        private readonly SailbotContext context;

        public WinchMotorRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<WinchMotor> GetAllWinchMotor()
        {
            var a = (from w in context.WinchMotor
                     select w).ToList();
            return a;
        }
    }
}
