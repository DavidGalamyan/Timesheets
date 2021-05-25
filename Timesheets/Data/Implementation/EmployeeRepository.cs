using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.EntityFramework;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TimesheetDbContext _dbContext;

        public EmployeeRepository(TimesheetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var employee = await GetItem(id);
            employee.IsDeleted = true;
            _dbContext.Employees.Update(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Employee> GetItem(Guid id)
        {
            var result = await _dbContext.Employees.FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<Employee>> GetItems()
        {
            var result = await _dbContext.Employees.ToListAsync();
            return result;
        }

        public async Task Update(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            await _dbContext.SaveChangesAsync();
        }
    }
}
