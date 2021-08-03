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
        public int EstanciaAcumulado { get; set; }
        public int DescansosDisponible { get; set; }
        public int DescansosUtilizados { get; set; }
        public int DiasQueSeDeben { get; set; }
    }
}
