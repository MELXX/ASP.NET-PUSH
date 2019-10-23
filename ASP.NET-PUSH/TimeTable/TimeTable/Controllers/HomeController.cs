using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeTable.Models;
using TimeTable.Models.Data;

namespace TimeTable.Controllers.Home
{
    public class HomeController : Controller
    {
        IRepositoryWrapper Wrapper;
        public HomeController(IRepositoryWrapper _Wrapper)
        {
            Wrapper = _Wrapper;
        }
        public ViewResult Index()
        {
            var v = Wrapper.Course.FindAll();
            return View(v);
        }
        public ViewResult ThreeDay()
        {
            var v = Wrapper.Course.FindAll();
            return View(v);
        }

        public ViewResult Day()
        {
            var v = Wrapper.Course.FindAll();
            return View(v);
        }

    }
}