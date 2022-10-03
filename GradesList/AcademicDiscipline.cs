using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesList
{
    [Table("academic_discipline")]
    public class AcademicDiscipline //учебная дисциплина
    {
        [Column("discipline_id")]
        public int dscplnId { get; set; }

        [Column("discipline_name")]
        [Required]
        public string dscplnName { get; set; } //наименование учебной дисциплины

        [Column("discipline_name")]
        [Required]
        public int studentID { set; get; }
        public Student Student { get; set; } //навигация на студента

        public int score { get; set; } //оценка

        [Column("discipline_name")]
        [Required]
        public int gtID { set; get; }
        public GradeType GradeType { get; set; } //навигация на тип оценки

        public List<Course> disciplinesIncludInCourse = new List<Course>(); //навигация в курс
    }
}

