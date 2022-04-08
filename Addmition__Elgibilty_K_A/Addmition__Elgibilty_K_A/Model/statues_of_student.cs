using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model
{
    public class statues_of_student
    {

        public int id { get; set; }
        public DateTime Date_of_Acshiving { get; set; }
        public bool Checked_recipet{ get; set; }
        public bool Checked_document { get; set; }
        public bool  Accept { get; set; }
        public Student Student_Info { get; set; }
        public Emplolyee Employee_Info { get; set; }
       
    }
}
