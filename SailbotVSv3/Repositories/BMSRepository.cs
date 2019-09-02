using SailbotVSv3.Models;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class BMSRepository
    {
        private readonly SailbotContext context;

        public BMSRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<BMS> GetAllBMS()
        {
            var a = (from w in context.BMS
                     select w).ToList();
            return a;
        }
    }
}
