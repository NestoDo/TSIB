using System;
using System.Collections.Generic;
using System.Text;

namespace TSIB.Model
{
    public class AttendanceType
    {
		public int AttendanceTypeId { get; set; }
		public string Description { get; set; }
		public int CreatedUser { get; set; }
		public int UpdatedUser { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
