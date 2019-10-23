using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeTable.Models;
using TimeTable.Models.Data;
using TimeTable.Models.Entities;

namespace TimeTable.Controllers
{
    public class MarkSummary
    {
        int StudentId;
        IEnumerable<Mark> Marks;
        IEnumerable<Assessment> assessments;
        IEnumerable<Module> modules;

        public MarkSummary(int studentId, IEnumerable<Mark> marks, IEnumerable<Assessment> assessments, IEnumerable<Module> modules)
        {
            StudentId = studentId;
            Marks = marks;
            this.assessments = assessments;
            this.modules = modules;
        }

        public double calcSemMark(int moduleID, IEnumerable<Mark> marks)
        {
            double semMark = 0;
            foreach (var mark in marks)
            {
                var ass = assessments.First(y => y.AssessmentID == mark.AssessmentID);
                if (mark.MarkType != MarkType.GoalMark || ass.AssessmentType != AssessmentType.Exam )
                {
                    semMark += ((mark.MarkValue / ass.Mark) * (double)ass.PredicateWeight) * 100.00; 
                }
            }
            return semMark;
        }

        public double calcRequiredMark(int moduleID, Mark SemMark)
        {
             throw new NotImplementedException();
        }


        public double calcFinMark(int moduleID,Mark exam_mark)
        {
            var ass = assessments.First(y => y.AssessmentID == exam_mark.AssessmentID);
            var semMk = calcSemMark(moduleID, Marks);
            if (ass.FinalWeight == null)
            {
                return -1;
            }
            return (semMk * 1-(double)ass.FinalWeight) * 100 + (exam_mark.MarkValue * (double)ass.FinalWeight) * 100;
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : Controller
    {
        private readonly IRepositoryWrapper Wrapper;

        public MarksController(IRepositoryWrapper _Wrapper)
        {
            Wrapper = _Wrapper;
        }

        public ViewResult GetMarks(int id)
        {
            var student = Wrapper.Student.GetById(id);
            var mods = Wrapper.Module.FindAll().Where(x => x.CourseID.ToString() == student.CourseID);
            var marks = Wrapper.Marks.FindByCondition(x => x.StudentID == student.StudentID);
            var assessments = Wrapper.Assessment.FindAll().Where(x => mods.Any(y => y.ModuleID == x.ModuleID));

            MarkSummary ms = new MarkSummary(id, marks, assessments, mods); 
            //var assessments = Wrapper.Assessment.FindByCondition(x => x.)



            return View(ms);
        }



        [HttpGet]
        public ViewResult InputGoal()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputGoal(Mark mark)
        {
            try
            {
                Wrapper.Marks.Update(mark);
                Wrapper.Marks.Save();
            }catch (Exception){}

            return View("Index","Home");
        }



    }
}
