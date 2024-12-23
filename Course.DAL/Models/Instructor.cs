using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public List<int> CoursesTaught { get; set; } = new List<int>();
    }
}
