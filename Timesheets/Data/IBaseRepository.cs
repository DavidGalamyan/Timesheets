using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Models.Dto;

namespace Timesheets.Data.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<T> GetItem(Guid id);
        Task<IEnumerable<T>> GetItems();
        Task Add(T item);
        Task Update(T item);
        Task Delete(Guid id);
    }
}
