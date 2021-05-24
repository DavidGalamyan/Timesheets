using System;

namespace Timesheets.Models.Dto
{
    public class ContractRequest
    {
        public string Title { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }
    }
}
