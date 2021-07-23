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

        [Parameter]
        public string EmployeeId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            string searchEmployees = $"EmployeeId={EmployeeId}";
            string searchDepartments = string.Empty;

            Employee = (await EmployeeService.GetEmployees(searchEmployees)).FirstOrDefault();
            Departments = (await DepartmentService.GetDepartments(searchDepartments)).ToList();
        }

        protected void HandleValidSubmit()
        {
            EmployeeService.UpdateEmployee(Employee);
        }
    }
}
