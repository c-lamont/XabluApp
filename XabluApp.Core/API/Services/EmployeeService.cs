using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XabluApp.Core
{
    public class EmployeeService : IEmployeesService
    {
        private IEmployeeClient employeeClient;
        public EmployeeService(IEmployeeClient employeeClient)
        {
            this.employeeClient = employeeClient;
        }

        public async Task<IEnumerable<EmployeeModel>> GetAllEmployees()
        {
            return await this.employeeClient.GetAllEmployees();
        }

        public async Task<EmployeeModel> GetEmployee(int Id)
        {
            return await this.employeeClient.GetEmployee(Id);
        }
    }
}
