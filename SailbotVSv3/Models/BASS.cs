using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SailbotVSv3.Models
{
    [Table("BASS")]
    public class BASS
    {
        [Key]
        public int BASSID { get; set; }
        public int UCCMCurrent { get; set; }
        public int UCCMVoltage { get; set; }
        public int UCCMTemperature { get; set; }
        public int UCCMStatus { get; set; }
        public DateTime UpdatedTime { get; set; }
    
    }
}



