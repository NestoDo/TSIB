using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public interface IAttendanceService
    {
        Task<IEnumerable<Employee>> GetAttendance(string search);
        Task<Attendance> UpdateAttendance(Attendance attendance);
        Task<Attendance> UpdateComment(Attendance attendance);
    }
}
