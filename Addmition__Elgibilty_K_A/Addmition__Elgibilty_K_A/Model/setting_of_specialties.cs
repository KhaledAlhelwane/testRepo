using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class setting_of_specialties
    {
        public int id { get; set; }
       // public int Semster_no { get; set; }
       // public DateTime Semester_Date { get; set; }                
        public int Chair_count { get; set; }
        public int Minemum_rate { get; set; }
        public Faculty faculty { get; set; }
        public statues_of_admission_elgibilty Stautues_of_admi_eligi { get; set; }
    }
}
