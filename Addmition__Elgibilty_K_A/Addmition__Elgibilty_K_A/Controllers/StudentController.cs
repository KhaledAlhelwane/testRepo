using Addmition__Elgibilty_K_A.Model;
using Addmition__Elgibilty_K_A.View_Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Addmition__Elgibilty_K_A.Controllers
{
    public class StudentController : Controller
    {
        private readonly interface_of_crud_operations<Student> student_Repositoriy;
        private readonly interface_of_crud_operations<Wishess> wishes_Repository;
        private readonly interface_of_crud_operations<admission_eligibility_request> addmition_Elgibility_Requst_Re;
        private readonly interface_of_crud_operations<Faculty> faculty_Re;
        private readonly interface_of_crud_operations<statues_of_student> stutes_Ofstudent_Repo;
        private readonly interface_of_crud_operations<Acceptaple_Config> accept_Con_Repo;
        private readonly IHostingEnvironment hosting_;

        // GET: StudentController

        public StudentController(interface_of_crud_operations<Student> Student_repository
            , interface_of_crud_operations<Wishess> wishes_repository
            , interface_of_crud_operations<admission_eligibility_request> addmition_elgibility_requst_re,
            interface_of_crud_operations<Faculty> faculty_re
            , interface_of_crud_operations<statues_of_student> Stutes_ofstudent_repo,
            interface_of_crud_operations<Acceptaple_Config> Accept_con_repo,
            IHostingEnvironment hosting_ )

        {
            student_Repositoriy = Student_repository;
            wishes_Repository = wishes_repository;
            addmition_Elgibility_Requst_Re = addmition_elgibility_requst_re;
            faculty_Re = faculty_re;
            stutes_Ofstudent_Repo = Stutes_ofstudent_repo;
            accept_Con_Repo = Accept_con_repo;
            this.hosting_ = hosting_;
        }
        public ActionResult Index()
        {
            var stu = student_Repositoriy.List();
            List<Student> lista = new List<Student>();
            foreach (var item in stu)
            {
                if (item.high_school_certificate == "UNSyrian")
                {
                    lista.Add(item);
                }
            }
            //var Employee = employee_Repository.List();
            return View(lista);

           
        }

        // GET: StudentController/Details/5
        //public ActionResult Details(int id)
        //{
        //    var studentlist = student_Repositoriy.List();

        //    return View(studentlist);
        //}

        // GET: StudentController/Create
        public ActionResult Create()
        {
            var model = new student_elr_wish_ViewModel
            {
                faculties = FillSelection()
            };
            return View(model);


        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(student_elr_wish_ViewModel collection)
        {
            try {
                string filenameIMa = string.Empty;
                if (collection.Image_of_crtificat_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameIMa = collection.Identity_No.ToString()+collection.Image_of_crtificat_URL.FileName;
                    string fullpath = Path.Combine(uploads, filenameIMa);
                    collection.Image_of_crtificat_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                }
                string filenameFront = string.Empty;
                if (collection.front_image_of_identity_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameFront = collection.Identity_No.ToString() + collection.front_image_of_identity_URL.FileName;
                    string fullpath = Path.Combine(uploads, filenameFront);
                    collection.front_image_of_identity_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                }
                string filenameBack = string.Empty;
                if (collection.back_image_of_identity_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameBack = collection.Identity_No.ToString() + collection.back_image_of_identity_URL.FileName;
                    string fullpath = Path.Combine(uploads, filenameBack);
                    collection.back_image_of_identity_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                }

                string filenameCheck = string.Empty;
                if (collection.check_recipt_image_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameCheck = collection.Identity_No.ToString() + collection.check_recipt_image_URL.FileName;
                    string fullpath = Path.Combine(uploads, filenameCheck);
                    collection.check_recipt_image_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                }



                var wish = new Wishess
                {
                    wish_faculty1 = faculty_Re.Find(collection.wish_faculty_Id1),
                    wish_faculty2 = faculty_Re.Find(collection.wish_faculty_Id2),
                    wish_faculty3 = faculty_Re.Find(collection.wish_faculty_Id3),

                };

                var a_e_r = new admission_eligibility_request
                { back_image_of_identity_URL = filenameBack,
                    check_recipt_image_URL = filenameCheck,
                    city_of_high_school_cirtificate = collection.city_of_high_school_cirtificate,
                    date_of_high_school_cirtificate = collection.date_of_high_school_cirtificate,
                    front_image_of_identity_URL = filenameFront,
                    Image_of_crtificat_URL = filenameIMa,
                    The_Rate = collection.The_Rate,
                    type_of_cirtificate_sy_or_forighn = collection.type_of_cirtificate_sy_or_forighn,
                    //student_Info = student_Repositoriy.Find(collection.id)
                    //wishes = wish
                };
                var student = new Student
                {
                    Birth = collection.Birth,
                    Blood_Type = collection.Blood_Type,
                    Civil_Registriation_City = collection.Civil_Registriation_City,
                    Civil_Registrition_No = collection.Civil_Registrition_No,
                    Current_Address = collection.Current_Address,
                    Email = collection.Email,
                    Father_Name = collection.Father_Name,
                    First_Name = collection.First_Name,
                    Full_Address = collection.Full_Address,
                    gender = collection.gender,
                    high_school_certificate = collection.high_school_certificate,
                    Home_s_Phone = collection.Home_s_Phone,
                    Identity_No = collection.Identity_No,
                    Marital_status = collection.Marital_status,
                    Mobile_Phone = collection.Mobile_Phone,
                    Mother_Name = collection.Mother_Name,
                    Nationality = collection.Nationality,
                    Nick_Name = collection.Nick_Name,
                    Passport_No = collection.Passport_No,
                    A_E_R = a_e_r,
                    wishess = wish
                };


                student_Repositoriy.Add(student);
                //wishes_Repository.Add(wish);
                //addmition_Elgibility_Requst_Re.Add(a_e_r);
                var statues_of_student = new statues_of_student
                {
                    Accept = false,
                    Checked_document = false,
                    Checked_recipet = false,
                    Student_Info = student
                };
                stutes_Ofstudent_Repo.Add(statues_of_student);

                var accepteble_con = new Acceptaple_Config
                {
                    Accept = false,
                    Acceptable_wishes = null,
                    Student_Info = student
                };
                accept_Con_Repo.Add(accepteble_con);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
           
           Student collection = student_Repositoriy.Find(id);
            var wish = wishes_Repository.Find(collection.wishess.id);
           // admission_eligibility_request b = addmition_Elgibility_Requst_Re.Find(collection.A_E_R.id);
            //var faclt1 = from s in Faculty
            //             where s.id =b.wishes.id
            //            select fa

          //  Wishess w = wishes_Repository.Find(b.wishes.);
            try
            {
                // var A_E_R_ID = collection.A_E_R == null ? collection.A_E_R.id = 0 : collection.A_E_R.id;

                var modell = new student_elr_wish_ViewModel
                {
                    Birth = collection.Birth,
                    Blood_Type = collection.Blood_Type,
                    Civil_Registriation_City = collection.Civil_Registriation_City,
                    Civil_Registrition_No = collection.Civil_Registrition_No,
                    Current_Address = collection.Current_Address,
                    Email = collection.Email,
                    Father_Name = collection.Father_Name,
                    First_Name = collection.First_Name,
                    Full_Address = collection.Full_Address,
                    gender = collection.gender,
                    high_school_certificate = collection.high_school_certificate,
                    Home_s_Phone = collection.Home_s_Phone,
                    Identity_No = collection.Identity_No,
                    Marital_status = collection.Marital_status,
                    Mobile_Phone = collection.Mobile_Phone,
                    Mother_Name = collection.Mother_Name,
                    Nationality = collection.Nationality,
                    Nick_Name = collection.Nick_Name,
                    Passport_No = collection.Passport_No,
                    //back_image_of_identity_URL = collection.A_E_R.back_image_of_identity_URL,
                    //check_recipt_image_URL = collection.A_E_R.check_recipt_image_URL,
                    city_of_high_school_cirtificate = collection.A_E_R.city_of_high_school_cirtificate,
                    date_of_high_school_cirtificate = collection.A_E_R.date_of_high_school_cirtificate,
                   // front_image_of_identity_URL = collection.A_E_R.front_image_of_identity_URL,
                    //Image_of_crtificat_URL = collection.A_E_R.Image_of_crtificat_URL,
                    The_Rate = collection.A_E_R.The_Rate,
                    type_of_cirtificate_sy_or_forighn = collection.A_E_R.type_of_cirtificate_sy_or_forighn,
                    wish_faculty_Id1 = wish.wish_faculty1.id,
                    wish_faculty_Id2 = wish.wish_faculty2.id,
                    wish_faculty_Id3 = wish.wish_faculty3.id,
                    faculties = FillSelection(),
                    ImageUrl_Back = collection.A_E_R.back_image_of_identity_URL,
                    ImageUrl_Check=collection.A_E_R.check_recipt_image_URL,
                    ImageUrl_Front=collection.A_E_R.front_image_of_identity_URL,
                    ImageUrl_Image=collection.A_E_R.Image_of_crtificat_URL
                };
                return View(modell);

            }
            catch (Exception e) { }
            return View();
        }


        // POST: StudentController/Edit/5
            [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, student_elr_wish_ViewModel collection)
        {
            try
            {
                //    var stu = student_Repositoriy.Find(collection.id);
                //    var wish_w = wishes_Repository.Find(stu.wishess.id);
                //    var A_E_R = addmition_Elgibility_Requst_Re.Find(stu.A_E_R.id);
                //    //  var b = stu.A_E_R;
                //var b = addmitin_Elgbility_Sy_Re.Find(stu.A_E_R.id);
                //
                //  var w = wishes_Repository.Find(b.wishes.id);

                string filenameIMa = string.Empty;
                if (collection.Image_of_crtificat_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameIMa = collection.Identity_No.ToString() + collection.Image_of_crtificat_URL.FileName ;
                    string fullpath = Path.Combine(uploads, filenameIMa);
                    //delete Old File

                    string oldFileName = collection.ImageUrl_Image;
                    string fullOldPath = Path.Combine(uploads,oldFileName);
                    if (fullpath != fullOldPath)
                    {
                        System.IO.File.Delete(fullOldPath);
                        //save new image
                        collection.ImageUrl_Image = filenameIMa;
                        collection.Image_of_crtificat_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }
                }
                string filenameFront = string.Empty;
                if (collection.front_image_of_identity_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameFront = collection.Identity_No.ToString() + collection.front_image_of_identity_URL.FileName ;
                    string fullpath = Path.Combine(uploads, filenameFront);

                    string oldFileName = collection.ImageUrl_Front;
                    string fullOldPath = Path.Combine(uploads, oldFileName);
                    if (fullpath != fullOldPath)
                    {
                        System.IO.File.Delete(fullOldPath);
                        //save new image
                        collection.ImageUrl_Front = filenameFront;
                        collection.front_image_of_identity_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }




                }
                string filenameBack = string.Empty;
                if (collection.back_image_of_identity_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameBack = collection.Identity_No.ToString() + collection.back_image_of_identity_URL.FileName ;
                    string fullpath = Path.Combine(uploads, filenameBack);

                    string oldFileName = collection.ImageUrl_Back;
                    string fullOldPath = Path.Combine(uploads, oldFileName);
                    if (fullpath != fullOldPath)
                    {
                        System.IO.File.Delete(fullOldPath);
                        //save new image
                        collection.ImageUrl_Back = filenameBack;
                        collection.back_image_of_identity_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }


                }
                string filenameCheck = string.Empty;
                if (collection.check_recipt_image_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameCheck = collection.Identity_No.ToString() + collection.check_recipt_image_URL.FileName;
                    string fullpath = Path.Combine(uploads, filenameCheck);

                    string oldFileName = collection.ImageUrl_Check;
                    string fullOldPath = Path.Combine(uploads, oldFileName);
                    if (fullpath != fullOldPath)
                    {
                        System.IO.File.Delete(fullOldPath);
                        collection.ImageUrl_Check = filenameCheck;
                        //save new image
                        collection.check_recipt_image_URL.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }

                }



                var wish = new Wishess
                {
                   // StudentId=wish_w.student_Info.Id,
                   // id = wish_w.student_Info.wishess.id,
                   id=id,
                    wish_faculty1 = faculty_Re.Find(collection.wish_faculty_Id1),
                    wish_faculty2 = faculty_Re.Find(collection.wish_faculty_Id2),
                    wish_faculty3 = faculty_Re.Find(collection.wish_faculty_Id3)
                    //student_Info=stu
                    ,StudentId=id
                };
                var a_e_r = new admission_eligibility_request
                {
                    //id =wish_w.student_Info.A_E_R.id ,
                    id= id,
                    back_image_of_identity_URL = collection.ImageUrl_Back,
                    check_recipt_image_URL = collection.ImageUrl_Check,
                    city_of_high_school_cirtificate = collection.city_of_high_school_cirtificate,
                    date_of_high_school_cirtificate = collection.date_of_high_school_cirtificate,
                    front_image_of_identity_URL = collection.ImageUrl_Front,
                    Image_of_crtificat_URL = collection.ImageUrl_Image,
                    The_Rate = collection.The_Rate,
                    type_of_cirtificate_sy_or_forighn = collection.type_of_cirtificate_sy_or_forighn,
                    //student_Info=stu,
                    StudentId = id

                };
                var student = new Student
                {

                    Id = id,
                    Birth = collection.Birth,
                    Blood_Type = collection.Blood_Type,
                    Civil_Registriation_City = collection.Civil_Registriation_City,
                    Civil_Registrition_No = collection.Civil_Registrition_No,
                    Current_Address = collection.Current_Address,
                    Email = collection.Email,
                    Father_Name = collection.Father_Name,
                    First_Name = collection.First_Name,
                    Full_Address = collection.Full_Address,
                    gender = collection.gender,
                    high_school_certificate = collection.high_school_certificate,
                    Home_s_Phone = collection.Home_s_Phone,
                    Identity_No = collection.Identity_No,
                    Marital_status = collection.Marital_status,
                    Mobile_Phone = collection.Mobile_Phone,
                    Mother_Name = collection.Mother_Name,
                    Nationality = collection.Nationality,
                    Nick_Name = collection.Nick_Name,
                    Passport_No = collection.Passport_No
                    //A_E_R = a_e_r,
                    //wishess=wish
                };
                addmition_Elgibility_Requst_Re.Update(id, a_e_r);
                wishes_Repository.Update(id,wish);
                student_Repositoriy.Update(id, student);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: StudentController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        List<Faculty> FillSelection()
        {
            var types = faculty_Re.List().ToList();
            types.Insert(0, new Faculty { id = -1, Faculty_name = "-------pleas select auther-------" });
            return (types);

        }
    }
}
