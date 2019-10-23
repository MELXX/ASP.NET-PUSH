using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTable.Models.Data.RepositoryInterfaces;

namespace TimeTable.Models.Data
{

    public class RepositoryWrapper:IRepositoryWrapper
    {
        AppDbContext AppDbContext;
        IStudentRepository student;
        IMarksRepository marks;
        IModuleRepository module;
        ILecturerRepository lecturer;
        ILectureRepository lecture;
        IVenueRepository venue;
        IAssessmentRepository assessment;
        ICourseRepository course;

        public RepositoryWrapper(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public IStudentRepository Student
        {
            get
            {
                return student == null ? new EFStudentRepository(AppDbContext): student;
            }
        }

        public IMarksRepository Marks
        {
            get
            {
                return marks == null ? new EFMarkRepository(AppDbContext) : marks;
            }
        }

        public IVenueRepository Venue
        {
            get
            {
                return venue == null ? new EFVenueRepository(AppDbContext) : venue;
            }
        }

        public ILecturerRepository Lecturer
        {
            get
            {
                return lecturer == null ? new EFLecturerRepository(AppDbContext) : lecturer;
            }
        }

        public ILectureRepository Lectures
        {
            get
            {
                return lecture == null ? new EFLectureRepository(AppDbContext) : lecture;
            }
        }

        public IAssessmentRepository Assessment
        {
            get
            {
                return assessment == null ? new EFAssessmentRepository(AppDbContext) : assessment;
            }
        }

        public IModuleRepository Module
        {
            get
            {
                return module == null ? new EFModuleRepository(AppDbContext) : module;
            }
        }

        public ICourseRepository Course
        {
            get
            {
                return course == null ? new EFCourseRepository(AppDbContext) : course;
            }
        }
    }
}
