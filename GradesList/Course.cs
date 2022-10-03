using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesList
{
    [Table("course")]
    public class Course //наименование курса
    {
        [Column("course_id")]
        public int courseId { get; set; } 

        [Column("course_name")]
        [Required]
        public string courseName { get; set; } //название курса

        [Column("academic_discipline_id")]
        [Required]
        public int dscplnId { get; set; }
        public AcademicDiscipline acDiscipline { get; set; } //навигация на дисциплину

        public List<Student> students = new List<Student>(); //навигация в студента

    }
}

