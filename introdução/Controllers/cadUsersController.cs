using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_EF.Models;
using introdução.Models;

namespace introdução.Controllers
{
    public class cadUsersController : Controller
    {
        private introduçãoContext2 db = new introduçãoContext2();

        // GET: cadUsers
        public ActionResult Index()
        {
            return View(db.cadUsers.ToList());
        }

        // GET: cadUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadUser cadUser = db.cadUsers.Find(id);
            if (cadUser == null)
            {
                return HttpNotFound();
            }
            return View(cadUser);
        }

        // GET: cadUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cadUsers/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,endereço,cpf,celular,nascimento")] cadUser cadUser)
        {
            if (ModelState.IsValid)
            {
                db.cadUsers.Add(cadUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadUser);
        }

        // GET: cadUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadUser cadUser = db.cadUsers.Find(id);
            if (cadUser == null)
            {
                return HttpNotFound();
            }
            return View(cadUser);
        }

        // POST: cadUsers/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,endereço,cpf,celular,nascimento")] cadUser cadUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadUser);
        }

        // GET: cadUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadUser cadUser = db.cadUsers.Find(id);
            if (cadUser == null)
            {
                return HttpNotFound();
            }
            return View(cadUser);
        }

        // POST: cadUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cadUser cadUser = db.cadUsers.Find(id);
            db.cadUsers.Remove(cadUser);
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
