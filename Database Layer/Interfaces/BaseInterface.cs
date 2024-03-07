using System.Threading.Tasks;

namespace Interfaces
{
    public interface BaseInterface<T>where T:class
    {
        Task Add(T item);
        Task Remove(int id);
        Task View(int id);
    }
}
