using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Timesheets.Domain.Interfaces;
using Timesheets.Models.Dto;

namespace Timesheets.Controllers
{
    [Route("Employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager;
        public EmployeesController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _employeeManager.GetItem(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EmployeeRequest request)
        {
            var id = await _employeeManager.Create(request);
            return Ok(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, EmployeeRequest request)
        {
            await _employeeManager.Update(id, request);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employeeManager.GetItems();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            await _employeeManager.Delete(id);
            return Ok();
        }
    }
}
