﻿//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TSIB.Api.Models;

//namespace TSIB.Api.Repositories
//{
//    public class DepartmentRepository : IDepartamentRepository
//    {
//        private readonly AppDbContext _appDbContext;
//        public DepartmentRepository(AppDbContext appDbContext)
//        {
//            _appDbContext = appDbContext;
//        }

//        public async Task<Department> GetDepartment(int departmentId)
//        {
//            return await _appDbContext.Departments.FirstOrDefaultAsync(e => e.DepartmentId == departmentId);
//        }

//        public async Task<IEnumerable<Department>> GetDepartments()
//        {
//            return await _appDbContext.Departments.ToListAsync();
//        }
//    }
//}
