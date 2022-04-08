using Addmition__Elgibilty_K_A.Model;
using Addmition__Elgibilty_K_A.View_Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly interface_of_crud_operations<Emplolyee> employee_Repository;
        private readonly interface_of_crud_operations<statues_of_student> statues_O_Student_Repo;
        private readonly interface_of_crud_operations<Student> student_Repo;



        // GET: EmployeeController

        public EmployeeController(interface_of_crud_operations<Emplolyee> Employee_repository,
            interface_of_crud_operations<statues_of_student> statues_O_Student_Repo,
            interface_of_crud_operations<Student> student_Repo)
        {
            employee_Repository = Employee_repository;
            this.statues_O_Student_Repo = statues_O_Student_Repo;
            this.student_Repo = student_Repo;
        }

        public ActionResult Index_Main_interface()
        {
            //var list_of_stautes = statues_O_Student_Repo.List();
            //var Employee = employee_Repository.List();
            return View();


        }

        // GET: EmployeeController/Details/5
        //public ActionResult Details(int id)
        //{
        //    var employee = employee_Repository.Find(id);
        //    return View(employee);

        //}

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Emplolyee emplolyee)
        {

            employee_Repository.Add(emplolyee);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = employee_Repository.Find(id);
            return View(employee);

        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Emplolyee employee)
        {
            employee_Repository.Update(id,employee);
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    var employee = employee_Repository.Find(id);
        //    return View(employee);

        //}

        // POST: EmployeeController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, Emplolyee employee)
        //{
        //    employee_Repository.Delete(id);
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        public ActionResult Index_statues_of_student()
        {
            //var Employee = employee_Repository.List();

            var status = statues_O_Student_Repo.List();
            return View(status);
        }
        /*
        public ActionResult Create_statues_of_student()
        {

        //    var st_OF_stu = new Statues_O_Stu_ViewModel {

                Student_list = student_Repo.List().ToList()
              //  ,employee_ID=employee_Repository.
            
            };

            return View(st_OF_stu);
        }
    
        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_statues_of_student(Statues_O_Stu_ViewModel SOS)
        {
            var student_Find = student_Repo.Find(SOS.student_Id);
            var Employee_Find = employee_Repository.Find(SOS.employee_ID);
            var st_of_stu = new statues_of_student {
            Employee_Info=Employee_Find,
            Student_Info=student_Find,
             Date_of_Acshiving=SOS.Date_of_Acshiving,
             Checked_recipet=SOS.Checked_recipet,
             Checked_document=SOS.Checked_document,
             Accept=SOS.Accept
            
            
            
            };

            try
            {
                statues_O_Student_Repo.Add(st_of_stu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    */

        ////////////////////////////////////////////////////////////////////////////////////////////////
        //Syrian
        // GET: EmployeeController/Edit/5
        public ActionResult Index()
        {
            var list_of_stautes = statues_O_Student_Repo.List();
            List<statues_of_student> lista=new List<statues_of_student>();
            foreach (var item in list_of_stautes)
            {
                if (item.Student_Info.high_school_certificate == "Syrian") 
                {
                    lista.Add(item);
                }
            }
            //var Employee = employee_Repository.List();
            return View(lista);


        }
       
        public ActionResult Edit_Status_of_stu(int id)
        { 
            var s_O_s = statues_O_Student_Repo.Find(id);
            var student = s_O_s.Student_Info;
            var a_e_r_s = (admission_ligibility_request_SY)student.A_E_R;
            //var A_E_R_Syrian = new admission_ligibility_request_SY {
            //};
            //var a_e_r_s = student.A_E_R;
            //  var ddddd = new admission_ligibility_request_SY();
            var student_of_staues_vieawmodle = new status_Of_Student_Syrian_viwModel{
            Identity_No=student.Identity_No,
            Home_s_Phone=student.Home_s_Phone,
            gender=student.gender,
            Mother_Name=student.Mother_Name,
            Mobile_Phone=student.Mobile_Phone,
            Nationality=student.Nationality,
            Nick_Name=student.Nick_Name,
            Father_Name=student.Father_Name,
            First_Name=student.First_Name,
            high_school_certificate=student.high_school_certificate,
            Civil_Registrition_No=student.Civil_Registrition_No,
            Birth=student.Birth,
            Civil_Registriation_City=student.Civil_Registriation_City,
            back_image_of_identity_URL=a_e_r_s.back_image_of_identity_URL,
            Checked_document=false,
            Checked_recipet=false,
            check_recipt_image_URL=a_e_r_s.check_recipt_image_URL,
            city_of_high_school_cirtificate=a_e_r_s.city_of_high_school_cirtificate,
             course_number=a_e_r_s.course_number,
            Date_of_Acshiving=DateTime.Now,
            date_of_high_school_cirtificate=a_e_r_s.date_of_high_school_cirtificate,
            front_image_of_identity_URL=a_e_r_s.front_image_of_identity_URL,
            Image_of_crtificat_URL=a_e_r_s.Image_of_crtificat_URL,
            LAnguge_of_the_addmintion=a_e_r_s.LAnguge_of_the_addmintion,
             Subscription_number=a_e_r_s.Subscription_number,
            The_Rate=a_e_r_s.The_Rate
            
            };
            return View(student_of_staues_vieawmodle);

        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Status_of_stu(int id, status_Of_Student_Syrian_viwModel Stut_of_stu_syrian)
        {
            //var st_of_student = statues_O_Student_Repo.Find(Stut_of_stu_syrian.id);
           
            var stutus_of_student = new statues_of_student
            {
                id = Stut_of_stu_syrian.id,
                Checked_document = Stut_of_stu_syrian.Checked_document,
                Checked_recipet=Stut_of_stu_syrian.Checked_recipet,
                Date_of_Acshiving=Stut_of_stu_syrian.Date_of_Acshiving,
               //Employee_Info= we will get it from Authentication form
               //Student_Info= already is placed
               //Accept=put it from algorithm

            };
            statues_O_Student_Repo.Update(id,stutus_of_student);


            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //////////////////////////////////////////////////////////////////
        //unsyrian edition


        public ActionResult Index2unsyrian()
        {
            var list_of_stautes = statues_O_Student_Repo.List();
            List<statues_of_student> lista = new List<statues_of_student>();
            foreach (var item in list_of_stautes)
            {
                if (item.Student_Info.high_school_certificate == "UNSyrian")
                {
                    lista.Add(item);
                }
            }
            //var Employee = employee_Repository.List();
            return View(lista);


        }




        public ActionResult Editunsyrian(int id)
        {
            var s_O_s = statues_O_Student_Repo.Find(id);
            var student = s_O_s.Student_Info;
            var a_e_r_s = student.A_E_R;
            //var A_E_R_Syrian = new admission_ligibility_request_SY {
            //};
            //var a_e_r_s = student.A_E_R;


            //  var ddddd = new admission_ligibility_request_SY();

            var student_of_staues_vieawmodle = new status_Of_Student_Syrian_viwModel
            {
                Identity_No = student.Identity_No,
                Home_s_Phone = student.Home_s_Phone,
                gender = student.gender,
                Mother_Name = student.Mother_Name,
                Mobile_Phone = student.Mobile_Phone,
                Nationality = student.Nationality,
                Nick_Name = student.Nick_Name,
                Father_Name = student.Father_Name,
                First_Name = student.First_Name,
                high_school_certificate = student.high_school_certificate,
                Civil_Registrition_No = student.Civil_Registrition_No,
                Birth = student.Birth,
                Civil_Registriation_City = student.Civil_Registriation_City,
                back_image_of_identity_URL = a_e_r_s.back_image_of_identity_URL,
                Checked_document = false,
                Checked_recipet = false,
                check_recipt_image_URL = a_e_r_s.check_recipt_image_URL,
                city_of_high_school_cirtificate = a_e_r_s.city_of_high_school_cirtificate,
                //       course_number=a_e_r_s.course_number,
                Date_of_Acshiving = DateTime.Now,
                date_of_high_school_cirtificate = a_e_r_s.date_of_high_school_cirtificate,
                front_image_of_identity_URL = a_e_r_s.front_image_of_identity_URL,
                Image_of_crtificat_URL = a_e_r_s.Image_of_crtificat_URL,
                //   LAnguge_of_the_addmintion=a_e_r_s.LAnguge_of_the_addmintion,
                // Subscription_number=a_e_r_s.Subscription_number,
                The_Rate = a_e_r_s.The_Rate  

            };
            return View(student_of_staues_vieawmodle);

        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editunsyrian(int id, status_Of_Student_Syrian_viwModel Stut_of_stu_syrian)
        {
            //var st_of_student = statues_O_Student_Repo.Find(Stut_of_stu_syrian.id);

            var stutus_of_student = new statues_of_student
            {
                id = Stut_of_stu_syrian.id,
                Checked_document = Stut_of_stu_syrian.Checked_document,
                Checked_recipet = Stut_of_stu_syrian.Checked_recipet,
                Date_of_Acshiving = Stut_of_stu_syrian.Date_of_Acshiving,
                //Employee_Info= we will get it from Authentication form
                //Student_Info= already is placed
                //Accept=put it from algorithm

            };
            statues_O_Student_Repo.Update(id, stutus_of_student);


            try
            {

                return RedirectToAction(nameof(Index2unsyrian));
            }
            catch
            {
                return View();
            }
        }

    }
}
