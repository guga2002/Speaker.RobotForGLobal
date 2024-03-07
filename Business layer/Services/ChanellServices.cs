
using BuisnessLayer.Interface;
using BuisnessLayer.Models;
using DatabaseOperations.Interfaces;
using Interfaces;
using Repositories;
using Speaker.leison.Entities;
using System.Threading.Tasks;

namespace BuisnessLayer.Services
{
    public class ChanellServices : Ichanell
    {
        private readonly IChanellRepository chan;

        public ChanellServices()
        {
            this.chan = new ChanellRepository();
        }
        public async  Task Add(ChanellModel item)
        {
            await chan.Add(new Chanell()
            {
                FromOptic = item.FromOptic,
                ChanellFormat = item.ChanellFormat,
                Name = item.Name,
                PortIn250 = item.PortIn250

            });
        }

        public async Task<ChanellModel> GetChanellByPort(int port)
        {
            var res=await chan.GetChanellByPort(port);
            if(res!=null)
            {
                return new ChanellModel()
                {
                    ChanellFormat = res.ChanellFormat,
                    FromOptic = res.FromOptic,
                    Name = res.Name,
                    PortIn250 = res.PortIn250,
                };
            }
            return new ChanellModel();
        }

        public async Task Remove(int id)
        {
            await chan.Remove(id);
        }

        public async Task View(int id)
        {
            await chan.View(id);
        }
    }
}
