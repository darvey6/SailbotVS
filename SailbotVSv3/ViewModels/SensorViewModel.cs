using SailbotVSv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailbotVSv3.ViewModels
{
    public class SensorViewModel
    {
        public List<ISensor> Sensors { get; set; }
        public Type Type { get; set; }
        public bool RenderButtons { get; set; }
    }
}
