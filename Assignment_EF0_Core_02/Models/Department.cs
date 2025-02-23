using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF0_Core_02.Models
{
    internal class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public int Ins_ID { get; set; }
        [ForeignKey("Ins_ID")]
        public Instructor Instructor { get; set; }

        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
