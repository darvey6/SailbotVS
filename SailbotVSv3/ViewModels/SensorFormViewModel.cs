using SailbotVSv3.Models;
using System;
using System.Collections.Generic;

namespace SailbotVSv3.ViewModels
{
    public class SensorFormViewModel
    {
        public ISensor Sensor { get; set; }
        public Type Type { get; set; }
        public List<string> Columns { get; set; }
    }
}
