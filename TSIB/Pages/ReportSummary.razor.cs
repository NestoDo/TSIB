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
        public IEnumerable<TSIB.Api.Models.ReportSummary> ReportSummaryList { get; set; } = new List<TSIB.Api.Models.ReportSummary>();
        public IEnumerable<TSIB.Api.Models.ReportSummaryDetail> ReportSummaryDetailList { get; set; }
        public IEnumerable<TSIB.Api.Models.ReportSummaryGroup> ReportSummaryGroupList { get; set; }


        public DateTime DateInit { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public DateTime DateEnd { get; set; } = DateTime.Now;

        public int EmployeeId { get; set; } = 0;

        public string EmployeeName { get; set; } = "Nombre Empleado";

        protected override async Task OnInitializedAsync()
        {
            string search = search = $"IsActive=true";
            Employees = (await EmployeeService.GetEmployees(search)).ToList();

            //await this.ReportSummarySearch_Click();
        }

        private async Task ReportSummarySearch_Click()
        {
            string search = search = $"employeeId={EmployeeId}&dateEnd={DateEnd}";
            ReportSummaryList = (await ReportService.GetReportSummary(search)).ToList();
        }

        private async Task SummaryDetailSearch_Click(int employeeId, string employeeName)
        {
            EmployeeName = employeeName;

            string search = search = $"employeeId={employeeId}&dateEnd={DateEnd}";
            ReportSummaryDetailList = (await ReportService.GetReportSummaryDetail(search)).ToList();

            search = search = $"employeeId={employeeId}&dateEnd={DateEnd}";
            ReportSummaryGroupList = (await ReportService.GetReportSummaryGroup(search)).ToList();
        }
    }
}
