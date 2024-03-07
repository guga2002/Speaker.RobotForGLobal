using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speaker.leison.Entities
{
    [Table("Infos")]
    public class Info 
    {
        [Key]
        [Column("Info_Id")]
        public int Id { get; set; }

        [Column("Alarm_For_Display")]
        public string AlarmMessage { get; set; }

        [ForeignKey("chanell")]
        [Column("CHanell_Id")]
        public int CHanellId { get; set; }
        public Chanell chanell { get; set; }
    }
}
