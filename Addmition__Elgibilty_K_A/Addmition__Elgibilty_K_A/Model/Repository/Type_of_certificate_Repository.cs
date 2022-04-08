using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class Type_of_certificate_Repository : interface_of_crud_operations<Type_of_certificate>
    {
        DataBaseAE DB;
        public Type_of_certificate_Repository(DataBaseAE _DB)
        {
            DB = _DB;        
        }
        public void Add(Type_of_certificate entity)
        {
            DB.Type_of_certificate.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var toc = Find(id);
            DB.Type_of_certificate.Remove(toc);
            DB.SaveChanges();
        }

        public Type_of_certificate Find(int id)
        {

            var toc = DB.Type_of_certificate.SingleOrDefault(a => a.id == id);
            return toc;
        }

        public IList<Type_of_certificate> List()
        {
            return DB.Type_of_certificate.ToList();
        }

        public List<Type_of_certificate> Search(string term)
        {
            return DB.Type_of_certificate.Where(a => a.Type.Contains(term)).ToList();

        }

        public void Update(int id, Type_of_certificate entity)
        {
            DB.Type_of_certificate.Update(entity);
            DB.SaveChanges();
        }
    }
}
