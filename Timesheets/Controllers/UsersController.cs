using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Timesheets.Domain.Interfaces;
using Timesheets.Models.Dto;

namespace Timesheets.Controllers
{
    [Route("Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _userManager.GetItem(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRequest request)
        {
            var id = await _userManager.Create(request);
            return Ok(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UserRequest request)
        {
            await _userManager.Update(id, request);
            return Ok();
        }
        [HttpGet]        
        public async Task<IActionResult> GetAll()
        {
            var result = await _userManager.GetItems();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            await _userManager.Delete(id);
            return Ok();
        }
    }
}
