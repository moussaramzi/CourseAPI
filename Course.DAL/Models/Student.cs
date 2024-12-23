using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<int> EnrolledCourses { get; set; } = new List<int>();
    }
}
