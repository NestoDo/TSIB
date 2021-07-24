using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public class AttendanceTypeRepository : IAttendanceTypeRepository
    {
        private readonly AppDbContext _appDbContext;
        public AttendanceTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<AttendanceType>> GetAttendanceType(int attendanceTypeId)
        {
            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@AttendanceTypeId", attendanceTypeId);

                con.Open();
                var result = await con.QueryAsync<AttendanceType>(
                    "GetAttendanceType",
                    param: parameters,
                    commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }
    }
}
