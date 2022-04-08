using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class wish_Repository : interface_of_crud_operations<Wishess>
    {
        DataBaseAE DB;
        public wish_Repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(Wishess entity)
        {
            DB.Wishss.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var wish = Find(id);
            DB.Wishss.Remove(wish);
            DB.SaveChanges();
        }

        public Wishess Find(int id)
        {
         //  var wish = DB.Wishss.Include(a => a.wish_faculty1.Faculty_name).SingleOrDefault(a => a.id == id);
           
            var wish = DB.Wishss.Include(a=>a.wish_faculty1).Include(a => a.wish_faculty2).Include(a => a.wish_faculty2).SingleOrDefault(a => a.id == id);
          
            return wish;
        }

        public IList<Wishess> List()
        {
            return DB.Wishss.ToList();
        }

        public List<Wishess> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Wishess entity)
        {
            DB.Wishss.Update(entity);
           
            DB.SaveChanges();
          //  DB.DisposeAsync();

        }
    }
}
