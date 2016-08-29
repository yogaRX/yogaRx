﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yogaRx.Models;

namespace yogaRx.Controllers
{
 
        public class FileController : Controller
        {
            private ApplicationDbContext db = new ApplicationDbContext();

            // GET: File
            public ActionResult Index(int id)
            {
                var fileToRetrieve = db.Users.Find(id);

                if (fileToRetrieve.PhotoBytes != null && fileToRetrieve.PhotoType != null)
                    return File(fileToRetrieve.PhotoBytes, fileToRetrieve.PhotoType);

                return View();
            }
        }
    
}