using App_SpartansCustom_Rifas.Helpers;
using App_SpartansCustom_Rifas.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace App_SpartansCustom_Rifas.Controllers
{
    public class RangosController : Controller
    {
        private App_SpartansCustom_Entities db = new App_SpartansCustom_Entities();

        // GET: /Rangos/
        public ViewResult Index()
        {
            return View();
        }

        //GET: /Rangos/GetData
        //Obtener la data para actualizar la tabla
        public async Task<JsonResult> GetData() =>

          Json(
                new
                {
                    data = await Task.Run(() => db.
                      tbRangos.
                      Where(x => x.rang_Estado == true)
                      .OrderByDescending(x => x.rang_FechaCrea)
                      .Select(
                      x => new
                      {
                          descripcion = x.rang_Descripcion,
                          numero = x.rang_Id,
                          estado = x.rang_Estado
                      }))
                },
                JsonRequestBehavior.AllowGet
                );



        // GET: /Rangos/Details/5
        public async Task<JsonResult> Details(int? id)
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

            object result = new
            {
                id = tbRangos.rang_Id,
                descripcion = tbRangos.rang_Descripcion,
                usuarioCrea = tbRangos.tbUsuarios.usu_NombreDeUsuario,
                fechaCrea = General.FechaRetorno(tbRangos.rang_FechaCrea),
                usuarioModifica = tbRangos.rang_UsuarioModifica is null ? "No modificado" : tbRangos.tbUsuarios1.usu_NombreDeUsuario,
                fechaModifica = tbRangos.rang_FechaModifica is null ? "No modificado" : General.FechaRetorno(tbRangos.rang_FechaModifica.Value)
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // POST: /Rangos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(tbRangos tbRangos)
        {
            string response = "error";

            if (ModelState.IsValid && tbRangos.rang_Descripcion != null)
            {
                try
                {
                    if ( // Si se inserto mal retornar la vista
                        await Task.Run(() =>

                            // Retornar la insersion asincrona

                            db.UDP_Person_tbRangos_Insert(
                            tbRangos.rang_Descripcion,
                            true,
                            1,
                            DateTime.Now,
                            null,
                            null)
                            .FirstOrDefault()
                            .StartsWith("-1")
                        )
                        )
                    {
                        return Json(response, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        //Si se inserto bien redireccionar al index
                        response = "bien";
                    }
                }
                catch (Exception)
                {
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        //Post edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Edit([Bind(Include = "rang_Id,rang_Descripcion")] tbRangos tbRangos)
        {
            string response = "error";
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
                        return Json(response, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        //Si se inserto bien redireccionar al index
                        return Json("bien", JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception)
                {
                    return Json(response, JsonRequestBehavior.AllowGet);
                }

            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        // POST: /Rangos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> DeleteConfirmed(int id)
        {
            string response = "error";
            try
            {
                if ( // Si se inserto mal retornar la vista
                        await Task.Run(() =>
                        {
                            // Retornar la insersion asincrona
                            return

                            db.UDP_Person_tbRangos_Delete(
                                id,
                                1
                            )
                            .FirstOrDefault()
                            .StartsWith("-1");
                        })
                        )
                {
                    return Json(response, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    //Si se inserto bien redireccionar al index
                    return Json("bien", JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {
                return Json(response, JsonRequestBehavior.AllowGet);
            }
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
