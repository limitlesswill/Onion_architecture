using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Models
{
    public class StudentCourse
    {
        public int id { get; set; }
        public Student? student { get; set; }
        public Course? course { get; set; }
    }
}
