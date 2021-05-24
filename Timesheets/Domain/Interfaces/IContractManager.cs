using System;
using System.Threading.Tasks;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Interfaces
{
    public interface IContractManager : IBaseManager<Contract,ContractRequest>
    {
       public Task<bool?> CheckContractIsActive(Guid id);
    }
}
