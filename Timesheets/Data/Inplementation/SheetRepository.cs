using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Inplementation
{
    public class SheetRepository : ISheetRepository
    {
        private static List<Sheet> _SheetList = new List<Sheet>()
        {
           new Sheet(){ Id = Guid.Parse("53166AA6-2D90-63F1-E332-AA2091CCA4E7"),
              Date = DateTime.Parse("2021-08-09"),
              EmployeeId = Guid.Parse("49835278-120B-4AB6-A944-549378699747"),
              ContractId = Guid.Parse("F6C7323B-1738-9902-1B48-FA30C54340B9"),
              ServiceId = Guid.Parse("FF02FC6F-7321-78F0-2196-2C24D0826F77"), Amount = 1 },
           new Sheet(){ Id = Guid.Parse("20F911D8-BD31-7158-2787-F63406A69464"),
              Date = DateTime.Parse("2020-12-04"),
              EmployeeId = Guid.Parse("4F1601FF-3CDD-2533-CCC3-FA9C004AB227"),
              ContractId = Guid.Parse("F0C98582-EB68-BACE-F112-F745945BF575"),
              ServiceId = Guid.Parse("61B31A17-06E9-C636-502C-5698B0145363"), Amount = 2 },
           new Sheet(){ Id = Guid.Parse("128B8625-DAAA-90F3-C5AC-0AC1CDA1F5AD"),
              Date = DateTime.Parse("2022-04-16"),
              EmployeeId = Guid.Parse("18F58A4B-99FD-9A98-1C76-2A93C2D31F21"),
              ContractId = Guid.Parse("B3CC5D73-ECB2-9F00-BBDA-7D35C8A4B78B"),
              ServiceId = Guid.Parse("009926EE-8375-A3EE-DA41-7605F7B01082"),Amount = 3 },
           new Sheet(){ Id = Guid.Parse("19455EF8-488C-4671-D9CD-D4BD9EB37655"),
              Date = DateTime.Parse("2022-04-22"),
              EmployeeId = Guid.Parse("A337C482-DA60-3A3C-120C-3544E8A8AD94"),
              ContractId = Guid.Parse("93032B8E-B9DB-89FF-6EE5-AE2722BB23D1"),
              ServiceId = Guid.Parse("70B9547C-369B-085D-D440-C2A63B36F89A"), Amount = 4 }
        };

        public void Add(Sheet sheet)
        {
            _SheetList.Add(sheet);
        }

        public Sheet GetItem(Guid id)
        {
            var result = _SheetList.FirstOrDefault(sheet => id == sheet.Id);
            return result;
        }
        
        public IEnumerable<Sheet> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
