using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTable.Models.Entities;

namespace TimeTable.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }//

        public DbSet<Mark> Marks { get; set; }

        public DbSet<Assessment> Assessments { get; set; }

        public DbSet<ModuleAssessment> ModuleAssessments { get; set; }

        public DbSet<Lecturer> Lecturers { get; set; }//

        public DbSet<Lecture> Lecture { get; set; }

    public DbSet<Venue> Venues { get; set; }//

        public DbSet<Student> Students { get; set; }//

        public DbSet<Module> Module { get; set; }//

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venue>().HasData(
                new Venue { VenueID = 301, VenueName = "FGG", VenueRoom = "255" },
                new Venue { VenueID = 302, VenueName = "FGG", VenueRoom = "378" },
                new Venue { VenueID = 303, VenueName = "HMS", VenueRoom = "--" },
                new Venue { VenueID = 304, VenueName = "LANDBOU", VenueRoom = "5" },
                new Venue { VenueID = 305, VenueName = "EBW", VenueRoom = "7" }
                );
            modelBuilder.Entity<Student>().HasData(
            new Student { StudentID = 2017876764, LastName = "Carson", FirstName = "Alexander", CourseID = "201" }, //this one has marks
            new Student { StudentID = 2016875761, LastName = "Alonso", FirstName = "Meredith", CourseID = "201" }, // this one has marks
            new Student { StudentID = 2018867690, LastName = "Anand", FirstName = "Nino", CourseID = "201" },
            new Student { StudentID = 2016039762, LastName = "Gytis", FirstName = "Norman", CourseID = "201" },
            new Student { StudentID = 2017106766, LastName = "Magwenya", FirstName = "Meluthi", CourseID = "201" },
            new Student { StudentID = 2017106778, LastName = "Schmidt", FirstName = "Michael", CourseID = "201" }
                );
            modelBuilder.Entity<Lecturer>().HasData(
                new Lecturer {FirstName = "Rouxanne", LastName= "Fouche", LecturerID = 123456789 }, 
                new Lecturer { FirstName = "Pieter", LastName = "Bligies", LecturerID =135792468 },
                new Lecturer { FirstName = "Jaco", LastName = "Marais", LecturerID =987654321 },
                new Lecturer { FirstName = "Lizette", LastName = "de Wet", LecturerID =148269367 },
                new Lecturer { FirstName = "Ruan", LastName = "van der Westuizen", LecturerID =185473538},
                new Lecturer { FirstName = "Franco", LastName = "van der Merwe", LecturerID =987679543},
                new Lecturer { FirstName = "Khanya", LastName = "Kolo" ,LecturerID = 776546879}
                );
            modelBuilder.Entity<Course>().HasData(
            new Course { CourseID = 201, Title = "BSc. IT"},
            new Course { CourseID = 202, Title = "BIS"}
                );
            modelBuilder.Entity<Module>().HasData(
                new Module { ModuleID = 401 , ModuleName = "CSIS3744", ModuleDescription = "Networking", CourseID =  201},
                new Module { ModuleID = 402, ModuleName = "CSIS3724", ModuleDescription = "Introduction to Software Engineering", CourseID = 201 },
                new Module { ModuleID = 403, ModuleName = "CSIS3714", ModuleDescription = "Internet Programming", CourseID = 201 },
                new Module { ModuleID = 404, ModuleName = "CSIS3734", ModuleDescription = "Introduction to Databases", CourseID = 201 }
                );
            modelBuilder.Entity<Assessment>().HasData(
                new Assessment { AssessmentID = 500, AssessmentName = "Semester Test 1", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 403, PredicateWeight = 30.00, Mark = 50.00, StartTime = DateTime.Parse("12/08/2019 13:00"), EndTime = DateTime.Parse("12/08/2019 14:00"), Duration = "1Hr", FinalWeight = null },

                new Assessment { AssessmentID = 501, AssessmentName = "Semester Test 2", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 403, PredicateWeight = 30.00, Mark = 50.00, StartTime = DateTime.Parse("14/10/2019 13:00"), EndTime = DateTime.Parse("12/10/2019 14:00"), Duration = "1Hr", FinalWeight = null },

                new Assessment { AssessmentID = 502, AssessmentName = "Main Exam 1", Description = " ", AssessmentType = AssessmentType.Exam, ModuleID = 403, FinalWeight = 50.00, Mark = 100.00, StartTime = DateTime.Parse("08/11/2019 09:00"), EndTime = DateTime.Parse("08/11/2019 12:00"), Duration = "3hrs", PredicateWeight = null },

                new Assessment { AssessmentID = 503, AssessmentName = "Assignment 1", Description = " ", AssessmentType = AssessmentType.Assignment, ModuleID = 403, PredicateWeight = 20.00, Mark = 100.00, StartTime = DateTime.Parse("15/09/2019 08:00"), EndTime = DateTime.Parse("15/10/2019 23:59"), Duration = "1 month", FinalWeight = null },

                new Assessment { AssessmentID = 504, AssessmentName = "Online Quiz 1", Description = " ", AssessmentType = AssessmentType.OnlineQuiz, ModuleID = 403, PredicateWeight = 10.00, Mark = 30.00, StartTime = DateTime.Parse("10/10/2019 17:00"), EndTime = DateTime.Parse("15/10/2019 23:59"), Duration = "5 days", FinalWeight = null },

                new Assessment { AssessmentID = 505, AssessmentName = "Assignment 2", Description = " ", AssessmentType = AssessmentType.Assignment, ModuleID = 403, PredicateWeight = 10.00, Mark = 30.00, StartTime = DateTime.Parse("10/10/2019 17:00"), EndTime = DateTime.Parse("15/10/2019 23:59"), Duration = "5 days", FinalWeight = null },

                //other module

                new Assessment { AssessmentID = 506, AssessmentName = "Semester Test 1", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 401, PredicateWeight = 30.00, Mark = 60.00, StartTime = DateTime.Parse("25/09/2019 13:00"), EndTime = DateTime.Parse("25/09/2019 14:00"), Duration = "1hr", FinalWeight = null },

                new Assessment { AssessmentID = 507, AssessmentName = "Main Exam 1", Description = " ", AssessmentType = AssessmentType.Exam, ModuleID = 401, FinalWeight = 50.00, Mark = 100.00, StartTime = DateTime.Parse("15/11/2019 09:00"), EndTime = DateTime.Parse("15/11/2019 12:00"), Duration = "3hrs", PredicateWeight = null },

                new Assessment { AssessmentID = 508, AssessmentName = "Assignment 1", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 401, PredicateWeight = 20.00, Mark = 20.00, StartTime = DateTime.Parse("10/09/2019 13:00"), EndTime = DateTime.Parse("17/09/2019 14:00"), Duration = "7 Days", FinalWeight = null },

                new Assessment { AssessmentID = 509, AssessmentName = "Semester Test 2", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 401, PredicateWeight = 30.00, Mark = 60.00, StartTime = DateTime.Parse("02/11/2019 13:00"), EndTime = DateTime.Parse("02/11/2019 14:00"), Duration = "1hr", FinalWeight = null },

                new Assessment { AssessmentID = 510, AssessmentName = "Assignment 2", Description = " ", AssessmentType = AssessmentType.Assignment, ModuleID = 401, PredicateWeight = 20.00, Mark = 100.00, StartTime = DateTime.Parse("11/10/2019 13:00"), EndTime = DateTime.Parse("23/10/2019 14:00"), Duration = "13 Days", FinalWeight = null },

                //other module 

                new Assessment { AssessmentID = 511, AssessmentName = "Semester Test 1", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 402, PredicateWeight = 35.00, Mark = 50.00, StartTime = DateTime.Parse("20/09/2019 10:00"), EndTime = DateTime.Parse("20/09/2019 11:00"), Duration = "1hr", FinalWeight = null },

                new Assessment { AssessmentID = 512, AssessmentName = "Main Exam 1", Description = " ", AssessmentType = AssessmentType.Exam, ModuleID = 402, FinalWeight = 50.00, Mark = 100.00, StartTime = DateTime.Parse("18/11/2019 10:00"), EndTime = DateTime.Parse("18/11/2019 13:00"), Duration = "3hrs", PredicateWeight = null },

                new Assessment { AssessmentID = 513, AssessmentName = "Assignment 1", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 402, PredicateWeight = 45.00, Mark = 52.00, StartTime = DateTime.Parse("06/09/2019 10:00"), EndTime = DateTime.Parse("13/09/2019 17:00"), Duration = "7 Days", FinalWeight = null },

                new Assessment { AssessmentID = 514, AssessmentName = "Semester Test 2", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 402, PredicateWeight = 50.00, Mark = 42.00, StartTime = DateTime.Parse("15/11/2019 13:00"), EndTime = DateTime.Parse("15/11/2019 14:00"), Duration = "1hr", FinalWeight = null },

                new Assessment { AssessmentID = 515, AssessmentName = "Assignment 2", Description = " ", AssessmentType = AssessmentType.Assignment, ModuleID = 402, PredicateWeight = 55.00, Mark = 70.00, StartTime = DateTime.Parse("01/10/2019 13:00"), EndTime = DateTime.Parse("23/10/2019 14:00"), Duration = "23 Days", FinalWeight = null },

                //other module

                new Assessment { AssessmentID = 516, AssessmentName = "Semester Test 1", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 404, PredicateWeight = 30.00, Mark = 50.00, StartTime = DateTime.Parse("11/08/2019 15:00"), EndTime = DateTime.Parse("11/08/2019 16:00"), Duration = "1Hr", FinalWeight = null },

                new Assessment { AssessmentID = 517, AssessmentName = "Semester Test 2", Description = " ", AssessmentType = AssessmentType.SemesterTest, ModuleID = 404, PredicateWeight = 30.00, Mark = 60.00, StartTime = DateTime.Parse("16/10/2019 16:00"), EndTime = DateTime.Parse("16/10/2019 17:00"), Duration = "1Hr", FinalWeight = null },

                new Assessment { AssessmentID = 518, AssessmentName = "Main Exam 1", Description = " ", AssessmentType = AssessmentType.Exam, ModuleID = 404, FinalWeight = 60.00, Mark = 100.00, StartTime = DateTime.Parse("23/11/2019 09:00"), EndTime = DateTime.Parse("23/11/2019 12:00"), Duration = "3hrs", PredicateWeight = null },

                new Assessment { AssessmentID = 519, AssessmentName = "Assignment 1", Description = " ", AssessmentType = AssessmentType.Assignment, ModuleID = 404, PredicateWeight = 20.00, Mark = 50.00, StartTime = DateTime.Parse("01/09/2019 08:00"), EndTime = DateTime.Parse("15/10/2019 23:59"), Duration = "15 Days", FinalWeight = null },

                new Assessment { AssessmentID = 520, AssessmentName = "Online Quiz 1", Description = " ", AssessmentType = AssessmentType.OnlineQuiz, ModuleID = 404, PredicateWeight = 10.00, Mark = 40.00, StartTime = DateTime.Parse("17/09/2019 17:00"), EndTime = DateTime.Parse("24/09/2019 23:59"), Duration = "7 days", FinalWeight = null },

                new Assessment { AssessmentID = 521, AssessmentName = "Assignment 2", Description = " ", AssessmentType = AssessmentType.Assignment, ModuleID = 404, PredicateWeight = 10.00, Mark = 100.00, StartTime = DateTime.Parse("10/10/2019 17:00"), EndTime = DateTime.Parse("15/10/2019 23:59"), Duration = "5 days", FinalWeight = null }

                );

            modelBuilder.Entity<Mark>().HasData(
                new Mark{ MarkID = 1, MarkType = MarkType.AssessmentMark, MarkValue = 76.00, AssessmentID = 501, StudentID = 2017876764 },
                new Mark { MarkID = 2, MarkType = MarkType.AssessmentMark, MarkValue = 63.00, AssessmentID = 502, StudentID = 2017876764 },
                new Mark { MarkID = 3, MarkType = MarkType.AssessmentMark, MarkValue = 86.00, AssessmentID = 503, StudentID = 2017876764 },
                new Mark { MarkID = 4, MarkType = MarkType.AssessmentMark, MarkValue = 48.00, AssessmentID = 504, StudentID = 2017876764 },
                new Mark { MarkID = 5, MarkType = MarkType.AssessmentMark, MarkValue = 94.00, AssessmentID = 505, StudentID = 2017876764 },
                new Mark { MarkID = 6, MarkType = MarkType.AssessmentMark, MarkValue = 61.00, AssessmentID = 506, StudentID = 2017876764 },
                new Mark { MarkID = 7, MarkType = MarkType.AssessmentMark, MarkValue = 68.00, AssessmentID = 507, StudentID = 2017876764 },
                new Mark { MarkID = 8, MarkType = MarkType.AssessmentMark, MarkValue = 60.00, AssessmentID = 508, StudentID = 2017876764 },
                new Mark { MarkID = 9, MarkType = MarkType.AssessmentMark, MarkValue = 69.00, AssessmentID = 509, StudentID = 2017876764 },
                new Mark { MarkID = 10, MarkType = MarkType.AssessmentMark, MarkValue = 65.00, AssessmentID = 510, StudentID = 2017876764 },
                new Mark { MarkID = 11, MarkType = MarkType.AssessmentMark, MarkValue = 64.00, AssessmentID = 511, StudentID = 2017876764 },
                new Mark { MarkID = 12, MarkType = MarkType.AssessmentMark, MarkValue = 27.00, AssessmentID = 512, StudentID = 2017876764 },
                new Mark { MarkID = 13, MarkType = MarkType.AssessmentMark, MarkValue = 48.00, AssessmentID = 513, StudentID = 2017876764 },
                new Mark { MarkID = 14, MarkType = MarkType.AssessmentMark, MarkValue = 99.00, AssessmentID = 514, StudentID = 2017876764 },
                new Mark { MarkID = 15, MarkType = MarkType.AssessmentMark, MarkValue = 62.00, AssessmentID = 515, StudentID = 2017876764 },
                new Mark { MarkID = 16, MarkType = MarkType.AssessmentMark, MarkValue = 85.00, AssessmentID = 516, StudentID = 2017876764 },
                new Mark { MarkID = 17, MarkType = MarkType.AssessmentMark, MarkValue = 61.00, AssessmentID = 517, StudentID = 2017876764 },
                new Mark { MarkID = 18, MarkType = MarkType.AssessmentMark, MarkValue = 37.00, AssessmentID = 518, StudentID = 2017876764 },
                new Mark { MarkID = 19, MarkType = MarkType.AssessmentMark, MarkValue = 54.00, AssessmentID = 519, StudentID = 2017876764 },
                new Mark { MarkID = 20, MarkType = MarkType.AssessmentMark, MarkValue = 76.00, AssessmentID = 520, StudentID = 2017876764 },
                new Mark { MarkID = 21, MarkType = MarkType.AssessmentMark, MarkValue = 66.00, AssessmentID = 521, StudentID = 2017876764 },

                new Mark { MarkID = 22, MarkType = MarkType.AssessmentMark, MarkValue = 56.00, AssessmentID = 501, StudentID = 2016875761 },
                new Mark { MarkID = 23, MarkType = MarkType.AssessmentMark, MarkValue = 33.00, AssessmentID = 502, StudentID = 2016875761 },
                new Mark { MarkID =24, MarkType = MarkType.AssessmentMark, MarkValue = 96.00, AssessmentID = 503, StudentID = 2016875761 },
                new Mark { MarkID = 25, MarkType = MarkType.AssessmentMark, MarkValue = 18.00, AssessmentID = 504, StudentID = 2016875761 },
                new Mark { MarkID =26, MarkType = MarkType.AssessmentMark, MarkValue = 56.00, AssessmentID = 505, StudentID = 2016875761 },
                new Mark { MarkID = 27, MarkType = MarkType.AssessmentMark, MarkValue = 41.00, AssessmentID = 506, StudentID = 2016875761 },
                new Mark { MarkID = 28, MarkType = MarkType.AssessmentMark, MarkValue = 88.00, AssessmentID = 507, StudentID = 2016875761 },
                new Mark { MarkID = 29, MarkType = MarkType.AssessmentMark, MarkValue = 30.00, AssessmentID = 508, StudentID = 2016875761 },
                new Mark { MarkID =30, MarkType = MarkType.AssessmentMark, MarkValue = 98.00, AssessmentID = 509, StudentID = 2016875761 },
                new Mark { MarkID = 31, MarkType = MarkType.AssessmentMark, MarkValue = 55.00, AssessmentID = 510, StudentID = 2016875761 },
                new Mark { MarkID = 32, MarkType = MarkType.AssessmentMark, MarkValue = 94.00, AssessmentID = 511, StudentID = 2016875761 },
                new Mark { MarkID = 33, MarkType = MarkType.AssessmentMark, MarkValue = 47.00, AssessmentID = 512, StudentID = 2016875761 },
                new Mark { MarkID = 34, MarkType = MarkType.AssessmentMark, MarkValue = 88.00, AssessmentID = 513, StudentID = 2016875761 },
                new Mark { MarkID = 35, MarkType = MarkType.AssessmentMark, MarkValue = 39.00, AssessmentID = 514, StudentID = 2016875761 },
                new Mark { MarkID = 36, MarkType = MarkType.AssessmentMark, MarkValue = 92.00, AssessmentID = 515, StudentID = 2016875761 },
                new Mark { MarkID = 37, MarkType = MarkType.AssessmentMark, MarkValue = 55.00, AssessmentID = 516, StudentID = 2016875761 },
                new Mark { MarkID = 38, MarkType = MarkType.AssessmentMark, MarkValue = 41.00, AssessmentID = 517, StudentID = 2016875761 },
                new Mark { MarkID = 39, MarkType = MarkType.AssessmentMark, MarkValue = 67.00, AssessmentID = 518, StudentID = 2016875761 },
                new Mark { MarkID = 40, MarkType = MarkType.AssessmentMark, MarkValue = 84.00, AssessmentID = 519, StudentID = 2016875761 },
                new Mark { MarkID = 41, MarkType = MarkType.AssessmentMark, MarkValue = 36.00, AssessmentID = 520, StudentID = 2016875761 },
                new Mark { MarkID = 42, MarkType = MarkType.AssessmentMark, MarkValue = 96.00, AssessmentID = 521, StudentID = 2016875761 }

           /*2017876764,
        2016875761,
       2018867690, ,
       2016039762, 
       2017106766,
       2017106778*/

           );

            // 403
            modelBuilder.Entity<ModuleAssessment>().HasData(
                new ModuleAssessment { ModuleAssessmentID = 1, AssessmentID = 500, ModuleID = 403 },

                new ModuleAssessment { ModuleAssessmentID = 2, AssessmentID = 501, ModuleID = 403 },

                new ModuleAssessment { ModuleAssessmentID = 3, AssessmentID = 502, ModuleID = 403 },

                new ModuleAssessment { ModuleAssessmentID = 4, AssessmentID = 503, ModuleID = 403 },

                new ModuleAssessment { ModuleAssessmentID = 5, AssessmentID = 504, ModuleID = 403 },

                new ModuleAssessment { ModuleAssessmentID = 6, AssessmentID = 505, ModuleID = 403 },
                //other module 401
                new ModuleAssessment { ModuleAssessmentID = 7, AssessmentID = 506, ModuleID = 401 },

                new ModuleAssessment { ModuleAssessmentID = 8, AssessmentID = 507, ModuleID = 401 },

                new ModuleAssessment { ModuleAssessmentID = 9, AssessmentID = 508, ModuleID = 401 },

                new ModuleAssessment { ModuleAssessmentID = 10, AssessmentID = 509, ModuleID = 401 },

                new ModuleAssessment { ModuleAssessmentID = 11, AssessmentID = 510, ModuleID = 401 },
                //other module 402


                new ModuleAssessment { ModuleAssessmentID = 12, AssessmentID = 511, ModuleID = 402 },

                new ModuleAssessment { ModuleAssessmentID = 13, AssessmentID = 512, ModuleID = 402 },

                new ModuleAssessment { ModuleAssessmentID = 14, AssessmentID = 513, ModuleID = 402 },

                new ModuleAssessment { ModuleAssessmentID = 15, AssessmentID = 514, ModuleID = 402 },

                new ModuleAssessment { ModuleAssessmentID = 16, AssessmentID = 515, ModuleID = 402 },

                //other module 404

                new ModuleAssessment { ModuleAssessmentID = 17, AssessmentID = 516, ModuleID = 404 },

                new ModuleAssessment { ModuleAssessmentID = 18, AssessmentID = 517, ModuleID = 404 },

                new ModuleAssessment { ModuleAssessmentID = 19, AssessmentID = 518, ModuleID = 404 },

                new ModuleAssessment { ModuleAssessmentID = 20, AssessmentID = 519, ModuleID = 404 },

                new ModuleAssessment { ModuleAssessmentID = 21, AssessmentID = 520, ModuleID = 404 },

                new ModuleAssessment { ModuleAssessmentID = 22, AssessmentID = 521, ModuleID = 404 }
                );

            modelBuilder.Entity<Lecture>().HasData(
                new Lecture { LectureID = 1, ModuleID = 401, VenueID = 302,start_time = "Thursday,13:10",end_time = "Thursday,14:00" },
                new Lecture { LectureID = 2, ModuleID = 401, VenueID = 302, start_time = "Monday,13:10", end_time = "Monday,14:00" },
                new Lecture { LectureID = 3, ModuleID = 401, VenueID = 301, start_time = "Tuesday,15:10", end_time = "Tuesday,17:00" },
                new Lecture { LectureID = 4, ModuleID = 401, VenueID = 302, start_time = "Wednesday,13:10", end_time = "Wednesday,13:10" },


                new Lecture { LectureID = 5, ModuleID = 402, VenueID = 301, start_time = "Monday,12:10", end_time = "Monday,13:00" }, 
                new Lecture { LectureID = 6, ModuleID = 402, VenueID = 302, start_time = "Tuesday,15:10", end_time = "Tuesday,18:10" },

                new Lecture { LectureID = 7, ModuleID = 403, VenueID = 303, start_time = "Friday,13:10", end_time = "Friday,14:00" },
                new Lecture { LectureID = 8, ModuleID = 403, VenueID = 301, start_time = "Monday,09:10", end_time = "Monday,10:00" },
                new Lecture { LectureID = 9, ModuleID = 403, VenueID = 303, start_time = "Tuesday,17:10", end_time = "Tuesday,18:00" },
                new Lecture { LectureID = 10, ModuleID = 403, VenueID = 302, start_time = "Wednesday,11:10", end_time = "Wedesday,12:00" },

                 new Lecture { LectureID = 11, ModuleID = 404, VenueID = 303, start_time = "Monday,08:10", end_time = "Monday,09:00" },
                new Lecture { LectureID = 12, ModuleID = 404, VenueID = 303, start_time = "Tuesday,08:10", end_time = "Tuesday,10:00"},
                 new Lecture { LectureID = 13, ModuleID = 404, VenueID = 303, start_time = "Monday,08:10", end_time = "Monday,9:00" },
                new Lecture { LectureID = 14, ModuleID = 404, VenueID = 303, start_time = "Friday,08:10", end_time = "Friday,10:10" }
                );
           base.OnModelCreating(modelBuilder);
        }
    }
}
