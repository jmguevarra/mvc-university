using Microsoft.AspNetCore.Mvc;
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

        public IActionResult AddStudent() {
            IEnumerable<Student> objStudents = _db.Student;
            ViewBag.studLRN = Int64.Parse(objStudents.Last().StudLRN) + 1;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(Student obj) {

            if ( !ModelState.IsValid ) { return View(obj); } //return if not valid

            _db.Student.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
