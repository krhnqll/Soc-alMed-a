using Microsoft.AspNet.Identity;
using SocıalMedıa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocıalMedıa.Controllers
{
    
    public class HomeController : Controller
    {
        SocıalMedıaEntities1 Db = new SocıalMedıaEntities1();


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BillboardsPage() 
        {
            var BillboardList = from b in Db.Billboard
                                join l in Db.Location
                                on b.Loc_id equals l.Loc_id
                                select new BillplusLocation
                                {
                                    Billboard_id = b.Billboard_id,
                                    Billboard_detail = b.Billboard_detail,
                                    Billboard_height = b.Billboard_height,
                                    Billboard_name = b.Billboard_name,
                                    Billboard_status = b.Billboard_status,
                                    Billboard_width = b.Billboard_width,
                                    Loc_name = l.Loc_name
                                };

            BillplusCus model2 = new BillplusCus
            {
                Billboard_List = BillboardList.ToList(),
            };
            return View(model2);    
        }


        [HttpGet]
        public ActionResult Profile()
        {
            if (Session["Customer"] ==  null)
            {
                return RedirectToAction("Login","Login");
            }
            else
            {
            int customerID = (int)Session["Customer"];

            var cust = Db.Customer.Where(i => i.Cus_id == customerID ) 
                   .Select(i => new CusplusLocation(){
                              Cus_name = i.Cus_name,
                              Cus_surname = i.Cus_surname,
                              Cus_email = i.Cus_email,
                              Cus_phonenumber = i.Cus_phonenumber,
                              username = i.username,
                              password = i.password,
                              Loc_name = i.Location.Loc_name
                   });


            
            BillplusCus model3 = new BillplusCus
            {
                Customer_List = cust.ToList(),
            };
            // UNUTMA..!! KULLANICININ SATIN ALDIĞI PANOLARI DA EKLE
            return View(model3);
            }      
        }

        [HttpGet]

        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult billboardDetail (int id) 
        {
            var bill = Db.Billboard.Where(i => i.Billboard_id == id)
                .Select(i => new BillplusLocation()
                {
                    Billboard_id = i.Billboard_id,
                    Billboard_name = i.Billboard_name,
                    Billboard_height = i.Billboard_height,
                    Billboard_width = i.Billboard_width,
                    Billboard_detail = i.Billboard_detail,
                    Billboard_status = i.Billboard_status,
                    Loc_name = i.Location.Loc_name

                });
            BillplusCus model5 = new BillplusCus
            {
                Billboard_List = bill.ToList(),
            };

            return View(model5);
        }
        /*
         filtreleme
            -size
            -lokasyon
         şehirlere göre listeleme 
        ana ekranda panoların name location size verileri görünecek, detail butonuna basınca tüm veriler gelecek 

         
         */
    }
}
