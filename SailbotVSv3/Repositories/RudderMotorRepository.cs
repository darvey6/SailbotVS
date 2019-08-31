using SailbotVSv3.Models;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class RudderMotorRepository
    {
        private SailbotContext context;

        public RudderMotorRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<RudderMotor> GetAllRudderMotor()
        {
            var a = (from w in context.RudderMotor
                     select w).ToList();
            return a;
        }
    }
}
