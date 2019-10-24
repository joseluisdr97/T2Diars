using Diaz_Ruiz_T2_Diars.Clases;
using Diaz_Ruiz_T2_Diars.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diaz_Ruiz_T2_Diars.Controllers
{
    public class EntrenadorController : Controller
    {
        private AppConexionDB conexion = new AppConexionDB();
        // GET: Entrenador
        [HttpGet]
        public ActionResult Index(string query)
        {
            var datos = new List<Entrenador>();
            if (query == null || query == "")
            {
                datos = conexion.Entrenadores.ToList();
            }
            else
            {
                datos = conexion.Entrenadores.Where(o => o.Nombre.Contains(query)).ToList();
            }
            ViewBag.datos = query;
            return View(datos);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            //ViewBag.Usuario = con.Usuarios.ToList();
            return View(new Entrenador());
        }
        [HttpPost]
        public ActionResult Crear(Entrenador entrenador)
        {
            validar(entrenador);
            if (ModelState.IsValid == true)
            {
                conexion.Entrenadores.Add(entrenador);
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrenador);
        }
        public void validar(Entrenador entrenador)
        {


            if (entrenador.Nombre == null ||entrenador.Nombre == "")
                ModelState.AddModelError("Nombre", "El campo nombre es obligatorio");

        }
    }
}