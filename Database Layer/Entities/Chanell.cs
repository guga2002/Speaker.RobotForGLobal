using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speaker.leison.Entities
{

    [Table("Chanells")]
    public class Chanell
    {
        [Key]
        [Column("Chanell_Id")]
        public int Id { get; set; }

        [Column("ChanellFormat")]
        public string ChanellFormat { get; set; } //MPG4 vs MPG2
        [Column("Port_In_250")]
        public int PortIn250 { get; set; }

        [Column("Is_From_Optic")]
        public bool FromOptic { get; set; }

        [Column("Name_Of_Chanell")]
        public string Name { get; set; }

        public List<Info> Infos { get; set; }

        public List<Transcoder> Transcoder { get; set; }
    }
}
