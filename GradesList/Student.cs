using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesList
{
    [Table("student")]
    public class Student //карточка студента
    {
        [Column("student_id")]
        public int studentId { get; set; }

        [Column("first_name")]
        [Required]
        public string firstName { get; set; }

        [Column("last_name")]
        [Required]
        public string lastName { get; set; }

        [Column("course_id")]
        [Required]
        public int courseId { get; set; }//на каком направлении(курсе) учится студент
        public Course Course { get; set; } //навигация на курс

        public List<AcademicDiscipline> academicDisciplines = new List<AcademicDiscipline>(); //навигация в дисциплину
    }
}

