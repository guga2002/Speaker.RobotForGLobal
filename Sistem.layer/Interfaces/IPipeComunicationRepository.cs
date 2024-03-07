using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speaker.leison.Sistem.layer.Interfaces
{
    public interface IPipeComunicationRepository
    {
        string Receive();
        void Send(string message);
    }
}
