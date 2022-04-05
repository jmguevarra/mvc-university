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
        private IEnumerable<Student> objStudents;

        public StudentsController(MvcUniversityDbContext db)
        {
            this._db = db;
            this.objStudents = _db.Student;
        }

        public IActionResult Index()
        {
            return View(this.objStudents);
        }

        public IActionResult AddStudent() {
            ViewBag.studLRN = Int64.Parse(this.objStudents.Last().StudLRN) + 1;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(Student obj) {
            ViewBag.studLRN = Int64.Parse(this.objStudents.Last().StudLRN) + 1;

            if ( !ModelState.IsValid ) { return View(obj); } //return if not valid

            _db.Student.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id) {
            if (id == null || id == 0) { return NotFound(); }

            var studToEdit = _db.Student.Find(id);
            if (studToEdit == null) { return NotFound();  }

            return View(studToEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj) {

            if (!ModelState.IsValid) { return View(obj);  }

            _db.Student.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }

            var studToDel = _db.Student.Find(id);
            if (studToDel == null) { return NotFound(); }

            return View(studToDel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStudent(int? id)
        {
            if (id == null || id == 0) { return NotFound(); }

            var studToDel = _db.Student.Find(id);
            if (studToDel == null) { return NotFound(); }

            _db.Student.Remove(studToDel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
