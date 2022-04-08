using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class Fauclty_Repository : interface_of_crud_operations<Faculty>
    {
        DataBaseAE DB;
        public Fauclty_Repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(Faculty entity)
        {
            DB.Faculty.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
           var faculty= Find(id);
            DB.Faculty.Remove(faculty);
            DB.SaveChanges();
        }

        public Faculty Find(int id)
        {
            var faculty = DB.Faculty.Include(a => a.Type_of_certificate).SingleOrDefault(a => a.id == id);
            return faculty;
        }

        public IList<Faculty> List()
        {

            return DB.Faculty.Include(a => a.Type_of_certificate).ToList();
        }

        public List<Faculty> Search(string term)
        {
            return DB.Faculty.Where(a => a.Faculty_name.Contains(term)).ToList();
        }

        public void Update(int id, Faculty entity)
        {
            DB.Faculty.Update(entity);
            DB.SaveChanges();

        }
    }
}
