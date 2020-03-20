using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using App_SpartansCustom_Rifas.Models;

namespace App_SpartansCustom_Rifas.Controllers
{
    public class RangosController : Controller
    {
        private App_SpartansCustom_Entities db = new App_SpartansCustom_Entities();

        // GET: /Rangos/
        public async Task<ActionResult> Index()
        {
            var tbrangos = db.tbRangos.Include(t => t.tbUsuarios).Include(t => t.tbUsuarios1);
            return View(await tbrangos.ToListAsync());
        }

        // GET: /Rangos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbRangos tbRangos = await db.tbRangos.FindAsync(id);
            if (tbRangos == null)
            {
                return HttpNotFound();
            }
            return View(tbRangos);
        }

        // GET: /Rangos/Create
        public ActionResult Create()
        {
            ViewBag.rang_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario");
            ViewBag.rang_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario");
            return View();
        }

        // POST: /Rangos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create( tbRangos tbRangos)
        {
            if (ModelState.IsValid)
            {
                db.tbRangos.Add(tbRangos);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.rang_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbRangos.rang_UsuarioCrea);
            ViewBag.rang_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbRangos.rang_UsuarioModifica);
            return View(tbRangos);
        }

        // GET: /Rangos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbRangos tbRangos = await db.tbRangos.FindAsync(id);
            if (tbRangos == null)
            {
                return HttpNotFound();
            }
            ViewBag.rang_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbRangos.rang_UsuarioCrea);
            ViewBag.rang_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbRangos.rang_UsuarioModifica);
            return View(tbRangos);
        }

        // POST: /Rangos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="rang_Id,rang_Descripcion,rang_Estado,rang_UsuarioCrea,rang_FechaCrea,rang_UsuarioModifica,rang_FechaModifica")] tbRangos tbRangos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbRangos).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.rang_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbRangos.rang_UsuarioCrea);
            ViewBag.rang_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbRangos.rang_UsuarioModifica);
            return View(tbRangos);
        }

        // GET: /Rangos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbRangos tbRangos = await db.tbRangos.FindAsync(id);
            if (tbRangos == null)
            {
                return HttpNotFound();
            }
            return View(tbRangos);
        }

        // POST: /Rangos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tbRangos tbRangos = await db.tbRangos.FindAsync(id);
            db.tbRangos.Remove(tbRangos);
            await db.SaveChangesAsync();
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
