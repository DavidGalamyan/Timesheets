using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Timesheets.Domain.Interfaces
{
    /// <summary> TModel это дженерик для возврата модели, TRequest дженерик для DtoRequest </summary>

    public interface IBaseManager<TModel,TRequest> 
    {
        public Task<TModel> GetItem(Guid id);
        public Task<IEnumerable<TModel>> GetItems();
        public Task<Guid> Create(TRequest request);
        public Task Update(Guid id, TRequest request);
        public Task Delete(Guid id);
    }
}
