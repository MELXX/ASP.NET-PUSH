using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTable.Models.Entities
{
    public class Course
    {
        //public Lecturer LecturerID { get; set; }
        public int CourseID { get; set; }

        public string Title { get; set; }

        public ICollection<Module> Modules { get; set; } 
    }
}
