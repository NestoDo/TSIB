using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public interface IReportRepository
    {
        Task<IEnumerable<ReportSummary>> GetReportSummary(int employeeId, DateTime summaryDate);
        Task<IEnumerable<ReportSummaryDetail>> GetReportSummaryDetail(int employeeId, DateTime summaryDate);
        Task<IEnumerable<ReportSummaryGroup>> GetReportSummaryGroup(int employeeId, DateTime summaryDate);
    }
}
