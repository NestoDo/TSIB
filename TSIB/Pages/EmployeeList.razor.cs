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
            string search = $"IsActive={SearchIsActive}";

            Employees = (await EmployeeService.GetEmployees(search)).ToList();
        }

        #region  Search
        public string SearchFirstName { get; set; } = string.Empty;
        public string SearchLastName { get; set; } = string.Empty;
        public string SearchIsActive { get; set; } = "true";
        #endregion

        private async void ChangeStatus_Click(Employee employee)
        {
            Employee result = null;
            employee.IsActive = !employee.IsActive;

            if (employee.EmployeeId != 0)
            {
                result = await EmployeeService.UpdateEmployee(employee);
            }
        }

        private  async Task EmployeeSearch_Click()
        {
            string search = "default=default";

            if (SearchIsActive != "todo")
            {
                search += $"&IsActive={SearchIsActive}";
            }

            if (!string.IsNullOrEmpty(SearchFirstName))
            {
                search += $"&FirstName={SearchFirstName}";
            }

            if (!string.IsNullOrEmpty(SearchLastName))
            {
                search += $"&LastName={SearchLastName}";
            }


            Employees = (await EmployeeService.GetEmployees(search)).ToList();

        }
    }
}
