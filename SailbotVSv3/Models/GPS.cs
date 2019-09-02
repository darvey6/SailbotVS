using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SailbotVSv3.Models
{
    [Table("GPSView")]
    public class GPS : ISensor
    {
        [Key]
        public int SensorID { get; set; }
        public bool Quality { get; set; }
        public decimal HDOP { get; set; }
        public decimal AntennaAltitude { get; set; }
        public int GeoidalSeparation { get; set; }
        public DateTime GPRMCTimeStamp { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public decimal GroundSpeed { get; set; }
        public decimal TrackMadeGood { get; set; }
        public decimal MagneticVariation { get; set; }
        public int Voltage { get; set; }
        public int Temperature { get; set; }
        public bool Status { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}














