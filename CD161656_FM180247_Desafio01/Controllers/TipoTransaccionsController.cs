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
    public class TipoTransaccionsController : Controller
    {
        private Banco db = new Banco();

        // GET: TipoTransaccions
        public ActionResult Index()
        {
            return View(db.TipoTransaccions.ToList());
        }

        // GET: TipoTransaccions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransaccion tipoTransaccion = db.TipoTransaccions.Find(id);
            if (tipoTransaccion == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransaccion);
        }

        // GET: TipoTransaccions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTransaccions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tipo_transaccion")] TipoTransaccion tipoTransaccion)
        {
            if (ModelState.IsValid)
            {
                db.TipoTransaccions.Add(tipoTransaccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTransaccion);
        }

        // GET: TipoTransaccions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransaccion tipoTransaccion = db.TipoTransaccions.Find(id);
            if (tipoTransaccion == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransaccion);
        }

        // POST: TipoTransaccions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tipo_transaccion")] TipoTransaccion tipoTransaccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoTransaccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTransaccion);
        }

        // GET: TipoTransaccions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransaccion tipoTransaccion = db.TipoTransaccions.Find(id);
            if (tipoTransaccion == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransaccion);
        }

        // POST: TipoTransaccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoTransaccion tipoTransaccion = db.TipoTransaccions.Find(id);
            db.TipoTransaccions.Remove(tipoTransaccion);
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
