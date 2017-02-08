using System;
using System.Threading.Tasks;

namespace XabluApp.Core
{
    public class EmployeeCellViewModel : BaseViewModel
    {
        private IEmployeesService employeeService { get; }
        public EmployeeCellViewModel(IEmployeesService employeeService)
        {
            this.employeeService = employeeService;
        }

        public async Task Init(int id)
        {
            Employee = await employeeService.GetEmployee(id);
        }

        private EmployeeModel employee;
        public EmployeeModel Employee
        {
            get { return employee; }
            set { SetProperty(ref employee, value); }
        }
    }
}
