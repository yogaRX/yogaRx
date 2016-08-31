﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yogaRx.Models;

namespace yogaRx.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Index()
        {
           ViewBag.AilList = from item in db.Ailments
            orderby item.AilmentName ascending
            select item; 

            //ViewBag.AilList = db.Ailments.ToList();
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}