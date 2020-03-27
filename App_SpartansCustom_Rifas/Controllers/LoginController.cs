using App_SpartansCustom_Rifas.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace App_SpartansCustom_Rifas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Register(string nombreUsuario, string contrasenia, string correo, bool esAdmin = false)
        {
            string response = "error";
            using (App_SpartansCustom_Entities db = new App_SpartansCustom_Entities())
            {
                if (db.tbUsuarios.Any(x => x.usu_NombreDeUsuario == nombreUsuario))
                {
                    return Json("existe", JsonRequestBehavior.AllowGet);
                }

                if (nombreUsuario != null && contrasenia != null && correo != null)
                {
                    using (System.Transactions.TransactionScope transaction = new System.Transactions.TransactionScope())
                    {
                        try
                        {
                            if (
                                db.UDP_Seg_tbUsuarios_Insert(
                                    nombreUsuario,
                                    correo,
                                    contrasenia,
                                    esAdmin
                                    ).FirstOrDefault()
                                    .StartsWith("-1")
                                )
                            {
                                return Json(response, JsonRequestBehavior.AllowGet);
                            }
                            else
                            {
                                response = "bien";
                            }

                            transaction.Complete();
                        }
                        catch (Exception ex)
                        {
                            return Json(response, JsonRequestBehavior.AllowGet);
                        }
                    }
                }

            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Index(string nombreUsuario, string contrasenia)
        {
            string response = "error";
            using (App_SpartansCustom_Entities db = new App_SpartansCustom_Entities())
            {

                if (nombreUsuario != null && contrasenia != null)
                {
                    try
                    {
                        var consultaUsuario = db.UDP_Seg_Login(
                                nombreUsuario,
                                contrasenia
                                ).FirstOrDefault();

                        // Saber si existe el usuario
                        if (consultaUsuario != null)
                        {
                            // Retornar el usuario
                            return Json(consultaUsuario, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {
                            // Usuario o contraseña incorrecta
                            return Json(response, JsonRequestBehavior.AllowGet);
                        }
                    }
                    catch (Exception ex)
                    {
                        return Json(response, JsonRequestBehavior.AllowGet);
                    }
                }

            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}