using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speaker.leison.Entities
{
    [Table("Transcoders")]
    public class Transcoder
    {
        [Key]
        [Column("Transcoder_Id")]
        public int Id { get; set; }
        [Column("Card_In_Transcoder")]
        public int Card { get; set; }

        [Column("Port_In_Transcoder")]
        public int Port { get; set; }

      
        [Column("Chanell_Id")]
        [ForeignKey("Chanell")]
        public int ChanellId { get; set; }

        public Chanell Chanell { get; set; }
    }
}
