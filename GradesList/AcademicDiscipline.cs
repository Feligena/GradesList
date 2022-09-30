using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesList
{
    [Table("table_academic_discipline")]
    public class AcademicDiscipline //учебная дисциплина
    {
        [Column("discipline_id")]
        public int dscplnId { get; set; }

        [Column("discipline_name")]
        [Required]
        public string dscplnName { get; set; } //наименование учебной дисциплины

 //???   [Column("discipline_name")]
        [Required]
        List<int> grades = new List<int>(); //список оценок студента по дисциплине

    }
}
