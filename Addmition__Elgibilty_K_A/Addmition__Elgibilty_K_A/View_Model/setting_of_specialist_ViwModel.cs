using Addmition__Elgibilty_K_A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.View_Model
{
    public class setting_of_specialist_ViwModel
    {
        public int id { get; set; }
        //public int Semster_no { get; set; }
       // public DateTime Semester_Date { get; set; }
        public int Chair_count { get; set; }
        public int Minemum_rate { get; set; }
        public int faculty_id { get; set; }
        public string specialist { get; set; }
        public List<Faculty> faculty_list { get; set; }
        public statues_of_admission_elgibilty Status_Of_A_E { get; set; }
        // public List<Faculty> faculty_list { get; set; }

    }
}
