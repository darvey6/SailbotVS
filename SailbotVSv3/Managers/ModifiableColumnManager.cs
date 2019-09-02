using SailbotVSv3.Models;
using SailbotVSv3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailbotVSv3.Managers
{
    public class ModifiableColumnManager
    {
        private readonly ModifiableColumnRepository modifiableColumnRepository;

        public ModifiableColumnManager(SailbotContext context)
        {
            modifiableColumnRepository = new ModifiableColumnRepository(context);
        }

        public List<string> GetModifiableColumns(string sensorType)
        {
            return modifiableColumnRepository.GetModifiableColumns(sensorType);
        }
    }
}
