using BuisnessLayer.Models;
using System.Threading.Tasks;

namespace BuisnessLayer.Interface
{
    public interface IInfo:Icrud<InfoModel>
    {
        Task<InfoModel> GeTInfoByCHanellID(int id);
    }
}
