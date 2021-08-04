using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public interface IReportService
    {
        Task<IEnumerable<ReportSummary>> GetReportSummary(string search);
        Task<IEnumerable<ReportSummaryDetail>> GetReportSummaryDetail(string search);
        Task<IEnumerable<ReportSummaryGroup>> GetReportSummaryGroup(string search);
    }
}
