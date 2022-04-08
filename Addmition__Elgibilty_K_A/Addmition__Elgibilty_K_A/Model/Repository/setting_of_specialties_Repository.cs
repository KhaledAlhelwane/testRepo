using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Model.Repository
{
    public class setting_of_specialties_Repository : interface_of_crud_operations<setting_of_specialties>
    {
        DataBaseAE DB;
        public setting_of_specialties_Repository(DataBaseAE _DB)
        {
            DB = _DB;
        }
        public void Add(setting_of_specialties entity)
        {
            DB.setting_of_specialties.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var setting_of_speciali = Find(id);
            DB.setting_of_specialties.Remove(setting_of_speciali);
            DB.SaveChanges();
        }

        public setting_of_specialties Find(int id)
        {

            var setting_of_speciatliess = DB.setting_of_specialties.Include(a => a.Stautues_of_admi_eligi).Include(a => a.faculty.Type_of_certificate).SingleOrDefault(a => a.id == id);
            return setting_of_speciatliess;
        }

        public IList<setting_of_specialties> List()
        {
        return  DB.setting_of_specialties.Include(a => a.faculty.Type_of_certificate).Include(a => a.Stautues_of_admi_eligi).ToList();
        }

        public List<setting_of_specialties> Search(string term)
        {
            //  return DB.setting_of_specialties.Where(a => a.faculty.Faculty_name.Contains(term)).ToList();
            throw new NotImplementedException();
        }

        public void Update(int id, setting_of_specialties entity)
        {
            DB.setting_of_specialties.Update(entity);
            DB.SaveChanges();
        }
    }
}
