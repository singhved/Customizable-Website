using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SecondWeb.Models;

namespace SecondWeb.Controllers
{
    public class TheTeamsController : Controller
    {
        private Context db = new Context();

        // GET: TheTeams
        public ActionResult Index()
        {
            return View(db.TheTeam.ToList());
        }

        // GET: TheTeams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheTeam theTeam = db.TheTeam.Find(id);
            if (theTeam == null)
            {
                return HttpNotFound();
            }
            return View(theTeam);
        }

        // GET: TheTeams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TheTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Position,Details")] TheTeam theTeam)
        {
            if (ModelState.IsValid)
            {
                db.TheTeam.Add(theTeam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(theTeam);
        }

        // GET: TheTeams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheTeam theTeam = db.TheTeam.Find(id);
            if (theTeam == null)
            {
                return HttpNotFound();
            }
            return View(theTeam);
        }

        // POST: TheTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Position,Details")] TheTeam theTeam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theTeam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theTeam);
        }

        // GET: TheTeams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheTeam theTeam = db.TheTeam.Find(id);
            if (theTeam == null)
            {
                return HttpNotFound();
            }
            return View(theTeam);
        }

        // POST: TheTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TheTeam theTeam = db.TheTeam.Find(id);
            db.TheTeam.Remove(theTeam);
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
