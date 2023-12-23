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
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BillboardsPage() 
        {
            return View();    
        }

        [HttpGet]

        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Billboard_ListPage() 
        { 
            return View();
        }


    }
}