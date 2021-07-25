using System;
using System.Collections.Generic;

#nullable disable

namespace TSIB.Api.Models
{
    public partial class AttendanceType
    {
        public AttendanceType()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int AttendanceTypeId { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int Order { get; set; }
        public int CreatedUser { get; set; }
        public int UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
