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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<Employee> AddEmployee(Employee employee)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@FirstName", employee.FirstName);
            parameters.Add("@LastName", employee.LastName);
            parameters.Add("@Phone", employee.Phone);
            parameters.Add("@Address", employee.Address);
            parameters.Add("@DepartmentId", employee.DepartmentId);
            parameters.Add("@IsActive", true);
            parameters.Add("@CreatedUser", 1);
            parameters.Add("@UpdatedUser", 1);
            parameters.Add("@CreatedDate", DateTime.Now);
            parameters.Add("@UpdatedDate", DateTime.Now);

            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();

                var result = await con.QueryAsync<Employee, Department, Employee>(
                    sql: "AddEmployees",
                    map: (e, d) =>
                    {
                        e.Department = d;
                        return e;
                    },
                    param: parameters,
                    splitOn: "DepartmentId",
                    commandType: CommandType.StoredProcedure);

                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Employee>> GetEmployees(int employeeId, string firstName, string lastName, bool? isActive)
        {
            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@EmployeeId", employeeId);
                parameters.Add("@FirstName", firstName);
                parameters.Add("@LastName", lastName);
                parameters.Add("@IsActive", isActive);

                var result  = await con.QueryAsync<Employee, Department, Employee>(
                    "GetEmployees",
                    (e, d) =>
                    {
                        e.Department = d;
                        return e;
                    },
                    param: parameters,
                    splitOn: "DepartmentId",
                    commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeId", employee.EmployeeId);
            parameters.Add("@FirstName", employee.FirstName);
            parameters.Add("@LastName", employee.LastName);
            parameters.Add("@Phone", employee.Phone);
            parameters.Add("@Address", employee.Address);
            parameters.Add("@DepartmentId", employee.DepartmentId);
            parameters.Add("@IsActive", employee.IsActive);
            parameters.Add("@UpdatedUser", 1);
            parameters.Add("@UpdatedDate", DateTime.Now);

            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();

                var result = await con.QueryAsync<Employee, Department, Employee>(
                    sql: "UpdateEmployees",
                    map: (e, d) =>
                    {
                        e.Department = d;
                        return e;
                    },
                    param: parameters,
                    splitOn: "DepartmentId",
                    commandType: CommandType.StoredProcedure);

                return result.FirstOrDefault();
            }
        }
    }
}
