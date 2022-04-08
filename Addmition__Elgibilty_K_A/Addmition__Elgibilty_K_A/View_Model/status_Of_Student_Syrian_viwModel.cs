using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.View_Model
{
    public class status_Of_Student_Syrian_viwModel
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
      
        public string Civil_Registriation_City { get; set; }
        public int Civil_Registrition_No { get; set; }
      
         public int Identity_No { get; set; }

        public string front_image_of_identity_URL { get; set; }
        public string back_image_of_identity_URL { get; set; }

        public int Mobile_Phone { get; set; }
        public int Home_s_Phone { get; set; }

        /// <summary>
        /// /////////////////////////////////////////////////
        /// </summary>
        //  public int id { get; set; }
        public string city_of_high_school_cirtificate { get; set; }
        public int The_Rate { get; set; }

        public DateTime date_of_high_school_cirtificate { get; set; }
        public string LAnguge_of_the_addmintion { get; set; }
        public string Subscription_number { get; set; }
        public int course_number { get; set; }

        public string Image_of_crtificat_URL { get; set; }
        public bool Checked_document { get; set; }
        public string check_recipt_image_URL { get; set; }
        public bool Checked_recipet { get; set; }
        //  public bool Accept { get; set; }
        public DateTime Date_of_Acshiving { get; set; }



        ///////////////////////////////////////////////////////////////////////////
        ///

        //public int id { get; set; }
        // public Wishess wishes { get; set; }

        //this attribut will be not in using .
        //public string type_of_cirtificate_sy_or_forighn { get; set; }




    }
}
