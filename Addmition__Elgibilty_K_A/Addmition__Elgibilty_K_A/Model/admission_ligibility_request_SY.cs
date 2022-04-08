using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class admission_ligibility_request_SY:admission_eligibility_request
    {
        public string LAnguge_of_the_addmintion {get; set; }
        public string Subscription_number { get; set; }
        public int course_number { get; set; }
    }
}
