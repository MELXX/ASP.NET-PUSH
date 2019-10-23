using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTable.Models.Entities
{
    public enum AssessmentType
    {
        Exam, SemesterTest, Assignment, OnlineQuiz
    }

    public class Assessment
    {
        //public Assessment(int assessmentID, string assessmentName, string description, AssessmentType assessmentType, int moduleID, double weight, double mark, DateTime startTime, DateTime endTime, string duration)
        //{
        //    AssessmentID = assessmentID;
        //    AssessmentName = assessmentName;
        //    Description = description;
        //    AssessmentType = assessmentType;
        //    ModuleID = moduleID;
        //    Weight = weight;
        //    Mark = mark;
        //    StartTime = startTime;
        //    EndTime = endTime;
        //    Duration = duration;
        //}

        public int AssessmentID { get; set; }

        public string AssessmentName { get; set; } 

        public string Description { get; set; }

        //[DisplayFormat(NullDisplayText = "No grade")]
        public AssessmentType AssessmentType { get; set; }

        public int ModuleID { get; set; }

        public double? PredicateWeight { get; set; }

        public double? FinalWeight { get; set; }

        public double Mark { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Duration { get; set; }
    }
}
