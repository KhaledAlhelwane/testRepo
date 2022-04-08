using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{

    public class Admission_Eligibility_request_Un_Repository : interface_of_crud_operations<admission_eligibility_request>
    {
        DataBaseAE DB;
        public Admission_Eligibility_request_Un_Repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(admission_eligibility_request entity)
        {
            DB.admission_eligibility_request.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {

            var a_E_R_find = Find(id);
            DB.admission_eligibility_request.Remove(a_E_R_find);
            DB.SaveChanges();
        }

        public admission_eligibility_request Find(int id)
        {

            //    var find_aer = DB.admission_eligibility_request.Include(a => a.wishes.wish_faculty1).Include(a => a.wishes.wish_faculty2).Include(a => a.wishes.wish_faculty3).SingleOrDefault(a => a.id == id);
            var find_aer = DB.admission_eligibility_request.SingleOrDefault(a => a.id == id);


            return find_aer;
                
               
        }

        public IList<admission_eligibility_request> List()
        {
            //.Include(a => a.wishes.wish_faculty1).Include(a => a.wishes.wish_faculty2).Include(a => a.wishes.wish_faculty3)
            return DB.admission_eligibility_request.ToList();
           
        }

        public List<admission_eligibility_request> Search(string term)
        {
           // return DB.admission_eligibility_request.Where(a=>a..Contains(term)).ToList()
            throw new NotImplementedException();
        }

        public void Update(int id, admission_eligibility_request entity)
        {
            DB.admission_eligibility_request.Update(entity);
            DB.SaveChanges();
        }
    }
}
