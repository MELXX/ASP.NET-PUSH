using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTable.Models.Entities
{
    public class Lecture
    {
        public int ModuleID { get; set; }
        public int VenueID { get; set; }
        public int LectureID { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }
}
