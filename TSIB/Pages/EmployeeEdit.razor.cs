using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;
using TSIB.Services;

namespace TSIB.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }        
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            int.TryParse(EmployeeId, out int employeeId);

            if (employeeId != 0)
            {
                string searchEmployees = $"EmployeeId={EmployeeId}";
                Employee = (await EmployeeService.GetEmployees(searchEmployees)).FirstOrDefault();
            }
            else
            {
                Employee = new Employee
                {
                    DepartmentId = 1,
                    CreatedUser = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedUser = 1,
                    UpdatedDate = DateTime.Now
                };
            }

            string searchDepartments = string.Empty;
            Departments = (await DepartmentService.GetDepartments(searchDepartments)).ToList();
        }

        protected async Task HandleValidSubmit()
        {
            Employee result = null;

            if (Employee.EmployeeId != 0)
            {
                result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }

            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
