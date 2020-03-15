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
    public class CategoriaProductosController : Controller
    {
        private App_SpartansCustom_Entities db = new App_SpartansCustom_Entities();

        // GET: CategoriaProductos
        public async Task<ActionResult> Index()
        {
            var tbCategoriaProductos = db.tbCategoriaProductos.Include(t => t.tbUsuarios).Include(t => t.tbUsuarios1);
            return View(await tbCategoriaProductos.ToListAsync());
        }

        // GET: CategoriaProductos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCategoriaProductos tbCategoriaProductos = await db.tbCategoriaProductos.FindAsync(id);
            if (tbCategoriaProductos == null)
            {
                return HttpNotFound();
            }
            return View(tbCategoriaProductos);
        }

        // GET: CategoriaProductos/Create
        public ActionResult Create()
        {
            ViewBag.cprod_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario");
            ViewBag.cprod_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario");
            return View();
        }

        // POST: CategoriaProductos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "cprod_Id,cprod_Descripcion,cprod_UsuarioCrea,cprod_FechaCrea,cprod_UsuarioModifica,cprod_FechaModifica")] tbCategoriaProductos tbCategoriaProductos)
        {
            if (ModelState.IsValid)
            {
                db.tbCategoriaProductos.Add(tbCategoriaProductos);
                
                return RedirectToAction("Index");
            }

            ViewBag.cprod_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbCategoriaProductos.cprod_UsuarioCrea);
            ViewBag.cprod_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbCategoriaProductos.cprod_UsuarioModifica);
            return View(tbCategoriaProductos);
        }

        // GET: CategoriaProductos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCategoriaProductos tbCategoriaProductos = await db.tbCategoriaProductos.FindAsync(id);
            if (tbCategoriaProductos == null)
            {
                return HttpNotFound();
            }
            ViewBag.cprod_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbCategoriaProductos.cprod_UsuarioCrea);
            ViewBag.cprod_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbCategoriaProductos.cprod_UsuarioModifica);
            return View(tbCategoriaProductos);
        }

        // POST: CategoriaProductos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "cprod_Id,cprod_Descripcion,cprod_UsuarioCrea,cprod_FechaCrea,cprod_UsuarioModifica,cprod_FechaModifica")] tbCategoriaProductos tbCategoriaProductos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbCategoriaProductos).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.cprod_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbCategoriaProductos.cprod_UsuarioCrea);
            ViewBag.cprod_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbCategoriaProductos.cprod_UsuarioModifica);
            return View(tbCategoriaProductos);
        }

        // GET: CategoriaProductos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCategoriaProductos tbCategoriaProductos = await db.tbCategoriaProductos.FindAsync(id);
            if (tbCategoriaProductos == null)
            {
                return HttpNotFound();
            }
            return View(tbCategoriaProductos);
        }

        // POST: CategoriaProductos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tbCategoriaProductos tbCategoriaProductos = await db.tbCategoriaProductos.FindAsync(id);
            db.tbCategoriaProductos.Remove(tbCategoriaProductos);
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
