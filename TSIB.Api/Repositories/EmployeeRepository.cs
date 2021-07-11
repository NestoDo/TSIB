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
            //var result = await _appDbContext.Employees.AddAsync(employee);
            //await _appDbContext.SaveChangesAsync();
            //return result.Entity;

            var parameters = new DynamicParameters();
            parameters.Add("@FirstName", employee.FirstName);
            parameters.Add("@LastName", employee.LastName);
            parameters.Add("@Phone", employee.Phone);
            parameters.Add("@Address", employee.Address);
            parameters.Add("@DepartmentId", employee.DepartmentId);
            parameters.Add("@IsActive", true);
            parameters.Add("@CreatedUser", 1);
            parameters.Add("@UpdatedUser", 1);
            parameters.Add("@UpdatedDate", DateTime.Now);
            parameters.Add("@CreatedDate", DateTime.Now);

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


        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            using (SqlConnection con = new SqlConnection(_appDbContext.Database.GetDbConnection().ConnectionString))
            {
                con.Open();

                var result  = await con.QueryAsync<Employee, Department, Employee>(
                    "GetEmployees",
                    (e, d) =>
                    {
                        e.Department = d;
                        return e;
                    },
                    splitOn: "DepartmentId",
                    commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

            if (result != null)
            {
                result.EmployeeId = employee.EmployeeId;
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Phone = employee.Phone;
                result.Address = employee.Address;
                result.DepartmentId = employee.DepartmentId;
                result.IsActive = employee.IsActive;
                result.UpdatedUser = employee.UpdatedUser;
                result.UpdatedDate = DateTime.Now;

                await _appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async void DeleteEmployee(int employeeId)
        {
            var result = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);

            if (result != null)
            {
                _appDbContext.Employees.Remove(result);
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}
