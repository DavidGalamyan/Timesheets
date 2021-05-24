using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Inplementation
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Create(UserRequest request)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Username = request.Username
            };
            await _userRepository.Add(user);
            return user.Id;
        }

        public async Task Delete(Guid id)
        {
            await _userRepository.Delete(id);
        }

        public async Task<User> GetItem(Guid id)
        {
            var result = await _userRepository.GetItem(id);
            return result;
        }

        public async Task<IEnumerable<User>> GetItems()
        {
            var result = await _userRepository.GetItems();
            return result;
        }

        public async Task Update(Guid id, UserRequest request)
        {
            var user = new User()
            {
                Id = id,
                Username = request.Username
            };
            await _userRepository.Update(user);
        }
    }
}
