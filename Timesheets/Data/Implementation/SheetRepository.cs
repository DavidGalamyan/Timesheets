using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.EntityFramework;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class SheetRepository : ISheetRepository
    {
        private readonly TimesheetDbContext _dbContext;
        public SheetRepository(TimesheetDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Sheet sheet)
        {
            await _dbContext.Sheets.AddAsync(sheet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var sheet = await GetItem(id);
            _dbContext.Sheets.Remove(sheet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Sheet> GetItem(Guid id)
        {
            var result = await _dbContext.Sheets.FindAsync(id);
            return result;
        }
        
        public async Task<IEnumerable<Sheet>> GetItems()
        {
            var result = await _dbContext.Sheets.ToListAsync();
            return result;
        }

        public async Task Update(Sheet sheet)
        {
            _dbContext.Update(sheet);
            await _dbContext.SaveChangesAsync();
        }
    }
}
