using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalGroupProjectTeam8.Models;

namespace FinalGroupProjectTeam8.Controllers
{
    public class BankUsersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: BankUsers
        public ActionResult Index()
        {
            return View(db.BankUsers.ToList());
        }

        // GET: BankUsers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankUser bankUser = db.BankUsers.Find(id);
            if (bankUser == null)
            {
                return HttpNotFound();
            }
            return View(bankUser);
        }

        // GET: BankUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BankUserID,UserType,FirstName,MiddleInitial,EmailAddress,Password,PhoneNumber,Birthday,Street,City,State,Zip")] BankUser bankUser)
        {
            if (ModelState.IsValid)
            {
                db.BankUsers.Add(bankUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bankUser);
        }

        // GET: BankUsers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankUser bankUser = db.BankUsers.Find(id);
            if (bankUser == null)
            {
                return HttpNotFound();
            }
            return View(bankUser);
        }

        // POST: BankUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BankUserID,UserType,FirstName,MiddleInitial,EmailAddress,Password,PhoneNumber,Birthday,Street,City,State,Zip")] BankUser bankUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bankUser);
        }

        // GET: BankUsers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankUser bankUser = db.BankUsers.Find(id);
            if (bankUser == null)
            {
                return HttpNotFound();
            }
            return View(bankUser);
        }

        // POST: BankUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BankUser bankUser = db.BankUsers.Find(id);
            db.BankUsers.Remove(bankUser);
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
