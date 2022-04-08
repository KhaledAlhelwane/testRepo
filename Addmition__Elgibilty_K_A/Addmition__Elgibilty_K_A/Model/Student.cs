using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
  
    public class Student
    { 
        
       public int Id { get; set; }
        public string high_school_certificate { get; set; }//syrian or not syrian certificate
        public string First_Name { get; set; }
        public string Father_Name { get; set; }
        public string Mother_Name { get; set; }
        public string Nick_Name { get; set; }
        public string gender { get; set; }
        public string Nationality { get; set; }
        public DateTime Birth { get; set; }

        public string Marital_status { get; set; }
        public string Civil_Registriation_City { get; set; }
        public int Civil_Registrition_No { get; set; }
        public string Blood_Type { get; set; }
        public int Passport_No { get; set; }
        public int Identity_No{ get; set; }
        public string Full_Address{ get; set; }
    public string Email { get; set; }
        public string Current_Address { get; set; }//address after the acciption
        public int Mobile_Phone  { get; set; }
        public int Home_s_Phone { get; set; }
         public admission_eligibility_request A_E_R { get; set; }
        public Wishess wishess { get; set; }
        public Acceptaple_Config Acceptable_coniguration { get; set; }


        // public Emplolyee eMPLOYEE { get; set; }

    }
}
