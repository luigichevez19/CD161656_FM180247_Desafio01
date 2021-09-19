using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CD161656_FM180247_Desafio01.Models;

namespace CD161656_FM180247_Desafio01.Controllers
{
    public class TipoCuentaBancariasController : Controller
    {
        private Banco db = new Banco();

        // GET: TipoCuentaBancarias
        public ActionResult Index()
        {
            return View(db.TipoCuentaBancarias.ToList());
        }

        // GET: TipoCuentaBancarias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCuentaBancaria tipoCuentaBancaria = db.TipoCuentaBancarias.Find(id);
            if (tipoCuentaBancaria == null)
            {
                return HttpNotFound();
            }
            return View(tipoCuentaBancaria);
        }

        // GET: TipoCuentaBancarias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCuentaBancarias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TipoCuentaBan,Activo")] TipoCuentaBancaria tipoCuentaBancaria)
        {
            if (ModelState.IsValid)
            {
                db.TipoCuentaBancarias.Add(tipoCuentaBancaria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoCuentaBancaria);
        }

        // GET: TipoCuentaBancarias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCuentaBancaria tipoCuentaBancaria = db.TipoCuentaBancarias.Find(id);
            if (tipoCuentaBancaria == null)
            {
                return HttpNotFound();
            }
            return View(tipoCuentaBancaria);
        }

        // POST: TipoCuentaBancarias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TipoCuentaBan,Activo")] TipoCuentaBancaria tipoCuentaBancaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoCuentaBancaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoCuentaBancaria);
        }

        // GET: TipoCuentaBancarias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCuentaBancaria tipoCuentaBancaria = db.TipoCuentaBancarias.Find(id);
            if (tipoCuentaBancaria == null)
            {
                return HttpNotFound();
            }
            return View(tipoCuentaBancaria);
        }

        // POST: TipoCuentaBancarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoCuentaBancaria tipoCuentaBancaria = db.TipoCuentaBancarias.Find(id);
            db.TipoCuentaBancarias.Remove(tipoCuentaBancaria);
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
