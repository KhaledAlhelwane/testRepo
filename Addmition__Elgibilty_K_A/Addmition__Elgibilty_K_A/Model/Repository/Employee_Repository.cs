using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class Employee_Repository : interface_of_crud_operations<Emplolyee>
    {
        DataBaseAE DB;
        public Employee_Repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(Emplolyee entity)
        {
            DB.Employee.Add(entity);
            savechange();
        }


        public void Delete(int id)
        {
            var employee = Find(id);
            DB.Employee.Remove(employee);
            savechange();
        }

        public Emplolyee Find(int id)
        {
            var employee = DB.Employee.SingleOrDefault(a => a.id == id);
            return employee;
        }

        public IList<Emplolyee> List()
        {
            return DB.Employee.ToList();
        }

        public List<Emplolyee> Search(string term)
        {
         return DB.Employee.Where(a => a.name.Contains(term)).ToList();
        }

        public void Update(int id, Emplolyee entity)
        {
            DB.Employee.Update(entity);
            savechange();
        }
        void savechange() 
        {
            DB.SaveChanges();
        }
    }
}
