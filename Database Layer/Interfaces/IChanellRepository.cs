
using Speaker.leison.Entities;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IChanellRepository:BaseInterface<Chanell>
    {
        Task<Chanell> GetChanellByPort(int port);
    }
}
