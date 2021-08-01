using System;
using System.Collections.Generic;

#nullable disable

namespace TSIB.Api.Models
{
    public partial class ReportSummary
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int E { get; set; }
        public int D { get; set; }
    }
}
