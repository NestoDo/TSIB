using System;

namespace TSIB.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public int CreatedUser { get; set; }
        public int UpdatedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
	}
}
