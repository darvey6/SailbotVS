using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SailbotVSv3.Models
{
    [Table("WinchMotorView")]
    public class WinchMotor
    {
        [Key]
        public int SensorID { get; set; }
        public int Current { get; set; }
        public int Voltage { get; set; }
        public int Temperature { get; set; }
        public bool Status { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}














 