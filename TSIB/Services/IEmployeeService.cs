using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees(string search);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> CreateEmployee(Employee employee);
    }
}
