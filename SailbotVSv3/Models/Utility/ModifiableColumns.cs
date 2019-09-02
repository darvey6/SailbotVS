using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SailbotVSv3.Models
{
    [Table("ModifiableColumns")]
    public class ModifiableColumns
    {
        [Key]
        public int pkModifiableColumID { get; set; }
        public string SensorType { get; set; }
        public string Column { get; set; }
    }
}
