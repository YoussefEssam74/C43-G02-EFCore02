using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF0_Core_02.Models
{
    internal class Topic
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
