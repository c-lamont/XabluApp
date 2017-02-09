using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using XabluApp.Core.Helpers;

namespace XabluApp.Core
{
    public class EmployeesViewModel : BaseViewModel
    {
        private IEmployeesService employeeService;
        public EmployeesViewModel(IEmployeesService employeeService)
        {
            this.employeeService = employeeService;
            Title = "Employees";
        }

        public async Task Init()
        {
            var employees = await employeeService.GetAllEmployees();
            List<ListItemModel> empListItems = new List<ListItemModel>();
            foreach (var item in employees)
            {
                var employeeCellVM = new EmployeeCellViewModel(employeeService);
                await employeeCellVM.Init(item.Id);
                empListItems.Add(new ListItemModel(employeeCellVM));
            }

            Employees.ReplaceWith(empListItems);
        }

        public OptimizedObservableCollection<ListItemModel> Employees { get; set; } = new OptimizedObservableCollection<ListItemModel>();

        public MvxCommand SelectEmployeeCommand; // => new MvxCommand(() => ShowViewModel<EmployeeDetailViewModel>() );
    }
}
