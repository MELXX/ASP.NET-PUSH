using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTable.Models.Entities;

namespace TimeTable.Models.Data
{
    namespace RepositoryInterfaces
    {
       public interface IAssessmentRepository:IRepositoryBase<Assessment>
        {
        }

        public interface IStudentRepository: IRepositoryBase<Student>
        {
        }

        public interface IMarksRepository: IRepositoryBase<Mark>
        {
        }

        public interface ICourseRepository: IRepositoryBase<Course>
        {
        }

        public interface ILecturerRepository: IRepositoryBase<Lecturer>
        {
        }

        public interface IVenueRepository: IRepositoryBase<Venue>
        {
        }

        public interface IModuleRepository : IRepositoryBase<Module>
        {
        }

        public interface ILectureRepository : IRepositoryBase<Lecture>
        {
        }
    }
}
