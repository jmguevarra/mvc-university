using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcUniversity.Data;
using MvcUniversity.Models;
using Newtonsoft.Json;
using System.IO;

namespace MvcUniversity.Controllers
{
    public class TeachersController : Controller
    {
        private readonly MvcUniversityDbContext _db;
        private IEnumerable<Teacher> teachers;
        private JsonOptions jsonOptions;

        public TeachersController(MvcUniversityDbContext db)
        {
            this._db = db;
            this.teachers = this._db.Teacher;
            this.jsonOptions = JsonConvert.DeserializeObject<JsonOptions>("");
        }
        public IActionResult Index()
        {
            return View(this.teachers);
        }

        public IActionResult Edit() {

            return View();
        }
    }
}
