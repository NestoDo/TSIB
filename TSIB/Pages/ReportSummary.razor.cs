using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;
using TSIB.Services;

namespace TSIB.Pages
{
    public partial class ReportSummary
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<TSIB.Api.Models.Employee> Employees { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public int EmployeeId { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            string search = search = $"IsActive=true";
            Employees = (await EmployeeService.GetEmployees(search)).ToList();

        }
    }
}
