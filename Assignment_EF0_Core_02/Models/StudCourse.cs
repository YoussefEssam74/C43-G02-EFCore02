using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF0_Core_02.Models
{
    internal class StudCourse
    {
        [Key]
        public int Stud_ID { get; set; }
        [Key]
        public int Course_ID { get; set; }
        public string Grade { get; set; }

        [ForeignKey("Stud_ID")]
        public Student Student { get; set; }
        [ForeignKey("Course_ID")]
        public Course Course { get; set; }
    }
}
