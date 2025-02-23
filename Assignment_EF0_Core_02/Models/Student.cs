using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF0_Core_02.Models
{
    internal class Student
    {
        public int ID { get; set; }
        [Required, MaxLength(50)]
        public string FName { get; set; }
        [Required, MaxLength(50)]
        public string LName { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [Range(18, 100)]
        public int Age { get; set; }

        public int Dep_Id { get; set; }
        [ForeignKey("Dep_Id")]
        public Department Department { get; set; }

        public ICollection<StudCourse> StudCourses { get; set; }
    }
}

