using System;
using System.ComponentModel.DataAnnotations;

namespace SailbotVSv3.Models
{
    public class Wind
    {
        [Key]
        public int SensorID { get; set; }
        public string WindDirection { get; set; }
        public bool WindReference { get; set; }
        public int WindTemperature { get; set; }
        public int UCCMCurrent { get; set; }
        public int Voltage { get; set; }
        public DateTime UpdatedTime { get; set; }

    }
}














 