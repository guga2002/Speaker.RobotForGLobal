
using DatabaseOperations.Interfaces;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Speaker.leison.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositories
{
    public class ChanellRepository : BaseRepository,IChanellRepository
    {
        private readonly System.Data.Entity.DbSet<Chanell> chanells;
        public ChanellRepository() : base()
        {
            chanells = this.database.Set<Chanell>();
        }

        public async Task Add(Chanell item)
        {
            if (!chanells.Any(io => io.Name==item.Name&&io.PortIn250==item.PortIn250))
            {
               chanells.Add(item);
               database.SaveChanges();
                await Task.Delay(20);
            }
            // aseti  info ukve aris bazashi
        }

        public async Task<Chanell> GetChanellByPort(int port)
        {
            var res =  chanells.Where(io => io.PortIn250 == port).FirstOrDefault();
            if(res==null)
            {
                await Task.Delay(20);
                return new Chanell();
            }
            return res;
        }

        public  Task Remove(int id)
        {
            var res =  chanells.Where(io => io.PortIn250 == id).FirstOrDefault();
            if (res != null)
            {
                chanells.Remove(res);
                 database.SaveChanges();
            }
            return Task.CompletedTask;
        }

        public  Task View(int id)
        {
            var res = chanells.Where(io => io.PortIn250 == id).FirstOrDefault();

            if (res != null)
            {
                MessageBox.Show(res.Name.ToString());

            }
            else
            {
                MessageBox.Show("bazashi info ar aris");
            }
            return Task.CompletedTask;
        }
    }
}
