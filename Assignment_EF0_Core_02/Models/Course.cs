using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF0_Core_02.Models
{
    internal class Course
    {
        [Key]
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string Duration { get; set; }

        public int Top_ID { get; set; }
        [ForeignKey("Top_ID")]
        public Topic Topic { get; set; }

        public ICollection<StudCourse> StudCourses { get; set; }
        public ICollection<CourseInst> CourseInsts { get; set; }
    }
}
