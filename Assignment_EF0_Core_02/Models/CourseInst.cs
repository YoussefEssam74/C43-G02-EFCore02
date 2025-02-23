using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF0_Core_02.Models
{
    internal class CourseInst
    {
        [Key]
        public int Inst_ID { get; set; }
        [Key]
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }

        [ForeignKey("Inst_ID")]
        public Instructor Instructor { get; set; }
        [ForeignKey("Course_ID")]
        public Course Course { get; set; }
    }
}