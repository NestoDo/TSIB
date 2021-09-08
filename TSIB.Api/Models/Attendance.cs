using System;
using System.Collections.Generic;

#nullable disable

namespace TSIB.Api.Models
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public int AttendanceTypeId { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public int CreatedUser { get; set; }
        public int UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }        

        public virtual AttendanceType AttendanceType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
