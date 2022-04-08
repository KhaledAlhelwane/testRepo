using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class statues_of_student_Repository : interface_of_crud_operations<statues_of_student>
    {
        DataBaseAE DB;
        public statues_of_student_Repository(DataBaseAE _DB)
        {
            DB = _DB;   
        }
        public void Add(statues_of_student entity)
        {
            DB.Statues_of_student.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var S_O_S_Find = Find(id);
            DB.Statues_of_student.Remove(S_O_S_Find);
            DB.SaveChanges();
        
        }

        public statues_of_student Find(int id)
        {

            var sos = DB.Statues_of_student.Include(a=>a.Student_Info).ThenInclude(a=>a.A_E_R).SingleOrDefault(a=>a.id==id);
            return sos;
        }

        public IList<statues_of_student> List()
        {
        return    DB.Statues_of_student.Include(a => a.Student_Info).ToList();

           // return DB.Statues_of_student.Include(a => a.Employee_Info.name).Include(a => a.Student_Info.First_Name).ToList();

        }

        public List<statues_of_student> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, statues_of_student entity)
        {
            DB.Statues_of_student.Update(entity);
            DB.SaveChanges();
            
        }
    }
}
