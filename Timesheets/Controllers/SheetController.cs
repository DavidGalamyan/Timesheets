using Microsoft.AspNetCore.Mvc;
using System;
using Timesheets.Domain.Interfaces;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheetController : ControllerBase
    {
        private readonly ISheetManager _sheetManager;
        
        public SheetController(ISheetManager sheetManager)
        {
            _sheetManager = sheetManager;
        }
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            var result = _sheetManager.GetItem(id);
            return Ok(result);
        }
    }
}
