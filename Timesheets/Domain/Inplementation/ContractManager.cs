using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Inplementation
{
    public class ContractManager : IContractManager
    {
        private readonly IContractRepository _contractRepository;
        public ContractManager(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }
        public async Task<bool?> CheckContractIsActive(Guid id)
        {
            var result = await _contractRepository.CheckContractIsActive(id);
            return result;
        }

        public Task<Guid> Create(ContractRequest request)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contract>> GetItems()
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, ContractRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
