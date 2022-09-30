using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesList
{
    [Table("table_course")]
    public class Course //наименование курса
    {
        [Column("course_id")]
        public int courseId { get; set; }

        [Column("course_name")]
        [Required]
        public string courseName { get; set; }

 //???       [Column("course_name")]
        [Required]
        List<AcademicDiscipline> courseDisciplines = new List<AcademicDiscipline>();//Дисциплины, которые включает в себя этот курс

    }
}
