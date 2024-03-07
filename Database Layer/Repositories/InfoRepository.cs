
using DatabaseOperations.Interfaces;
using Microsoft.EntityFrameworkCore;
using Speaker.leison.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositories
{
    public class InfoRepository : BaseRepository,IInfoRepository
    {
        private readonly System.Data.Entity.DbSet<Info> Infos;
        public InfoRepository() : base()
        {
            Infos = database.Set<Info>();
        }

        public async Task Add(Info item)
        {
            if (!Infos.Any(io => io.CHanellId == item.CHanellId))
            {
                Infos.Add(item);
                await database.SaveChangesAsync();
            }
        }

        public async Task<Info> GeTInfoByCHanellID(int id)
        {
            var res =await  Infos.Where(io => io.CHanellId == id).FirstOrDefaultAsync();
            return res ?? new Info();
        }

        public async  Task Remove(int id)
        {
            var res = await Infos.Where(io => io.CHanellId == id).FirstOrDefaultAsync();
            if (res != null)
            {
                Infos.Remove(res);
                await database.SaveChangesAsync();
            }
        }

        public async Task View(int id)
        {
            var res = await Infos.Where(io => io.CHanellId == id).FirstOrDefaultAsync();

            if (res != null)
            {
                MessageBox.Show(res.ToString());
            }
        }
    }
}
