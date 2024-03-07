using Speaker.leison.Entities;
using System.Data.Entity;

namespace Speaker.leison.Kontext
{
    public class SpeakerDb : DbContext
    {
        public SpeakerDb():base("gugasString")
        {
        }

        public virtual DbSet<Chanell> Chanells { get; set; }

        public virtual DbSet<Info> Infos { get; set; }

        public virtual DbSet<Transcoder> Transcoders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Transcoder>()
            // .HasRequired(t => t.Chanell)
            // .WithOptional(c => c.Transcoder);
        }
    }
}