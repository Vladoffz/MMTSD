using System.Collections.Generic;

namespace MMTSD.BLL.Abstract
{
    public interface IGenericService<T>
    {
        void Create(T obj);
        void Update(T obj);
        void Delete(int id);
        void Pizda(string id);
        T Read();
        IEnumerable<T> GetAll();
    }
}
