using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF0_Core_02.Models
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        public int Dept_ID { get; set; }
        [ForeignKey("Dept_ID")]
        public Department Department { get; set; }

        public ICollection<CourseInst> CourseInsts { get; set; }
    }
}
