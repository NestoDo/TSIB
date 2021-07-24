using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSIB.Api.Models;

namespace TSIB.Api.Repositories
{
    public interface IAttendanceTypeRepository
    {
        Task<IEnumerable<AttendanceType>> GetAttendanceType(int attendanceTypeId);
    }
}
