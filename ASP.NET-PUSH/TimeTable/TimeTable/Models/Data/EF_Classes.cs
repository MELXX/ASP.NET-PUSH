using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTable.Models.Data.RepositoryInterfaces;
using TimeTable.Models.Entities;

namespace TimeTable.Models.Data
{
    public class EF_Classes
    {
    }

    public class EFModuleRepository : RepositoryBase<Module>, IModuleRepository
    {
        public EFModuleRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

    public class EFLecturerRepository : RepositoryBase<Lecturer>, ILecturerRepository
    {
        public EFLecturerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

    public class EFLectureRepository : RepositoryBase<Lecture>, ILectureRepository
    {
        public EFLectureRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

    public class EFCourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public EFCourseRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

    public class EFMarkRepository : RepositoryBase<Mark>, IMarksRepository
    {
        public EFMarkRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

    public class EFAssessmentRepository : RepositoryBase<Assessment>, IAssessmentRepository
    {
        public EFAssessmentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

    public class EFStudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public EFStudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }

    public class EFVenueRepository : RepositoryBase<Venue>, IVenueRepository
    {
        public EFVenueRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }



}
