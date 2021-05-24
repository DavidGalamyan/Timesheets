using System;
using System.Collections.Generic;

namespace Timesheets.Models.Dto
{
    public class EmployeeRequest
    {
        public Guid UserId { get; set; }
        public ICollection<Sheet> Sheets { get; set; }
    }
}
