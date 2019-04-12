﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using pureba2register.Models;

namespace pureba2register.Controllers
{
    public class InformacionLaboralsController : Controller
    {
        private pureba2registerContext db = new pureba2registerContext();

        // GET: InformacionLaborals
        public ActionResult Index()
        {
            var informacionLaborals = db.InformacionLaborals.Include(i => i.InformacionPersonal).Include(i => i.RangoSalarial);
            return View(informacionLaborals.ToList());
        }

        // GET: InformacionLaborals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionLaboral informacionLaboral = db.InformacionLaborals.Find(id);
            if (informacionLaboral == null)
            {
                return HttpNotFound();
            }
            return View(informacionLaboral);
        }

        // GET: InformacionLaborals/Create
        public ActionResult Create()
        {
            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado");
            ViewBag.RangoSalarialID = new SelectList(db.RangoSalarials, "RangoSalarialID", "CantidadRangoSalarial");
            return View();
        }

        // POST: InformacionLaborals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InformacionLaboralID,TrabajaActualmente,NombresJefeLaboral,ApellidoJefeLaboral,TelefonoJefeLaboral,NombreEmpresaLaboral,DireccionEmpresaLaboral,CargoOcupacionLaboral,fechaIngresoLaboral,InformacionPersonalID,RangoSalarialID")] InformacionLaboral informacionLaboral)
        {
            if (ModelState.IsValid)
            {
                db.InformacionLaborals.Add(informacionLaboral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado", informacionLaboral.InformacionPersonalID);
            ViewBag.RangoSalarialID = new SelectList(db.RangoSalarials, "RangoSalarialID", "CantidadRangoSalarial", informacionLaboral.RangoSalarialID);
            return View(informacionLaboral);
        }

        // GET: InformacionLaborals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionLaboral informacionLaboral = db.InformacionLaborals.Find(id);
            if (informacionLaboral == null)
            {
                return HttpNotFound();
            }
            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado", informacionLaboral.InformacionPersonalID);
            ViewBag.RangoSalarialID = new SelectList(db.RangoSalarials, "RangoSalarialID", "CantidadRangoSalarial", informacionLaboral.RangoSalarialID);
            return View(informacionLaboral);
        }

        // POST: InformacionLaborals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InformacionLaboralID,TrabajaActualmente,NombresJefeLaboral,ApellidoJefeLaboral,TelefonoJefeLaboral,NombreEmpresaLaboral,DireccionEmpresaLaboral,CargoOcupacionLaboral,fechaIngresoLaboral,InformacionPersonalID,RangoSalarialID")] InformacionLaboral informacionLaboral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informacionLaboral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InformacionPersonalID = new SelectList(db.InformacionPersonals, "InformacionPersonalID", "NombresEgresado", informacionLaboral.InformacionPersonalID);
            ViewBag.RangoSalarialID = new SelectList(db.RangoSalarials, "RangoSalarialID", "CantidadRangoSalarial", informacionLaboral.RangoSalarialID);
            return View(informacionLaboral);
        }

        // GET: InformacionLaborals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformacionLaboral informacionLaboral = db.InformacionLaborals.Find(id);
            if (informacionLaboral == null)
            {
                return HttpNotFound();
            }
            return View(informacionLaboral);
        }

        // POST: InformacionLaborals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InformacionLaboral informacionLaboral = db.InformacionLaborals.Find(id);
            db.InformacionLaborals.Remove(informacionLaboral);
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
