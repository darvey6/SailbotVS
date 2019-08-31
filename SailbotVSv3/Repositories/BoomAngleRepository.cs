using SailbotVSv3.Models;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class BoomAngleRepository
    {
        private SailbotContext context;

        public BoomAngleRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<BoomAngle> GetAllBoomAngle()
        {
            var a = (from w in context.BoomAngle
                     select w).ToList();
            return a;
        }
    }
}
