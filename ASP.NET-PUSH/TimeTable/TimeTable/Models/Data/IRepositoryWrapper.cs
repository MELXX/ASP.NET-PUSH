using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTable.Models.Data.RepositoryInterfaces;

namespace TimeTable.Models.Data
{
    public interface IRepositoryWrapper
    {
        IStudentRepository Student { get; }
        IMarksRepository Marks { get; }
        IVenueRepository Venue { get; }
        ILecturerRepository Lecturer { get; }
        IAssessmentRepository Assessment { get; }
        IModuleRepository Module { get; }
        ICourseRepository Course { get; }
        ILectureRepository Lectures { get; }

    }
}
