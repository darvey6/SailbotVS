using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SailbotVSv3.Models
{
    [Table("WindView")]
    public class Wind : ISensor
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

        public static PropertyInfo[] GetColumns()
        {
            return typeof(Wind).GetProperties();
        }
    }
}














