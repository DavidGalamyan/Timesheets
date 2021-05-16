using System;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Models;

namespace Timesheets.Domain.Inplementation
{
    public class SheetManager : ISheetManager
    {
        private readonly ISheetRepository _sheetRepository;
        
        public SheetManager(ISheetRepository sheetRepository)
        {
            _sheetRepository = sheetRepository;
        }
        public Sheet GetItem(Guid id)
        {
            return _sheetRepository.GetItem(id);
        }
    }
}
