using System.Collections.Generic;

namespace MMTSD.DAL.Abstract
{
    public interface IGenericRepository<T>
    {
        void Create(T obj);
        void Update(T obj);
        void Delete(int id);
        T Read();
        IEnumerable<T> GetAll();
    }
}