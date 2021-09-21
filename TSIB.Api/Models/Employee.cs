using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TSIB.Api.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Nombre es requerido")]
        [MinLength(1)]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Apellido es requerido")]
        [MinLength(1)]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public int CreatedUser { get; set; }
        public int UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
