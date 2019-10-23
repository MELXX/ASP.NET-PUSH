using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTable.Models.Entities
{
    public class Lecturer
    {
        public int LecturerID { get; set; }

        //[DisplayName("Last Name")]
        //[Required(ErrorMessage = "Enter a last name")]
        public string LastName { get; set; }

        //[DisplayName("First Name")]
        //[Required(ErrorMessage = "Enter a first name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Enter initials")]
        //public string Initials { get; set; }

        public string CourseID { get; set; }
    }
}
