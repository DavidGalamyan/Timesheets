using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Timesheets.Domain.Interfaces;
using Timesheets.Models.Dto;

namespace Timesheets.Controllers
{
    [Route("Contracts")]
    [ApiController]
    public class ContractsController : ControllerBase
    {

        private readonly IContractManager _contractManager;
        public ContractsController(IContractManager contractManager)
        {
            _contractManager = contractManager;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _contractManager.GetItem(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ContractRequest request)
        {
            var id = await _contractManager.Create(request);
            return Ok(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, ContractRequest request)
        {
            await _contractManager.Update(id, request);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _contractManager.GetItems();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            await _contractManager.Delete(id);
            return Ok();
        }
    }
}
