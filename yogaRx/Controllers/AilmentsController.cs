using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using yogaRx.Models;

namespace yogaRx.Controllers
{
    public class AilmentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult HeadFilter()
        {
            var ailments = from item in db.Ailments
                           where item.BodyPartID.Contains("Head")
                           select item;



            return View(ailments.ToList());

        }
        // GET: Ailments
        public ActionResult Index(string search)
        
        {
            var ailments = from item in db.Ailments
                           select item;

            // filter
            if (!String.IsNullOrEmpty(search))
            {
                ailments = from item in ailments
                           where item.AilmentName.Contains(search)
                           select item;


            }

            return View(ailments.ToList());
        }



    
        // GET: Ailments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ailment ailment = db.Ailments.Find(id);
            if (ailment == null)
            {
                return HttpNotFound();
            }

            //var firstPose = ailment.Poses.Single(p => p.PoseName == "Child's Pose");
            //var firstPoseRatings = db.Ratings.Where(r => r.PoseId == firstPose.PoseId);
            //double? score = db.Ratings.Where(r => r.PoseId == firstPose.PoseId).Average(r => r.SymbolRating);


            var poses = from p in ailment.Poses
                        let Score = db.Ratings.Where(r => r.PoseId == p.PoseId).Average(r => r.SymbolRating)
                        orderby Score descending
                        select new Pose
                        {
                            PoseId = p.PoseId,
                            PoseName = p.PoseName,
                            PoseDesc = p.PoseDesc,
                            Photo = p.Photo,
                            Photo1 = p.Photo1,
                            //Score = db.Ratings.Where(r => r.PoseId == p.PoseId).Average(r => r.SymbolRating)
                            Score = Score

                        };

            ViewBag.Poses = poses;
            return View(ailment);
        }

        // GET: Ailments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ailments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AilmentId,AilmentName,AilmentDesc")] Ailment ailment)
        {
            if (ModelState.IsValid)
            {
                db.Ailments.Add(ailment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ailment);
        }

        // GET: Ailments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ailment ailment = db.Ailments.Find(id);
            if (ailment == null)
            {
                return HttpNotFound();
            }
            return View(ailment);
        }

        // POST: Ailments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AilmentId,AilmentName,AilmentDesc")] Ailment ailment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ailment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ailment);
        }

        // GET: Ailments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ailment ailment = db.Ailments.Find(id);
            if (ailment == null)
            {
                return HttpNotFound();
            }
            return View(ailment);
        }

        // POST: Ailments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ailment ailment = db.Ailments.Find(id);
            db.Ailments.Remove(ailment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
