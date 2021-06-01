using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Implementation
{
    public class SheetManager : ISheetManager
    {
        private readonly ISheetRepository _sheetRepository;
        
        public SheetManager(ISheetRepository sheetRepository)
        {
            _sheetRepository = sheetRepository;
        }

        public async Task<Guid> Create(SheetRequest sheetRequest)
        {
            var sheet = new Sheet()
            {
                Id = Guid.NewGuid(),
                Amount = sheetRequest.Amount,
                Date = sheetRequest.Date,
                ContractId = sheetRequest.ContractId,
                EmployeeId = sheetRequest.EmployeeId,
                ServiceId = sheetRequest.ServiceId                
            };
            await _sheetRepository.Add(sheet);
            var result = sheet.Id;
            return result;
                
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Sheet> GetItem(Guid id)
        {
            var result = await _sheetRepository.GetItem(id);
            return result;
        }

        public async Task<IEnumerable<Sheet>> GetItems()
        {
            var result = await _sheetRepository.GetItems();
            return result;
        }

        public async Task Update(Guid id, SheetRequest sheetRequest)
        {
            var sheet = new Sheet()
            {
                Id = id,
                Amount = sheetRequest.Amount,
                Date = sheetRequest.Date,
                ContractId = sheetRequest.ContractId,
                EmployeeId = sheetRequest.EmployeeId,
                ServiceId = sheetRequest.ServiceId
            };
            await _sheetRepository.Update(sheet);            
        }
    }
}
