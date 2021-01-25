using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_Otomation.Models;

namespace Hotel_Otomation.Areas.AdminPage.Controllers
{
    public class GalleriesController : Controller
    {
        private Hotel_2019_DbEntities db = new Hotel_2019_DbEntities();

        // GET: AdminPage/Galleries
        public ActionResult Index()
        {
            return View(db.Galleries.ToList());
        }

        // GET: AdminPage/Galleries/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galleries galleries = db.Galleries.Find(id);
            if (galleries == null)
            {
                return HttpNotFound();
            }
            return View(galleries);
        }

        // GET: AdminPage/Galleries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPage/Galleries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GalleryId,ImageUrl,IsActive")] Galleries galleries)
        {
            if (ModelState.IsValid)
            {
                db.Galleries.Add(galleries);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(galleries);
        }

        // GET: AdminPage/Galleries/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galleries galleries = db.Galleries.Find(id);
            if (galleries == null)
            {
                return HttpNotFound();
            }
            return View(galleries);
        }

        // POST: AdminPage/Galleries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GalleryId,ImageUrl,IsActive")] Galleries galleries)
        {
            if (ModelState.IsValid)
            {
                db.Entry(galleries).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(galleries);
        }

        // GET: AdminPage/Galleries/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Galleries galleries = db.Galleries.Find(id);
            if (galleries == null)
            {
                return HttpNotFound();
            }
            return View(galleries);
        }

        // POST: AdminPage/Galleries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Galleries galleries = db.Galleries.Find(id);
            db.Galleries.Remove(galleries);
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
