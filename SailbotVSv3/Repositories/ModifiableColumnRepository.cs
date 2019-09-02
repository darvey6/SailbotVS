using SailbotVSv3.Models;
using System.Collections.Generic;
using System.Linq;

namespace SailbotVSv3.Repositories
{
    public class ModifiableColumnRepository
    {
        private readonly SailbotContext context;

        public ModifiableColumnRepository(SailbotContext context)
        {
            this.context = context;
        }

        public List<string> GetModifiableColumns(string sensorType)
        {
            var columns = (from a in context.ModifiableColumns
                           where a.SensorType == sensorType
                           select a.Column).ToList();
            return columns;
        }
    }
}
