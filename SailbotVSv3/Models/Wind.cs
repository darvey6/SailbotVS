using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SailbotVSv3.Models
{
    public class Wind
    {
        [Key]
        public int SensorID { get; set; }
        public int WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public bool WindReference { get; set; }
        public int WindTemperature { get; set; }
        public int UCCMCurrent { get; set; }
        public int UCCMVoltage { get; set; }
        public int UCCMTemperature { get; set; }
        public bool UCCMStatus { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}














 