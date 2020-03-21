using App_SpartansCustom_Rifas.Helpers;
using App_SpartansCustom_Rifas.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

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
        public JsonResult Details(int? id)
        {
            if (id == null)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
            tbRangos tbRangos = db.tbRangos.Find(id);
            if (tbRangos == null)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

            object result = new
            {
                id = tbRangos.rang_Id,
                descripcion = tbRangos.rang_Descripcion,
                usuarioCrea = tbRangos.tbUsuarios.usu_NombreDeUsuario,
                fechaCrea = General.FechaRetorno(tbRangos.rang_FechaCrea),
                usuarioModifica = tbRangos.rang_UsuarioModifica is null ? "No modificado": tbRangos.tbUsuarios1.usu_NombreDeUsuario ,
                fechaModifica =  tbRangos.rang_FechaModifica is null ? "No modificado":  General.FechaRetorno(tbRangos.rang_FechaModifica.Value)
            };

            return Json(result, JsonRequestBehavior.AllowGet);
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
        public async Task<ActionResult> Create(tbRangos tbRangos)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if ( // Si se inserto mal retornar la vista
                        await Task.Run(() =>
                        {
                            // Retornar la insersion asincrona
                            return

                            db.UDP_Person_tbRangos_Insert(
                            tbRangos.rang_Descripcion,
                            true,
                            1,
                            DateTime.Now,
                            null,
                            null)
                            .FirstOrDefault()
                            .StartsWith("-1");
                        })
                        )
                    {
                        return View(tbRangos);
                    }
                    else
                    {
                        //Si se inserto bien redireccionar al index
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception)
                {
                    return View(tbRangos);
                }
            }

            return View(tbRangos);
        }

        // GET: /Rangos/Edit/5
        public async Task<JsonResult> Edit(int? id)
        {
            if (id == null)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
            tbRangos tbRangos = await db.tbRangos.FindAsync(id);
            if (tbRangos == null)
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

            return Json(tbRangos.rang_Descripcion, JsonRequestBehavior.AllowGet);
        }

        // POST: /Rangos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "rang_Id,rang_Descripcion,rang_Estado,rang_UsuarioCrea,rang_FechaCrea,rang_UsuarioModifica,rang_FechaModifica")] tbRangos tbRangos)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if ( // Si se inserto mal retornar la vista
                        await Task.Run(() =>
                        {
                            // Retornar la insersion asincrona
                            return

                            db.UDP_Person_tbRangos_Update(
                                tbRangos.rang_Id,
                                tbRangos.rang_Descripcion,
                            1
                            )
                            .FirstOrDefault()
                            .StartsWith("-1");
                        })
                        )
                    {
                        return View(tbRangos);
                    }
                    else
                    {
                        //Si se inserto bien redireccionar al index
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception)
                {
                    return View(tbRangos);
                }

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
