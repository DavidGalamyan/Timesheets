using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Timesheets.Domain.Interfaces;
using Timesheets.Models.Dto;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("Sheets")]
    public class SheetsController : ControllerBase
    {
        private readonly ISheetManager _sheetManager;
        private readonly IContractManager _contractManager;
        public SheetsController(ISheetManager sheetManager, IContractManager contractManager)
        {
            _sheetManager = sheetManager;
            _contractManager = contractManager;
        }
        [HttpGet("{id}")]
        public IActionResult Get([FromQuery] Guid id)
        {
            var result = _sheetManager.GetItem(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SheetRequest sheetRequest)
        {
            var isAllowedToCreate = await _contractManager.CheckContractIsActive(sheetRequest.ContractId);
            if (isAllowedToCreate != null && !(bool)isAllowedToCreate)
            {
                return BadRequest($"Contract {sheetRequest.ContractId} is not active or not found.");
            }
            else
            {
                var id = await _sheetManager.Create(sheetRequest);
                return Ok(id);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id,SheetRequest sheetRequest)
        {
            var isAllowedToCreate = await _contractManager.CheckContractIsActive(sheetRequest.ContractId);
            if (isAllowedToCreate != null && !(bool)isAllowedToCreate)
            {
                return BadRequest($"Contract {sheetRequest.ContractId} is not active or not found.");
            }
            else
            {
                await _sheetManager.Update(id, sheetRequest);
                return Ok();
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var result = await _sheetManager.GetItems();
            return Ok(result);
        }

    }
}
