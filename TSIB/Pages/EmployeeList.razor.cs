using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Model;

namespace TSIB.Pages
{
    public partial class EmployeeList
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "FirstName",
                LastName = "LastName",
                Phone = "343423",
                Address = "Address",
                DepartmentId = 1,
                IsActive = true,
                CreatedUser = 1,
                UpdatedUser = 1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            Employee e2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "FirstName",
                LastName = "LastName",
                Phone = "343423",
                Address = "Address",
                DepartmentId = 1,
                IsActive = true,
                CreatedUser = 1,
                UpdatedUser = 1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            Employees = new List<Employee> { e1, e2 };
        }
    }
}
