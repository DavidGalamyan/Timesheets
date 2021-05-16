using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Inplementation
{
    public class ContractRepository : IContractRepository
    {
        public void Add(Contract contract)
        {
            throw new NotImplementedException();
        }

        public Contract GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contract> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
