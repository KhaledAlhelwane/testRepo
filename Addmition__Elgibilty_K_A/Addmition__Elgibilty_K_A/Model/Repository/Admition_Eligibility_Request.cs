using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class Admition_Eligibility_Request : interface_of_crud_operations<admission_ligibility_request_SY>
    {
        DataBaseAE DB;
        public Admition_Eligibility_Request(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(admission_ligibility_request_SY entity)
        {
            DB.admission_ligibility_request_SY.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = Find(id);
            DB.admission_ligibility_request_SY.Remove(x);
            DB.SaveChanges();
        }

        public admission_ligibility_request_SY Find(int id)
        {
            //var x = DB.admission_ligibility_request_SY.Include(a => a.wishes.wish_faculty1).Include(a => a.wishes.wish_faculty2).Include(a => a.wishes.wish_faculty3).SingleOrDefault(a => a.id == id);

            var x = DB.admission_ligibility_request_SY.SingleOrDefault(a=>a.id==id);
            return x;
        }

        //public admission_ligibility_request_SY Findbyidntityno(int idntityno)
        //{
        //    var x = DB.admission_ligibility_request_SY.Include(a => a.wishes.wish_faculty1).Include(a => a.wishes.wish_faculty2).Include(a => a.wishes.wish_faculty3).SingleOrDefault(a => a.id == id);
        //    return x;
        //}

        public IList<admission_ligibility_request_SY> List()
        {
            //return DB.admission_ligibility_request_SY.Include(a => a.wishes.wish_faculty1).Include(a => a.wishes.wish_faculty2).Include(a => a.wishes.wish_faculty3).ToList();

            return DB.admission_ligibility_request_SY.ToList();

        }

        public List<admission_ligibility_request_SY> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, admission_ligibility_request_SY entity)
        {
            // DB.admission_ligibility_request_SY.AsNoTracking();
            DB.admission_ligibility_request_SY.Update(entity);
            DB.SaveChanges();
            // DB.DisposeAsync();
        }
    }
}
