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
        [Inject]
        public IReportService ReportService { get; set; }


        public IEnumerable<TSIB.Api.Models.Employee> Employees { get; set; }
        public IEnumerable<TSIB.Api.Models.ReportSummary> ReportSummaryList { get; set; }


        public DateTime Date { get; set; } = DateTime.Now;

        public int EmployeeId { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            string search = search = $"IsActive=true";
            Employees = (await EmployeeService.GetEmployees(search)).ToList();

            await this.ReportSummarySearch_Click();
        }

        private async Task ReportSummarySearch_Click()
        {
            string search = search = $"employeeId={EmployeeId}&summaryDate={Date}";
            ReportSummaryList = (await ReportService.GetReportSummary(search)).ToList();
        }
    }
}
