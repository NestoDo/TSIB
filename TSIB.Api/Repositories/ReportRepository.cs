using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Misc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly AppDbContext _appDbContext;
        public ReportRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<ReportSummary>> GetReportSummary(int employeeId, DateTime summaryDate)
        {
            var lookup = new Dictionary<int, Employee>();

            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@EmployeeId", employeeId);
                parameters.Add("@SummaryDate", summaryDate.Default());

                var result  = await con.QueryAsync<ReportSummary>(
                    "ReportSummary",
                    param: parameters,
                    commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<IEnumerable<ReportSummaryDetail>> GetReportSummaryDetail(int employeeId, DateTime summaryDate)
        {
            var lookup = new Dictionary<int, Employee>();

            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@EmployeeId", employeeId);
                parameters.Add("@SummaryDate", summaryDate.Default());

                var result = await con.QueryAsync<ReportSummaryDetail>(
                    "ReportSummaryDetail",
                    param: parameters,
                    commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<IEnumerable<ReportSummaryGroup>> GetReportSummaryGroup(int employeeId, DateTime summaryDate)
        {
            var lookup = new Dictionary<int, Employee>();

            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@EmployeeId", employeeId);
                parameters.Add("@SummaryDate", summaryDate.Default());

                var result = await con.QueryAsync<ReportSummaryGroup>(
                    "ReportSummaryGroup",
                    param: parameters,
                    commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }
    }
}
