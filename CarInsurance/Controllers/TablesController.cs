using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance;

namespace Controllers
{
    public class TablesController : System.Web.Mvc.Controller
    {
        private Models db = new Models();

        // GET: Tables
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Tables/Details/5
        public ActionResult Details(int? id)
        {
            if (Information.IsNothing(id))
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Table table = db.Tables.Find(id);
            if (IsNothing(table))
                return HttpNotFound();
            return View(table);
        }

        // GET: Tables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Tables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (Information.IsNothing(id))
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Table table = db.Tables.Find(id);
            if (IsNothing(table))
                return HttpNotFound();
            return View(table);
        }

        // POST: Tables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Tables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (Information.IsNothing(id))
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Table table = db.Tables.Find(id);
            if (IsNothing(table))
                return HttpNotFound();
            return View(table);
        }

        // POST: Tables/Delete/5
        [HttpPost()]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken()]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if ((disposing))
                db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            return View(db.Tables.ToList());
        }

        public decimal CalculateQuota(Table Tables)
        {
            decimal baseCost = 50;
            var today = DateTime.Today;
            int age = today.Year - Tables.DateOfBirth.Year;

            if (age <= 18)
            {
            }
            else if (age >= 19 && age <= 25)
                baseCost = decimal.Add(baseCost, 50);
            else
                baseCost = decimal.Add(baseCost, 25);
            if (Tables.CarYear < 2000 || Tables.CarYear > 2015)
                baseCost = decimal.Add(baseCost, 25);
            if (Tables.CarMake == "Porsche")
                baseCost = decimal.Add(baseCost, 25);
            if (Tables.CarModel == "911 Carrera")
                baseCost = decimal.Add(baseCost, 25);
            if (Tables.SpeedingTickets > 0)
            {
                decimal feeTicket = Tables.SpeedingTickets * 10;
                baseCost = decimal.Add(baseCost, feeTicket);
            }
            if (Tables.DUI == true)
            {
                decimal upcharge = baseCost / (double)4;
                baseCost = decimal.Add(baseCost, upcharge);
            }
            if (Tables.CoverageType == true)
            {
                decimal coverFee = baseCost / (double)2;
                baseCost = decimal.Add(baseCost, coverFee);
            }
            return baseCost;
        }
    }
}
