using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTable.Models.Entities
{
    public class ModuleAssessment
    {
        public  int ModuleAssessmentID { get; set; }
        public int AssessmentID { get; set; }

        public int ModuleID { get; set; }
    }
}
