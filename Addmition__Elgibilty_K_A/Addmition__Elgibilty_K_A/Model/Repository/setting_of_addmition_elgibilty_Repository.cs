using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class setting_of_addmition_elgibilty_Repository : interface_of_crud_operations<statues_of_admission_elgibilty>
    {
        DataBaseAE DB;
        public setting_of_addmition_elgibilty_Repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(statues_of_admission_elgibilty entity)
        {
            DB.statues_of_admission_elgibilty.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
          var b=  Find(id);
            DB.statues_of_admission_elgibilty.Remove(b);
            DB.SaveChanges();
        }

        public statues_of_admission_elgibilty Find(int id)
        {
            var st_of_ad_el = DB.statues_of_admission_elgibilty.SingleOrDefault(a => a.id== id);
            return st_of_ad_el;


        }

        public IList<statues_of_admission_elgibilty> List()
        {
            return DB.statues_of_admission_elgibilty.ToList();
        }

        public List<statues_of_admission_elgibilty> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, statues_of_admission_elgibilty entity)
        {
            DB.statues_of_admission_elgibilty.Update(entity);
            DB.SaveChanges();
        }
    }
}
