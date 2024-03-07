using BuisnessLayer.Models;
using System.Threading.Tasks;

namespace BuisnessLayer.Interface
{
    public interface Ichanell:Icrud<ChanellModel>
    {
        Task<ChanellModel> GetChanellByPort(int port);
    }
}
