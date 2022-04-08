using Addmition__Elgibilty_K_A.Model;
using Addmition__Elgibilty_K_A.Model.Repository;
using Addmition__Elgibilty_K_A.View_Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Controllers
{
    public class AdminController : Controller
    {
        private readonly interface_of_crud_operations<Emplolyee> admin_Repository;
        private readonly interface_of_crud_operations<Faculty> faculty_Repository;
        private readonly interface_of_crud_operations<setting_of_specialties> setting_Of_Specialties_re;
        private readonly interface_of_crud_operations<Type_of_certificate> type_Of_Certificat_Toc_R;
        private readonly interface_of_crud_operations<statues_of_admission_elgibilty> statues_Of_Addmitoion_Elgibilty_R;



        // GET: AdminController
        // interface_of_crud_operations<Emplolyee> Admin_repository,
        public AdminController(interface_of_crud_operations<Emplolyee> Admin_repository,
            interface_of_crud_operations<Faculty> faculty_repository,
            interface_of_crud_operations<setting_of_specialties> setting_of_specialties,
            interface_of_crud_operations<Type_of_certificate> Type_of_certificat_toc,
            interface_of_crud_operations<statues_of_admission_elgibilty> statues_of_addmitoion_elgibilty_r

           )
        {
           admin_Repository = Admin_repository;
           faculty_Repository = faculty_repository;
            setting_Of_Specialties_re = setting_of_specialties;
            type_Of_Certificat_Toc_R = Type_of_certificat_toc;
            statues_Of_Addmitoion_Elgibilty_R = statues_of_addmitoion_elgibilty_r;
        }
       
        public ActionResult Index()
        {
            //  Emplolyee e = new Emplolyee { name = "kA", Nick_Name = "dh", Email = "khaledhelwane@gmail.com", Phone_Number =0956};

            var admin = admin_Repository.List();
            
            return View(admin);
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        /// /////////////////////////////////////////////
        //Faculty
        public ActionResult Index_Faulty()
        {
            //Type_of_certificate b = new Type_of_certificate { id = 1, Type = "علمي" };
            //Faculty bb = new Faculty { id = 1, Faculty_name = "Midecn", specialization = "midcen", Type_of_certificate = b };

           var fac= faculty_Repository.List();
            return View(fac);
        }

        public ActionResult Create_Faculty()
        {
            var model = new Fculty_Type_of_toc_ViwModel
            {
                Type_of_certificate_list = FillSelection()
            };
            return View(model);
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_Faculty(Fculty_Type_of_toc_ViwModel model)
        {
           // faculty_Repository.Add(faculty);
            try
            {
                if (model.Type_of_certificate_id == -1)
                {
                    ViewBag.Message = "pleas select an auther";

                    return View(Getallfaculty());

                }
                var toc = type_Of_Certificat_Toc_R.Find(model.Type_of_certificate_id);
                Faculty fac = new Faculty
                {
                    Faculty_name = model.Faculty_name,
                    specialization = model.specialization,
                    Type_of_certificate = toc
                    

                };

                faculty_Repository.Add(fac);
                return RedirectToAction(nameof(Index_Faulty));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit_Fuclty(int id)
        {
            var faculty = faculty_Repository.Find(id);
            var model = new Fculty_Type_of_toc_ViwModel
            { 
                
                Faculty_name = faculty.Faculty_name,
            specialization=faculty.specialization,
                Type_of_certificate_list = FillSelection()
            };
            return View(model);
            
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Fuclty(int id, Fculty_Type_of_toc_ViwModel modle)
        {
            try
            {


                var type = type_Of_Certificat_Toc_R.Find(modle.Type_of_certificate_id);

                Faculty facluty = new Faculty
                {

                    id = modle.id,
                    Faculty_name = modle.Faculty_name,
                    specialization = modle.specialization,
                    Type_of_certificate = type

                };
                faculty_Repository.Update(modle.Type_of_certificate_id, facluty);


                return RedirectToAction(nameof(Index_Faulty));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete_faculty(int id)
        {
            var faculty = faculty_Repository.Find(id);
            var model = new Fculty_Type_of_toc_ViwModel
            {

                Faculty_name = faculty.Faculty_name,
                specialization = faculty.specialization,
                Type_of_certificate_list = FillSelection()
            };
            return View(model);
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_faculty(int id, IFormCollection collection)
        {
           
            try
            {
                faculty_Repository.Delete(id);
                return RedirectToAction(nameof(Index_Faulty));
            }
            catch
            {
                return View();
            }
        }


        //////////////////////////////////////////////////////////////
        /// setting_of_specialties
        public ActionResult Index_setting_of_specialties()
        {
            //  Emplolyee e = new Emplolyee { name = "kA", Nick_Name = "dh", Email = "khaledhelwane@gmail.com", Phone_Number =0956};
            var all = setting_Of_Specialties_re.List().ToList();
            var list_S = new List<setting_of_specialist_ViwModel>();
            var faculty = faculty_Repository.List();
            
             var st_of_AE_LISt = statues_Of_Addmitoion_Elgibilty_R.List();

           
       //     List<statues_of_admission_elgibilty> lisat = new List<statues_of_admission_elgibilty>();
            int max = 0;
            foreach (var item in st_of_AE_LISt)
            {
                if (max < item.id)
                    max = item.id;
            }

            //var rrrr = statues_Of_Addmitoion_Elgibilty_R.Find(max);
             foreach (var item in all) {



                if (item.Stautues_of_admi_eligi.id == max)
                {
                    var L_S_O_S = new setting_of_specialist_ViwModel
                    {
                        id = item.id,
                        Chair_count = item.Chair_count,
                        Minemum_rate = item.Minemum_rate,
                        // faculty_list = faculty.ToList(),
                        faculty_id = item.faculty.id,
                        specialist = faculty_Repository.Find(item.faculty.id).specialization,
                        Status_Of_A_E = statues_Of_Addmitoion_Elgibilty_R.Find(max),
                    };
                    list_S.Add(L_S_O_S);
                }
                //else {
                //    var L_S_O_S = new setting_of_specialist_ViwModel
                //    {
                //        id = item.id,
                //        Chair_count = item.Chair_count,
                //        Minemum_rate = item.Minemum_rate,
                //        // faculty_list = faculty.ToList(),
                //        faculty_id = item.faculty.id,
                //        specialist = faculty_Repository.Find(item.faculty.id).specialization,
                //        Status_Of_A_E = statues_Of_Addmitoion_Elgibilty_R.Find(max),
                //    };

                //    list_S.Add(L_S_O_S);

                //}
                
            
            }
                      

            return View(list_S);
        }

        public ActionResult Create_setting_of_specialties()
        {
            var model = new setting_of_specialist_ViwModel
            {
                faculty_list = FillSelection1()
            };
            return View(model);


          
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_setting_of_specialties(setting_of_specialist_ViwModel model)
        {
          //  setting_Of_Specialties_re.Add(setting_of_specialties1);
            try
            {
                if (model.faculty_id == -1)
                {
                    ViewBag.Message = "pleas select a choice";

                    return View(GetallFaculty_S_o_s());
                }

                var faculty = faculty_Repository.Find(model.faculty_id);
                //to get the last record in stutes of admission elgibilty
                var Listaa = statues_Of_Addmitoion_Elgibilty_R.List();
              
                int max = 0;
                foreach(var item in Listaa)
                {
                    if (max < item.id)
                        max = item.id;
                }

                var S_O_A_E = statues_Of_Addmitoion_Elgibilty_R.Find(max);
                setting_of_specialties s_O_s = new setting_of_specialties
                {
                    
                    Chair_count = model.Chair_count,
                    faculty = faculty,
                    Minemum_rate=model.Minemum_rate,
                    //Semester_Date=model.Semester_Date,
                 //   Semster_no=model.Semster_no
                   Stautues_of_admi_eligi=S_O_A_E
                    
                };
                

                setting_Of_Specialties_re.Add(s_O_s);



                return RedirectToAction(nameof(Index_setting_of_specialties));
            }
            catch
            {
                return View();
            }
        }
             
        public ActionResult Edit_Setting_of_speclaties(int id)
        {
            try
            {
                var fa = setting_Of_Specialties_re.Find(id);
                var model = new setting_of_specialist_ViwModel
                {

                    Chair_count = fa.Chair_count,
                    faculty_list = FillSelection1(),
                    faculty_id = fa.id
                    ,
                    Minemum_rate = fa.Minemum_rate,
                   // Semester_Date = fa.Semester_Date,
                    //Semster_no = fa.Semster_no
                };
                return View(model);
            }
            catch (Exception e) {
                return View();
                    }
           
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Setting_of_speclaties(int id, setting_of_specialist_ViwModel model)
        {
           // setting_Of_Specialties_re.Update(id, collection_S_O_s);
            try
            {

                var faculty = faculty_Repository.Find(model.faculty_id);
         
                setting_of_specialties sos = new setting_of_specialties
                {
                    //Semster_no = model.Semster_no,
                    Chair_count = model.Chair_count,
                    faculty = faculty,
                    Minemum_rate = model.Minemum_rate,
                  //  Semester_Date = model.Semester_Date,
                    id = model.id



                };
                setting_Of_Specialties_re.Update(id,sos);
                return RedirectToAction(nameof(Index_setting_of_specialties));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete_Setting_of_speclaties(int id)
        {

            var fa = setting_Of_Specialties_re.Find(id);
            var model = new setting_of_specialist_ViwModel
            {

                Chair_count = fa.Chair_count,
                faculty_list = FillSelection1(),
                faculty_id = fa.id,
                Minemum_rate = fa.Minemum_rate,
                //Semester_Date = fa.Semester_Date,
               // Semster_no = fa.Semster_no
            };
            return View(model);
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_Setting_of_speclaties(int id, IFormCollection collection)
        {

            try
            {
                setting_Of_Specialties_re.Delete(id);
                return RedirectToAction(nameof(Index_setting_of_specialties));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Index_toc()
        {
            var toc = type_Of_Certificat_Toc_R.List();
            return View(toc);
        }

        public ActionResult Create__toc()
        {
            return View();
        }

       // POST: AdminController/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult Create__toc(Type_of_certificate toc)
        {
            type_Of_Certificat_Toc_R.Add(toc);
            try
            {
                return RedirectToAction(nameof(Index_toc));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit_toc(int id)
        {
            var toc = type_Of_Certificat_Toc_R.Find(id);
            return View(toc);
        }

       // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_toc(int id, Type_of_certificate toc)
        {
            type_Of_Certificat_Toc_R.Update(id, toc);
            try
            {
                return RedirectToAction(nameof(Index_toc));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete_toc(int id)
        {
            var toc = type_Of_Certificat_Toc_R.Find(id);
            return View(toc);

        }

       // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_toc(int id, Type_of_certificate toc)
        {
            type_Of_Certificat_Toc_R.Delete(id);
            try
            {
                return RedirectToAction(nameof(Index_toc));
            }
            catch
            {
                return View();
            }
        }
      
        /// ////////////////////////////////////////////////////////////////////////
        /// Statut_of admiition eligibility
        public ActionResult Index_setting_of_admition_elgibilty()
        {
            //  Emplolyee e = new Emplolyee { name = "kA", Nick_Name = "dh", Email = "khaledhelwane@gmail.com", Phone_Number =0956};

            var all = statues_Of_Addmitoion_Elgibilty_R.List();

            return View(all);
        }

        // GET: AdminController/Details/5
      

        // GET: AdminController/Create
        public ActionResult Create_setting_of_admition_elgibilty()
        {
            
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_setting_of_admition_elgibilty(statues_of_admission_elgibilty collection)
        {
            try
            {
                statues_Of_Addmitoion_Elgibilty_R.Add(collection);
                return RedirectToAction(nameof(Index_setting_of_admition_elgibilty));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit_setting_of_admition_elgibilty(int id)
        {
            var ob = statues_Of_Addmitoion_Elgibilty_R.Find(id);
            return View(ob);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_setting_of_admition_elgibilty(int id, statues_of_admission_elgibilty collection)
        {
            statues_Of_Addmitoion_Elgibilty_R.Update(id,collection);
            try
            {
                return RedirectToAction(nameof(Index_setting_of_admition_elgibilty));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5'
        public ActionResult Delete_setting_of_admition_elgibilty(int id)
        {
            var ob = statues_Of_Addmitoion_Elgibilty_R.Find(id);
            return View(ob);
       
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_setting_of_admition_elgibilty(int id, statues_of_admission_elgibilty collection)
        {
            statues_Of_Addmitoion_Elgibilty_R.Delete(id);
            try
            {
                return RedirectToAction(nameof(Index_setting_of_admition_elgibilty));
            }
            catch
            {
                return View();
            }
        }


        Fculty_Type_of_toc_ViwModel Getallfaculty()
        {

            var vmodel = new Fculty_Type_of_toc_ViwModel
            {

                Type_of_certificate_list= FillSelection()
            };
            return vmodel;
        }
        //to have all the faucltees
        setting_of_specialist_ViwModel GetallFaculty_S_o_s()
        {

            var vmodel = new setting_of_specialist_ViwModel
            {

                faculty_list = FillSelection1()
            };
            return vmodel;
        }


        List<Type_of_certificate> FillSelection()
        {
            var types = type_Of_Certificat_Toc_R.List().ToList();
            types.Insert(0,new Type_of_certificate {id=-1, Type = "-------pleas select auther-------" });
            return (types);

        }
        List<Faculty> FillSelection1()
        {
           // var typ = new Type_of_certificate { id = -1, Type = "ffhh" };
            var types = faculty_Repository.List().ToList();
            const string V = "-------pleas select auther------";
            types.Insert(0, new Faculty { id = -1, Faculty_name = V});
            return types;

        }

    }
}
