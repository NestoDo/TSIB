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
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly AppDbContext _appDbContext;
        public AttendanceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Attendance>> GetAttendance(int employeeId, int year, int month)
        {
            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@EmployeeId", employeeId);
                parameters.Add("@Year", year);
                parameters.Add("@Month", month);

                var result  = await con.QueryAsync<Attendance, AttendanceType, Attendance>(
                    "GetAttendance",
                    (e, d) =>
                    {
                        e.AttendanceType = d;
                        return e;
                    },
                    param: parameters,
                    splitOn: "AttendanceTypeId",
                    commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        //public async Task<Employee> UpdateEmployee(Employee employee)
        //{

        //    var parameters = new DynamicParameters();
        //    parameters.Add("@EmployeeId", employee.EmployeeId);
        //    parameters.Add("@FirstName", employee.FirstName);
        //    parameters.Add("@LastName", employee.LastName);
        //    parameters.Add("@Phone", employee.Phone);
        //    parameters.Add("@Address", employee.Address);
        //    parameters.Add("@DepartmentId", employee.DepartmentId);
        //    parameters.Add("@IsActive", employee.IsActive);
        //    parameters.Add("@UpdatedUser", 1);
        //    parameters.Add("@UpdatedDate", DateTime.Now);

        //    using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
        //    {
        //        con.Open();

        //        var result = await con.QueryAsync<Employee, Department, Employee>(
        //            sql: "UpdateEmployees",
        //            map: (e, d) =>
        //            {
        //                e.Department = d;
        //                return e;
        //            },
        //            param: parameters,
        //            splitOn: "DepartmentId",
        //            commandType: CommandType.StoredProcedure);

        //        return result.FirstOrDefault();
        //    }
        //}
    }
}
