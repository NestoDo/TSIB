using System;

namespace TSIB.Model
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public int AttendanceTypeId { get; set; }
        public int Date { get; set; }
        public int IsReconcile { get; set; }
        public int ReconcileDate { get; set; }
        public int CreatedUser { get; set; }
        public int UpdatedUser { get; set; }
        public int CreatedDate { get; set; }
        public int UpdatedDate { get; set; }
	}
}
