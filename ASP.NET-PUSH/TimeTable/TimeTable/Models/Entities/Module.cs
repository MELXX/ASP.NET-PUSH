using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTable.Models.Entities
{
    public class Module
    {
        public int ModuleID { get; set; }

        public string ModuleName { get; set; }

        public string ModuleDescription { get; set; }

        public int CourseID { get; set; }

        public ICollection<Assessment> Assessments { get; set; }
    }
}
