using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;
using TSIB.Services;

namespace TSIB.Pages
{
    public partial class EmployeeDetails
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            string search = $"EmployeeId={EmployeeId}";

            Employee = (await EmployeeService.GetEmployees(search)).FirstOrDefault();
        }
    }
}
