using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecords.DAL
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entity);
        void Remove(T entity);
    }
}
