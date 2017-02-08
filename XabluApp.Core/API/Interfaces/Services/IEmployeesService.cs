using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XabluApp.Core
{
    public interface IEmployeesService
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployees();
        Task<EmployeeModel> GetEmployee(int Id);
    }
}
