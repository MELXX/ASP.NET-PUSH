using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTable.Models.Entities
{
    public enum MarkType
    {
        PredicateMark, AssessmentMark, GoalMark, PredictedMark
    }

    public class Mark
    {
        public int MarkID { get; set; }

        public MarkType? MarkType { get; set; }

        public double MarkValue { get; set; }

        public int AssessmentID { get; set; }

        public int StudentID { get; set; }
    }
}
