using Addmition__Elgibilty_K_A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.View_Model
{
    public class Fculty_Type_of_toc_ViwModel
    {
        public int id { get; set; }
        public string Faculty_name { get; set; }
        public int Type_of_certificate_id { get; set; }
        public List< Type_of_certificate> Type_of_certificate_list { get; set; }
        public string specialization { get; set; }
    }
}
