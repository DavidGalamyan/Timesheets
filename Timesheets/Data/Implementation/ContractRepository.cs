using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.EntityFramework;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{ 
    public class ContractRepository : IContractRepository
    {
        private readonly TimesheetDbContext _dbContext;

        public ContractRepository(TimesheetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Contract contract)
        {
            await _dbContext.Contracts.AddAsync(contract);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool?> CheckContractIsActive(Guid id)
        {
            var contract = await _dbContext.Contracts.FindAsync(id);
            var now = DateTime.Now;
            var isActive = now >= contract?.DateStart && now <= contract?.DateEnd;
            return isActive;
        }

        public async Task Delete(Guid id)
        {
            var contract = await GetItem(id);
            contract.IsDeleted = true;
            _dbContext.Contracts.Update(contract);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<Contract> GetItem(Guid id)
        {
            var result = await _dbContext.Contracts.FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<Contract>> GetItems()
        {
            var result = await _dbContext.Contracts.ToListAsync();
            return result;
        }

        public async Task Update(Contract contract)
        {
            _dbContext.Contracts.Update(contract);
            await _dbContext.SaveChangesAsync();
        }
    }
}
