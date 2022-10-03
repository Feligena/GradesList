using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesList
{
    [Table ("grade_type")]
    public class GradeType //тип оценки, за что студент получил оценку
    {
        [Column("grade_type_id")]
        public int gtID { get; set; }

        [Column ("grade_type_name")]
        [Required]
        public string gtName { get; set; } //название типа оценки

        public List<AcademicDiscipline> acadenicDisciplines = new List<AcademicDiscipline>(); //навигация в дисциплину
    }
}
