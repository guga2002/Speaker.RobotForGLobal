using System.Threading.Tasks;

namespace Speaker.leison.Sistem.layer.Interfaces
{
    public interface ISoundRepository
    {
        Task SpeakNow(string text);
    }
}
