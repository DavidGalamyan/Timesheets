using System;
using Timesheets.Models;
using Timesheets.Models.DTO;

namespace Timesheets.Domain.Interfaces
{
    public interface ISheetManager
    {
        public Sheet GetItem(Guid id);
        public Guid Create(SheetRequest sheet);
    }
}
