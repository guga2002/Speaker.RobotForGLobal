using System.ComponentModel.DataAnnotations;

namespace Speaker.leison.Entities
{
    public class AbstractEntity
    {
        [Key]
        public int Id { get; set; }

        protected AbstractEntity()
        {
                
        }

        public AbstractEntity(int Id)
        {
            this.Id = Id;
        }
    }
}
