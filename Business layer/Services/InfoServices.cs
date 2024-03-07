using BuisnessLayer.Interface;
using BuisnessLayer.Models;
using DatabaseOperations.Interfaces;
using Repositories;
using Speaker.leison.Entities;
using System.Threading.Tasks;


namespace BuisnessLayer.Services
{
    public class InfoServices : IInfo
    {
        private readonly IInfoRepository repos;

        public InfoServices()
        {
            this.repos = new InfoRepository();  
        }
        public async Task Add(InfoModel item)
        {
            await repos.Add(new Info()
            {
                AlarmMessage = item.AlarmMessage,
                CHanellId = item.CHanellId,
            });
        }

        public async Task<InfoModel> GeTInfoByCHanellID(int id)
        {
            var res = await repos.GeTInfoByCHanellID(id);
            if (res != null)
            {
                return new InfoModel()
                {
                    AlarmMessage=res.AlarmMessage,
                    CHanellId=res.CHanellId,
                };
            }
            return new InfoModel();
        }

        public async Task Remove(int id)
        {
            await repos.Remove(id);
        }

        public async Task View(int id)
        {
            await repos.View(id);
        }
    }
}
