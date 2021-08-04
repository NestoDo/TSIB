using System;
using System.Collections.Generic;

#nullable disable

namespace TSIB.Api.Models
{
    public partial class ReportSummaryDetail
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AttendanceType { get; set; }
        public DateTime Date { get; set; }
    }
}
