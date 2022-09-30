using Microsoft.EntityFrameworkCore;
using DBConfigLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesList
{
    public class DB : DbContext
    {
        public DbSet<Student> TableStudents => Set<Student>();
        public DbSet<AcademicDiscipline> TableAcademicDiscipline => Set<AcademicDiscipline>();
        public DbSet<Course> TableCourse => Set<Course>();

        public DB()
        {
            Database.EnsureCreated(); //существует ли база, если нет - создает
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(DBConfig.ImportFromJson("db.json").ToString());
        }
    }
}

