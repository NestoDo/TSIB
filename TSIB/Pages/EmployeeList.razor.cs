using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;
using TSIB.Services;

namespace TSIB.Pages
{
    public partial class EmployeeList
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            string search = string.Empty;

            Employees = (await EmployeeService.GetEmployees(search)).ToList();
        }

        private async void ChangeStatus_Click(Employee employee)
        {
            Employee result = null;
            employee.IsActive = !employee.IsActive;

            if (employee.EmployeeId != 0)
            {
                result = await EmployeeService.UpdateEmployee(employee);
            }
            //NavigationManager.NavigateTo("employeeedit", true);
        }
    }
}
