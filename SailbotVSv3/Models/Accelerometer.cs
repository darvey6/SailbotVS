using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SailbotVSv3.Models
{
    [Table("AccelerometerView")]
    public class Accelerometer 
    {
        [Key]
        public int SensorID { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int Current { get; set; }
        public int Voltage { get; set; }
        public int Temperature { get; set; }
        public bool Status { get; set; }
        public DateTime UpdatedTime { get; set; }
        public static PropertyInfo[] GetColumns()
        {
            return typeof(Accelerometer).GetProperties();
        }
    }
}














 