using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Interfaces
{
    public interface IEmployeeManager : IBaseManager<Employee,EmployeeRequest>
    {
    }
}
