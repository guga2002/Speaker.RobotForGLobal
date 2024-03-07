using BuisnessLayer.Interface;
using BuisnessLayer.Models;
using DatabaseOperations.Interfaces;
using Repositories;
using Speaker.leison.Entities;
using System.Threading.Tasks;

namespace BuisnessLayer.Services
{
    public class TranscoderServices : ITranscoder
    {
        private readonly ITranscoderRepository repos;
        public TranscoderServices()
        {
            this.repos = new TranscoderReporitory();
        }
        public async Task Add(TranscoderModel item)
        {
            await repos.Add(new Transcoder()
            {
                Card=item.Card,
                ChanellId=item.ChanellId,
                Port=item.Port,
            });
        }

        public async Task<TranscoderModel> GetTranscoderInfoByCHanellId(int id)
        {
            var res = await repos.GetTranscoderInfoByCHanellId(id);
            if (res != null)
            {
                return new TranscoderModel()
                {
                    Card=res.Card,
                    ChanellId=res.ChanellId,
                    Port=res.Port,
                };
            }
            return new TranscoderModel();
        }

        public async  Task Remove(int id)
        {
            await repos.Remove(id);
        }

        public async Task View(int id)
        {
            await repos.Remove(id);
        }
    }
}
