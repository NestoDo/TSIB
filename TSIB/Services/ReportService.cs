using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public class ReportService : IReportService
    {
        private readonly HttpClient httpClient;

        public ReportService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ReportSummary>> GetReportSummary(string search)
        {

            return await httpClient.GetJsonAsync<ReportSummary[]>($"api/report/reportsummary?{search}");
        }

        public async Task<IEnumerable<ReportSummaryDetail>> GetReportSummaryDetail(string search)
        {

            return await httpClient.GetJsonAsync<ReportSummaryDetail[]>($"api/report/reportsummarydetail?{search}");
        }
    }
}
