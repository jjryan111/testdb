using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Views
{
    public class Test_Tri_LevelController : Controller
    {
        private TestEntities db = new TestEntities();

        // GET: Test_Tri_Level
        public ActionResult Index()
        {
            return View(db.Test_Tri_Level.ToList());
        }

        // GET: Test_Tri_Level/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test_Tri_Level test_Tri_Level = db.Test_Tri_Level.Find(id);
            if (test_Tri_Level == null)
            {
                return HttpNotFound();
            }
            return View(test_Tri_Level);
        }

        // GET: Test_Tri_Level/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test_Tri_Level/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Category,SubCategory,SubSubCategory")] Test_Tri_Level test_Tri_Level)
        {
            if (ModelState.IsValid)
            {
                db.Test_Tri_Level.Add(test_Tri_Level);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(test_Tri_Level);
        }

        // GET: Test_Tri_Level/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test_Tri_Level test_Tri_Level = db.Test_Tri_Level.Find(id);
            if (test_Tri_Level == null)
            {
                return HttpNotFound();
            }
            return View(test_Tri_Level);
        }

        // POST: Test_Tri_Level/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Category,SubCategory,SubSubCategory")] Test_Tri_Level test_Tri_Level)
        {
            if (ModelState.IsValid)
            {
                db.Entry(test_Tri_Level).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(test_Tri_Level);
        }

        // GET: Test_Tri_Level/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test_Tri_Level test_Tri_Level = db.Test_Tri_Level.Find(id);
            if (test_Tri_Level == null)
            {
                return HttpNotFound();
            }
            return View(test_Tri_Level);
        }

        // POST: Test_Tri_Level/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Test_Tri_Level test_Tri_Level = db.Test_Tri_Level.Find(id);
            db.Test_Tri_Level.Remove(test_Tri_Level);
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
