using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Services
{
    public interface IAttendanceService
    {
        Task<IEnumerable<Attendance>> GetAttendance(string search);
        //Task<Attendance> UpdateAttendance(Attendance employee);
    }
}
