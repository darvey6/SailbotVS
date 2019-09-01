using System.ComponentModel.DataAnnotations;

namespace SailbotVSv3.Models
{
    public interface ISensor
    {
        [Key]
        int SensorID { get; set; }
    }
}
