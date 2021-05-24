using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Inplementation
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Guid> Create(EmployeeRequest request)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId                
            };
            await _employeeRepository.Add(employee);
            return employee.Id;
        }

        public async Task Delete(Guid id)
        {
            await _employeeRepository.Delete(id);
        }

        public async Task<Employee> GetItem(Guid id)
        {
            var result = await _employeeRepository.GetItem(id);
            return result;
        }

        public async Task<IEnumerable<Employee>> GetItems()
        {
            var result = await _employeeRepository.GetItems();
            return result;
        }

        public async Task Update(Guid id, EmployeeRequest request)
        {
            var employee = new Employee()
            {
                Id = id,
                UserId = request.UserId,
                Sheets = request.Sheets
            };
            await _employeeRepository.Update(employee);
        }
    }
}
