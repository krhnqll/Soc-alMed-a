using SocıalMedıa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.SqlClient;

namespace SocıalMedıa.Controllers
{
    public class FunctionController : Controller
    {
        SocıalMedıaEntities Db = new SocıalMedıaEntities();
        // GET: Function
        public ActionResult Index()
        {
            return View();
        }

        //Kullanıcı ve pano listeleme ekranı 
        [HttpGet]
        public ActionResult AdminPage()
        {
     
            var CustomerList = Db.Customer.ToList();
            var BillboardList = Db.Billboard.ToList();

            BillplusCus Model = new BillplusCus
            {
               
                Customer_List = CustomerList.ToList(),
                Billboard_List = BillboardList.ToList(),
                
               
            };
               
            return View(Model);
        }

        // Pano Ekleme Kısmı
        [HttpPost]
        public ActionResult AddBillboard(Billboard bill_new)
        {
            Billboard ekle = new Billboard {
                Billboard_name = bill_new.Billboard_name,
                Billboard_detail = bill_new.Billboard_detail,
                Billboard_status = bill_new.Billboard_status,
                Billboard_height = bill_new.Billboard_height,
                Billboard_width = bill_new.Billboard_width,
                
               
            };
            Db.Billboard.Add(ekle);
            Db.SaveChanges();
            ViewBag.sonuc = "Ekleme Başarılı.";

            return View();
        }

        
        // Pano düzenleme kısmı
        [HttpGet]
        public ActionResult EditBillboard(int id)
        {
            var data = Db.Billboard.Find(id);

            if(data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        [HttpPost]
        public ActionResult EditBillboard(Billboard model1)
        {
            if (ModelState.IsValid)
            {
                Db.Entry(model1).State = EntityState.Modified;
                Db.SaveChanges();
                ViewBag.sonuc = "Değişiklikler Kaydedildi.";
                return RedirectToAction("AdminPage");
            }
            return View(model1);
        }

        //Customer düzenleme kısmı 

        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            var data = Db.Customer.Find(id);

            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        [HttpPost]
        public ActionResult EditCustomer(Customer model1)
        {
            if(ModelState.IsValid)
            {
                Db.Entry(model1).State = EntityState.Modified;
                Db.SaveChanges();
                ViewBag.sonuc = "Değişiklikler Kaydedildi.";
                return RedirectToAction("AdminPage");
            }
            return View(model1);
        }

        //Billboard Silme kısmı
        public ActionResult DeleteBillboard(int? id)
        {        
            var Billboard_data = Db.Billboard.Find(id);
            Db.Billboard.Remove(Billboard_data);
            Db.SaveChanges();

            return RedirectToAction("AdminPage");
        }

        // Kullanıcı silme kısmı
        public ActionResult DeleteCustomer(int? id) 
        {
            var Customer_data = Db.Customer.Find(id);
            Db.Customer.Remove(Customer_data);
            Db.SaveChanges();

            return RedirectToAction("AdminPage");
        }

        // Kullanıcı ekleme kısmı
        [HttpPost]
        public ActionResult AddCustomer(Customer new_cus)
        {
            Customer ekle = new Customer {
                Cus_name = new_cus.Cus_name,
                Cus_surname = new_cus.Cus_surname,
                Cus_email = new_cus.Cus_email,
                Cus_phonenumber = new_cus.Cus_phonenumber,
                username = new_cus.username,
                password = new_cus.password,
                Loc_id = new_cus.Loc_id
                
            };
            Db.Customer.Add(ekle);
            Db.SaveChanges();
            ViewBag.sonuc = "Ekleme Başarılı.";
            return View();
        }
        [HttpGet]
        public ActionResult AddBillboard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        public ActionResult Location_getir(BillplusCus billplus)
        {
            int locid = billplus.location.Loc_id;
            Location location = Db.Location.FirstOrDefault(x => x.Loc_id == locid);

            billplus.location = location;

            return View(billplus);
        }
    }
}