using System;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Models;
using Timesheets.Models.DTO;

namespace Timesheets.Domain.Inplementation
{
    public class SheetManager : ISheetManager
    {
        private readonly ISheetRepository _sheetRepository;
        
        public SheetManager(ISheetRepository sheetRepository)
        {
            _sheetRepository = sheetRepository;
        }

        public Guid Create(SheetRequest sheetRequest)
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
            _sheetRepository.Add(sheet);
            return sheet.Id;
                
        }

        public Sheet GetItem(Guid id)
        {
            return _sheetRepository.GetItem(id);
        }
    }
}
