using SailbotVSv3.Models;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class GPSRepository
    {
        private readonly SailbotContext context;

        public GPSRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<GPS> GetAllGPS()
        {
            var a = (from w in context.GPS
                     select w).ToList();
            return a;
        }
    }
}
