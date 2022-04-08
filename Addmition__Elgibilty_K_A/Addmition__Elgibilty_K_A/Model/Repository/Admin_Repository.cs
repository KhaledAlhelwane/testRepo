//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Addmition__Elgibilty_K_A.Model.Repository
//{
//    public class Admin_Repository : interface_of_crud_operations<Admin>
//    {
//        DataBaseAE DB;
//        public Admin_Repository(DataBaseAE _DB)
//        {
//            DB = _DB;
//        }

//        public void Add(Admin entity)
//        {

//            //DB.Admin.Add(entity);
//            DB.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            var admin = Find(id);
//            //DB.Admin.Remove(admin);
//          DB.SaveChanges();
//        }

//        public Admin Find(int id)
//        {
//            //var Admin = DB.Admin.SingleOrDefault(a => a.id == id);
//           //
//           //return Admin ;

//        }

//        public IList<Admin> List()
//        {
//            throw new NotImplementedException();
//        }

//        public List<Admin> Search(string term)
//        {
//            return DB.Admin.ToList();
//        }

//        public void Update(int id, Admin entity)
//        {
//            DB.Employee.Update(entity);
//            DB.SaveChanges();
//        }
//    }
//}
