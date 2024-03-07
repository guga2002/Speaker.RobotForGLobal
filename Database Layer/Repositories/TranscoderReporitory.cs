
using DatabaseOperations.Interfaces;
using Microsoft.EntityFrameworkCore;
using Speaker.leison.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositories
{
    public class TranscoderReporitory : BaseRepository, ITranscoderRepository
    {
        private readonly System.Data.Entity.DbSet<Transcoder> Transcoder;
        public TranscoderReporitory() : base()
        {
            this.Transcoder = database.Set<Transcoder>();
        }

        public async Task Add(Transcoder item)
        {
            if (!Transcoder.Any(io => io.ChanellId == item.ChanellId))
            {
                Transcoder.Add(item);
                await database.SaveChangesAsync();
            }
        }

        public async  Task<Transcoder> GetTranscoderInfoByCHanellId(int id)
        {
            var res = await Transcoder.Where(io => io.ChanellId == id).FirstOrDefaultAsync();
            return res ?? new Transcoder();
        }

        public async Task Remove(int id)
        {
            var res = await Transcoder.Where(io => io.ChanellId == id).FirstOrDefaultAsync();
            if (res != null)
            {
                Transcoder.Remove(res);
                await database.SaveChangesAsync();
            }
        }

        public async Task View(int id)
        {
            var res = await Transcoder.Where(io => io.ChanellId == id).FirstOrDefaultAsync();

            if (res != null)
            {
                MessageBox.Show(res.ToString());
            }
        }
    }
}
