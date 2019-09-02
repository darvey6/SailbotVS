using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SailbotVSv3.Models
{
    [Table("BMSView")]
    public class BMS : ISensor
    {
        [Key]
        public int SensorID { get; set; }
        public int BatteryCurrent { get; set; }
        public int BatteryTemperature { get; set; }
        public int BatteryVoltage { get; set; }
        public int Current { get; set; }
        public int Voltage { get; set; }
        public int Temperature { get; set; }
        public bool Status { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}














