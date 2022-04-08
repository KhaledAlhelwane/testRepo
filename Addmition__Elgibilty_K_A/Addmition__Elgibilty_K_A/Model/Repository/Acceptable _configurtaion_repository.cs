using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class Acceptable__configurtaion_repository : interface_of_crud_operations<Acceptaple_Config>
    {
        DataBaseAE DB;
        public Acceptable__configurtaion_repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(Acceptaple_Config entity)
        {
            DB.Acceptaple_configuration.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
          var  Acc_Con = Find(id);
            DB.Acceptaple_configuration.Remove(Acc_Con);
        }

        public Acceptaple_Config Find(int id)
        {
            var Acc_con = DB.Acceptaple_configuration.SingleOrDefault(a=>a.id==id);
            return Acc_con;
        }

        public IList<Acceptaple_Config> List()
        {
            var Acc_con = DB.Acceptaple_configuration.ToList();
            return Acc_con;
        }

        public List<Acceptaple_Config> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Acceptaple_Config entity)
        {
            DB.Acceptaple_configuration.Update(entity);
            DB.SaveChanges();
        }
    }
}
