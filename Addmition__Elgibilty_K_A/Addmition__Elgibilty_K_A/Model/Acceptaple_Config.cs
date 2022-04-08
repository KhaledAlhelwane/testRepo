using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class Acceptaple_Config
    {
        public  int id { get; set; }
        public  bool Accept { get; set; }
        public int StudentId { get; set; }
        public Student Student_Info { get; set; }
        public string Acceptable_wishes { get; set; }
        public void Algorithem() { }
    }
}
