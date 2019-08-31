using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SailbotVSv3.Models
{
    [Table("WindView")]
    public class Wind
    {
        [Key]
        public int SensorID { get; set; }
        public int WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public bool WindReference { get; set; }
        public int WindTemperature { get; set; }
        public int Current { get; set; }
        public int Voltage { get; set; }
        public int Temperature { get; set; }
        public bool Status { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}














 