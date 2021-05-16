using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Data.Interfaces
{
    public interface IBaseRepository<T>
    {
        T GetItem(Guid id);
        IEnumerable<T> GetItems();
        void Add(T item);
        void Update();

    }
}
