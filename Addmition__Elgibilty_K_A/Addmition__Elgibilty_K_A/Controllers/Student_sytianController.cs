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
    public class Student_sytianController : Controller
    {
        private readonly interface_of_crud_operations<admission_ligibility_request_SY> addmitin_Elgbility_Sy_Re;
        private readonly interface_of_crud_operations<Wishess> wishes_Repository;
        private readonly interface_of_crud_operations<Faculty> faculty_Re;
        private readonly interface_of_crud_operations<Student> student_Sy_Re;
        private readonly interface_of_crud_operations<statues_of_student> stutes_Ofstudent_Repo;
        private readonly interface_of_crud_operations<Acceptaple_Config> accept_Con_Repo;
        private readonly IHostingEnvironment hosting_;



        // GET: Student_sytianController
        public Student_sytianController(interface_of_crud_operations<admission_ligibility_request_SY> addmitin_elgbility_sy_re,
             interface_of_crud_operations<Wishess> wishes_repository,
              interface_of_crud_operations<Faculty> faculty_re,
              interface_of_crud_operations<Student> Student_sy_re,
              interface_of_crud_operations<statues_of_student> stutes_Ofstudent_Repo,
              interface_of_crud_operations<Acceptaple_Config> accept_con_repo,
              IHostingEnvironment hosting_)
        {

            addmitin_Elgbility_Sy_Re = addmitin_elgbility_sy_re;
            wishes_Repository = wishes_repository;
            faculty_Re = faculty_re;
            student_Sy_Re = Student_sy_re;
            this.stutes_Ofstudent_Repo = stutes_Ofstudent_Repo;
            accept_Con_Repo = accept_con_repo;
            this.hosting_ = hosting_;
        }
        public ActionResult Index()
        {
            var stu = student_Sy_Re.List();
            List<Student> lista = new List<Student>();
            foreach (var item in stu)
            {
                if (item.high_school_certificate == "Syrian")
                {
                    lista.Add(item);
                }
            }
            //var Employee = employee_Repository.List();
            return View(lista);


        }

        // GET: Student_sytianController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Student_sytianController/Create
        public ActionResult Create()
        {
            var modle = new Student_Syrian_AER_viewmodle
            {
                faculties = FillSelection()
            };
            return View(modle);
        }

        // POST: Student_sytianController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student_Syrian_AER_viewmodle collection)
        {

            
                string filenameIMa = string.Empty;
                if (collection.Image_of_crtificat_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameIMa = collection.Identity_No.ToString() + collection.Image_of_crtificat_URL.FileName;
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
                    wish_faculty3 = faculty_Re.Find(collection.wish_faculty_Id3)
                };
                var a_e_r = new admission_ligibility_request_SY
                {
                    back_image_of_identity_URL = filenameBack,
                    check_recipt_image_URL = filenameCheck,
                    city_of_high_school_cirtificate = collection.city_of_high_school_cirtificate,
                    date_of_high_school_cirtificate = collection.date_of_high_school_cirtificate,
                    front_image_of_identity_URL = filenameFront,
                    Image_of_crtificat_URL = filenameIMa,
                    The_Rate = collection.The_Rate,
                    type_of_cirtificate_sy_or_forighn = collection.type_of_cirtificate_sy_or_forighn,
                    //wishes = wish,
                    course_number = collection.course_number,
                    LAnguge_of_the_addmintion = collection.LAnguge_of_the_addmintion,
                    Subscription_number = collection.Subscription_number

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

                try
                {

                    //wishes_Repository.Add(wish);
                    // addmitin_Elgbility_Sy_Re.Add(a_e_r);
                    student_Sy_Re.Add(student);

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
                catch
                {
                    return View();
                }
            }

        // GET: Student_sytianController/Edit/5
            public ActionResult Edit(int id)
            {
                var collection = student_Sy_Re.Find(id);
                var b = addmitin_Elgbility_Sy_Re.Find(collection.A_E_R.id);
                var wish = wishes_Repository.Find(collection.wishess.id);

                var modell = new Student_Syrian_AER_viewmodle
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
                    //front_image_of_identity_URL = collection.A_E_R.front_image_of_identity_URL,
                    //Image_of_crtificat_URL = collection.A_E_R.Image_of_crtificat_URL,
                    The_Rate = collection.A_E_R.The_Rate,
                    type_of_cirtificate_sy_or_forighn = collection.A_E_R.type_of_cirtificate_sy_or_forighn,
                    wish_faculty_Id1 = wish.wish_faculty1.id,
                    wish_faculty_Id2 = wish.wish_faculty2.id,
                    wish_faculty_Id3 = wish.wish_faculty3.id,
                    faculties = FillSelection()
                    , course_number = b.course_number,
                    LAnguge_of_the_addmintion = b.LAnguge_of_the_addmintion,
                    Subscription_number = b.Subscription_number,
                    ImageUrl_Back = collection.A_E_R.back_image_of_identity_URL,
                    ImageUrl_Check = collection.A_E_R.check_recipt_image_URL,
                    ImageUrl_Front = collection.A_E_R.front_image_of_identity_URL,
                    ImageUrl_Image = collection.A_E_R.Image_of_crtificat_URL


                };

                return View(modell);
            }

            // POST: Student_sytianController/Edit/5

            [HttpPost]
            [ValidateAntiForgeryToken]

            public ActionResult Edit(int id, Student_Syrian_AER_viewmodle collection)
            {
                try {
                //var stu = student_Sy_Re.Find(collection.id);

                //  var b = stu.A_E_R;
                //     var b = addmitin_Elgbility_Sy_Re.Find(stu.A_E_R.id);
                //
                //  var w = wishes_Repository.Find(b.wishes.id);

                string filenameIMa = string.Empty;
                if (collection.Image_of_crtificat_URL != null)
                {
                    string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                    filenameIMa = collection.Identity_No.ToString() + collection.Image_of_crtificat_URL.FileName;
                    string fullpath = Path.Combine(uploads, filenameIMa);
                    //delete Old File

                    string oldFileName = collection.ImageUrl_Image;
                    string fullOldPath = Path.Combine(uploads, oldFileName);
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
                    filenameFront = collection.Identity_No.ToString() + collection.front_image_of_identity_URL.FileName;
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
                    filenameBack = collection.Identity_No.ToString() + collection.back_image_of_identity_URL.FileName;
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
                        id = id,
                        wish_faculty1 = faculty_Re.Find(collection.wish_faculty_Id1),
                        wish_faculty2 = faculty_Re.Find(collection.wish_faculty_Id2),
                        wish_faculty3 = faculty_Re.Find(collection.wish_faculty_Id3),
                        StudentId = id
                    };
                    var a_e_r = new admission_ligibility_request_SY
                    {
                        id = id,
                        back_image_of_identity_URL = collection.ImageUrl_Back,
                        check_recipt_image_URL = collection.ImageUrl_Check,
                        city_of_high_school_cirtificate = collection.city_of_high_school_cirtificate,
                        date_of_high_school_cirtificate = collection.date_of_high_school_cirtificate,
                        front_image_of_identity_URL = collection.ImageUrl_Front,
                        Image_of_crtificat_URL = collection.ImageUrl_Image,
                        The_Rate = collection.The_Rate,
                        type_of_cirtificate_sy_or_forighn = collection.type_of_cirtificate_sy_or_forighn,
                        //wishes = wish,
                        course_number = collection.course_number,
                        LAnguge_of_the_addmintion = collection.LAnguge_of_the_addmintion,
                        Subscription_number = collection.Subscription_number,
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
                        Passport_No = collection.Passport_No,
                        //    A_E_R = a_e_r
                    };
                    wishes_Repository.Update(id, wish);
                    addmitin_Elgbility_Sy_Re.Update(id, a_e_r);
                    student_Sy_Re.Update(id, student);
                    return RedirectToAction(nameof(Index));

                }

                catch (Exception E)
                {
                    return View();
                }
            }

            // GET: Student_sytianController/Delete/5
            //public ActionResult Delete(int id)
            //{
            //    return View();
            //}

            //// POST: Student_sytianController/Delete/5
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
                types.Insert(0, new Faculty { id = -1, Faculty_name = "-------Pleas faculty------" });
                return (types);

            }


        }
    } 
