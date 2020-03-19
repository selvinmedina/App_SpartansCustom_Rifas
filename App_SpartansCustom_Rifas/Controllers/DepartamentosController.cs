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
    public class DepartamentosController : Controller
    {
        private App_SpartansCustom_Entities db = new App_SpartansCustom_Entities();

        // GET: /Departamentos/
        public async Task<ActionResult> Index()
        {
            var tbdepartamentos = db.tbDepartamentos.Include(t => t.tbCiudades).Include(t => t.tbPais).Include(t => t.tbUsuarios).Include(t => t.tbUsuarios1);
            return View(await tbdepartamentos.ToListAsync());
        }

        // GET: /Departamentos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDepartamentos tbDepartamentos = await db.tbDepartamentos.FindAsync(id);
            if (tbDepartamentos == null)
            {
                return HttpNotFound();
            }
            return View(tbDepartamentos);
        }

        // GET: /Departamentos/Create
        public ActionResult Create()
        {
            ViewBag.depto_Id = new SelectList(db.tbCiudades, "ciud_Id", "ciud_Descripcion");
            ViewBag.pais_Id = new SelectList(db.tbPais, "pais_Id", "pais_Descripcion");
            ViewBag.depto_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario");
            ViewBag.depto_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario");
            return View();
        }

        // POST: /Departamentos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="depto_Id,depto_Descripcion,depto_CodigoDepartamento,pais_Id,depto_EsActivo,depto_UsuarioCrea,depto_FechaCrea,depto_UsuarioModifica,depto_FechaModifica")] tbDepartamentos tbDepartamentos)
        {
            if (ModelState.IsValid)
            {
                db.tbDepartamentos.Add(tbDepartamentos);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.depto_Id = new SelectList(db.tbCiudades, "ciud_Id", "ciud_Descripcion", tbDepartamentos.depto_Id);
            ViewBag.pais_Id = new SelectList(db.tbPais, "pais_Id", "pais_Descripcion", tbDepartamentos.pais_Id);
            ViewBag.depto_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbDepartamentos.depto_UsuarioCrea);
            ViewBag.depto_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbDepartamentos.depto_UsuarioModifica);
            return View(tbDepartamentos);
        }

        // GET: /Departamentos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDepartamentos tbDepartamentos = await db.tbDepartamentos.FindAsync(id);
            if (tbDepartamentos == null)
            {
                return HttpNotFound();
            }
            ViewBag.depto_Id = new SelectList(db.tbCiudades, "ciud_Id", "ciud_Descripcion", tbDepartamentos.depto_Id);
            ViewBag.pais_Id = new SelectList(db.tbPais, "pais_Id", "pais_Descripcion", tbDepartamentos.pais_Id);
            ViewBag.depto_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbDepartamentos.depto_UsuarioCrea);
            ViewBag.depto_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbDepartamentos.depto_UsuarioModifica);
            return View(tbDepartamentos);
        }

        // POST: /Departamentos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="depto_Id,depto_Descripcion,depto_CodigoDepartamento,pais_Id,depto_EsActivo,depto_UsuarioCrea,depto_FechaCrea,depto_UsuarioModifica,depto_FechaModifica")] tbDepartamentos tbDepartamentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbDepartamentos).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.depto_Id = new SelectList(db.tbCiudades, "ciud_Id", "ciud_Descripcion", tbDepartamentos.depto_Id);
            ViewBag.pais_Id = new SelectList(db.tbPais, "pais_Id", "pais_Descripcion", tbDepartamentos.pais_Id);
            ViewBag.depto_UsuarioCrea = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbDepartamentos.depto_UsuarioCrea);
            ViewBag.depto_UsuarioModifica = new SelectList(db.tbUsuarios, "usu_Id", "usu_NombreDeUsuario", tbDepartamentos.depto_UsuarioModifica);
            return View(tbDepartamentos);
        }

        // GET: /Departamentos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDepartamentos tbDepartamentos = await db.tbDepartamentos.FindAsync(id);
            if (tbDepartamentos == null)
            {
                return HttpNotFound();
            }
            return View(tbDepartamentos);
        }

        // POST: /Departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tbDepartamentos tbDepartamentos = await db.tbDepartamentos.FindAsync(id);
            db.tbDepartamentos.Remove(tbDepartamentos);
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
