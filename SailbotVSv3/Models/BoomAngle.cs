using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SailbotVSv3.Models
{
    [Table("BoomAngleView")]
    public class BoomAngle : ISensor
    {
        [Key]
        public int SensorID { get; set; }
        public decimal Angle { get; set; }
        public int Current { get; set; }
        public int Voltage { get; set; }
        public int Temperature { get; set; }
        public bool Status { get; set; }
        public DateTime UpdatedTime { get; set; }
        public static PropertyInfo[] GetColumns()
        {
            return typeof(BoomAngle).GetProperties();
        }
    }
}














