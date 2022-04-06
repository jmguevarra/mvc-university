using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcUniversity.Data;
using MvcUniversity.Models;

namespace MvcUniversity.Controllers
{
    public class TeachersController : Controller
    {
        private readonly MvcUniversityDbContext _db;
        private IEnumerable<Teacher> teachers;

        public TeachersController(MvcUniversityDbContext db)
        {
            this._db = db;
            this.teachers = this._db.Teacher;
        }
        public IActionResult Index()
        {
            return View(this.teachers);
        }
    }
}
