using System;
using System.Collections.Generic;

#nullable disable

namespace TSIB.Api.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public int CreatedUser { get; set; }
        public int UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
