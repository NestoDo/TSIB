using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public interface IAttendanceRepository
    {
        Task<IEnumerable<Employee>> GetAttendance(int employeeId, int year, int month);
        Task<Attendance> UpdateAttendance(Attendance attendance);
        Task<Attendance> UpdateComment(Attendance attendance);
    }
}
