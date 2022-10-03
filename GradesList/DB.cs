using Microsoft.EntityFrameworkCore;
using DBConfigLib;


namespace GradesList
{
    public class DB : DbContext
    {
        public DbSet<Student> TableStudents => Set<Student>();
        public DbSet<Course> TableCourse => Set<Course>();
        public DbSet<AcademicDiscipline> TableAcademicDiscipline => Set<AcademicDiscipline>();
        public DbSet<GradeType> TableGreadType => Set<GradeType>();

        public DB()
        {
            Database.EnsureDeleted(); //удаляет базу, если она существует
            Database.EnsureCreated(); //существует ли база, если нет - создает
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(DBConfig.ImportFromJson("db.json").ToString());
        }
    }
}

