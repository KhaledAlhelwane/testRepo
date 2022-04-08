using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class Admin:Emplolyee
    {
      public  setting_of_specialties s_o_s { get; set; }//help me
       public statues_of_admission_elgibilty s_o_a_e { get; set; }//sariaaa alsowass
        public Faculty faculty { get; set; }
        public Type_of_certificate   Type_Of_Certificate { get; set; }
    }
}
