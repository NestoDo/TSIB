using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments(string search);
    }
}
