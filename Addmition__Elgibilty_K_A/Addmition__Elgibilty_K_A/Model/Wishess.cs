using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class Wishess
    {
        public int id { get; set; }
        public Faculty wish_faculty1 { get; set; }
        public Faculty wish_faculty2 { get; set; }
        public Faculty wish_faculty3 { get; set; }
        public int StudentId { get; set; }
        public Student student_Info { get; set; }

    }
}
