using Interfaces;
using Speaker.leison.Entities;
using System.Threading.Tasks;

namespace DatabaseOperations.Interfaces
{
    public interface ITranscoderRepository:BaseInterface<Transcoder>
    {
        Task<Transcoder> GetTranscoderInfoByCHanellId(int id);
    }
}
