﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcUniversity.Data;
using MvcUniversity.Models;

namespace MvcUniversity.Controllers
{
    public class StudentsController : Controller
    {
        private readonly MvcUniversityDbContext _db;

        public StudentsController(MvcUniversityDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> objStudent = _db.Student;
            return View(objStudent);
        }
    }
}
