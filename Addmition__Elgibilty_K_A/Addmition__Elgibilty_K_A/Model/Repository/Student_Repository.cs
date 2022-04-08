using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Threading.Tasks;
using Addmition__Elgibilty_K_A.Areas.Identity.Data;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class Student_Repository : interface_of_crud_operations<Student>
    {
        DataBaseAE DB;
        public Student_Repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(Student entity)
        {
            DB.Student.Add(entity);
            DB.SaveChanges();

            
        }

       

        public void Delete(int id)

        {
            var studen_f = Find(id);
            DB.Remove(studen_f);
            DB.SaveChanges();
            
        }

        public Student Find(int identityno)
        {
            var Student_f = DB.Student.Include(a=>a.A_E_R).Include(a => a.wishess).Single(a=>a.Id==identityno);
            return Student_f;
           
        }
       

        public IList<Student> List()
        {
            return DB.Student.Include(a => a.A_E_R).ToList();
            
        }

        public List<Student> Search(string term)
        {
            return DB.Student.Where(a=>a.First_Name.Contains(term)).ToList();
          
        }

        public void Update(int id, Student entity)
        {
           
            DB.Student.Update(entity);
            DB.SaveChanges();
           
        }


        public static void ShowEntityState(DataBaseAE context)
        {
            foreach (EntityEntry entry in context.ChangeTracker.Entries())
            {
                //Discards are local variables which you can assign but cannot read from. i.e. they are “write-only” local variables.
                _ = ($"type: {entry.Entity.GetType().Name}, state: {entry.State}," + $" {entry.Entity}");
            }
        }


    }
}
