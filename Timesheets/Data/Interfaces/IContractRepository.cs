using System;
using System.Threading.Tasks;
using Timesheets.Models;

namespace Timesheets.Data.Interfaces
{
    public interface IContractRepository : IBaseRepository<Contract>
    {
        public Task<bool?> CheckContractIsActive(Guid id);
    }
}
