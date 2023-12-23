using SocıalMedıa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace SocıalMedıa.Controllers
{
    public class LoginController : Controller
    {
        SocıalMedıaEntities Db = new SocıalMedıaEntities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Customer(Customer cus) 
        {
             
            var Cus_list = Db.Customer.ToList();
            
            if(ModelState.IsValid) 
            {
                foreach(var item in Cus_list) 
                {
                    if(item.username == cus.username && item.password == cus.password) 
                    {
                        Session["Customer"] =item.Cus_id;
                        return RedirectToAction("",""); // !! TAMAMLA...Kullanıcıyı panoların sayfasına yönlendirecek.
                    }
                    else
                    {
                        ModelState.AddModelError("Key","Invalıd Username Or Password");
                    }
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Admin(Admin admin) 
        {
            
            var Admin_list = Db.Admin.ToList();

            if(ModelState.IsValid) 
            {
                foreach(var item in Admin_list) 
                {
                    if(item.username == admin.username && item.password == admin.password)
                    {
                        Session["Admin"] =item.Admin_id;
                        return RedirectToAction("AdminPage","Function"); //TAMAMLA!!...Admini direkt admin paneline yönlendir.
                    }
                    else
                    {
                        ModelState.AddModelError("Key", "Invalıd Username Or Password");
                    }
                }
            }
            
            return View();
        }
        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Customer()
        {
            return View();
        }

        [HttpGet]

        public ActionResult Cus_Register() 
        {
            return View();
        }
        /*
        [HttpPost]

        public ActionResult Cus_Register(Customer cus)
        {
            Customer ekle = new Customer {
                Cus_name = cus.Cus_name,
                Cus_surname = cus.Cus_surname,
                Cus_email = cus.Cus_email,
                Cus_phonenumber = cus.Cus_phonenumber,
                
                };
            Db.Customer.Add(ekle);
            Db.SaveChanges();
            
            return View();
        }*/
    }
}