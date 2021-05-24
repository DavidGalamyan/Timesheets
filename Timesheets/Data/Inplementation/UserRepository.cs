using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.EntityFramework;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Inplementation
{
    public class UserRepository : IUserRepository
    {
        private readonly TimesheetDbContext _dbContext;

        public UserRepository(TimesheetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var result = await GetItem(id);
            //_dbContext.Users.Remove(result);
            //await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetItem(Guid id)
        {
            var result = await _dbContext.Users.FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<User>> GetItems()
        {
            var result = await _dbContext.Users.ToListAsync();
            return result;
        }

        public async Task Update(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
