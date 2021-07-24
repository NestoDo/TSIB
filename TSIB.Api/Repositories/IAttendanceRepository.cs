using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public interface IAttendanceRepository
    {
        Task<IEnumerable<Attendance>> GetAttendance(int employeeId, int year, int month);
        //Task<Attendance> UpdateAttendance(Attendance attendance);
    }
}
