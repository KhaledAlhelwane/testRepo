using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class admission_eligibility_request
    {
        public int id { get; set; }
        public int The_Rate { get; set; }
        public string city_of_high_school_cirtificate { get; set; }
        public DateTime date_of_high_school_cirtificate { get; set; }
        //public Wishess wishes { get; set; }
     
        //this attribut will be not in using .
        public string type_of_cirtificate_sy_or_forighn { get; set; }

        public string Image_of_crtificat_URL { get; set; }

        public string front_image_of_identity_URL { get; set; }
        public string back_image_of_identity_URL { get; set; }
        public string check_recipt_image_URL { get; set; }
        public int StudentId { get; set; }
        public Student student_Info { get; set; }

    }
}
