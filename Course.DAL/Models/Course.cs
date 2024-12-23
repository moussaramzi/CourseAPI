using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int InstructorID { get; set; }
        public string Schedule { get; set; }
        public int Capacity { get; set; }
        public int RegisteredStudents { get; set; }
    }
}
