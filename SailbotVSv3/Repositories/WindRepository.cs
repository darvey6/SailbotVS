using System.Collections.Generic;
using SailbotVSv3.Models;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class WindRepository
    {
        private readonly SailbotContext context;

        public WindRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<Wind> GetAllWind()
        {
            var a = (from w in context.Wind
                     select w).ToList();
            return a;
        }
    }
}
