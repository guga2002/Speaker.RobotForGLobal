using BuisnessLayer.Models;
using System.Threading.Tasks;

namespace BuisnessLayer.Interface
{
    public interface ITranscoder:Icrud<TranscoderModel>
    {
        Task<TranscoderModel> GetTranscoderInfoByCHanellId(int id);
    }
}
