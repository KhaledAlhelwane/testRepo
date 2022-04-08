using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class statues_of_admission_elgibilty
    {
        public int id { get; set; }

        public string Type_Of_admission_elgibilty { get; set; }
        public DateTime begaining_date_of_the_process { get; set; }
        public int semesterNo { get; set; }
        public DateTime semesterDate { get; set; }
    }
}
