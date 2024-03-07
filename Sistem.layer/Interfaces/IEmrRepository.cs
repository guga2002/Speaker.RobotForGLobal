using System.Collections.Generic;
using System.Threading.Tasks;

namespace Speaker.leison.Sistem.layer.Interfaces
{
    public interface IEmrRepository
    {
        Task<HashSet<int>> GetPortsWhereAlarmsIsOn();
    }
}
