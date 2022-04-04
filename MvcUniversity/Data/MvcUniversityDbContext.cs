using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcUniversity.Models;
using Microsoft.EntityFrameworkCore;


namespace MvcUniversity.Data
{
    public class MvcUniversityDbContext : DbContext
    {
        public MvcUniversityDbContext(DbContextOptions<MvcUniversityDbContext> options): base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
    }
}
