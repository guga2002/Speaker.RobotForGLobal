using System.Threading.Tasks;

namespace BuisnessLayer.Interface
{
    public interface Icrud<T>where T:class
    {
        Task Add(T item);
        Task Remove(int id);
        Task View(int id);
    }
}
