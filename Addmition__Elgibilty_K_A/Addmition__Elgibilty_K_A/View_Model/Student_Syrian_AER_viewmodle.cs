using Addmition__Elgibilty_K_A.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.View_Model
{
    public class Student_Syrian_AER_viewmodle
    {
        public int id { get; set; }
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
        public int Identity_No { get; set; }
        public string Full_Address { get; set; }
        public string Email { get; set; }
        public string Current_Address { get; set; }//address after the acciption
        public int Mobile_Phone { get; set; }
        public int Home_s_Phone { get; set; }
    
        /// ///////////////////////////////////////////////////////////////////////////////////////////
    
        // public  admission_eligibility_request A_E_R { get; set; }


        //  public int id_ad_El_RE { get; set; }
        public int The_Rate { get; set; }
        public string city_of_high_school_cirtificate { get; set; }
        public DateTime date_of_high_school_cirtificate { get; set; }
        //  public Wishess wishes { get; set; }

        public string type_of_cirtificate_sy_or_forighn { get; set; }


        public IFormFile Image_of_crtificat_URL { get; set; }

        public IFormFile front_image_of_identity_URL { get; set; }
        public IFormFile back_image_of_identity_URL { get; set; }
        public IFormFile check_recipt_image_URL { get; set; }
        public string ImageUrl_Image { get; set; }
        public string ImageUrl_Front { get; set; }
        public string ImageUrl_Back { get; set; }
        public string ImageUrl_Check { get; set; }
        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        //wishesssss

        // public int id_Wishes { get; set; }
        public List<Faculty> faculties { get; set; }
        public int wish_faculty_Id1 { get; set; }
        public int wish_faculty_Id2 { get; set; }
        public int wish_faculty_Id3 { get; set; }

      
        /// ////////////////////////////////////////////////////////////////////////////
     
        public string LAnguge_of_the_addmintion { get; set; }
        public string Subscription_number { get; set; }
        public int course_number { get; set; }


    }
}
