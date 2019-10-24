using Diaz_Ruiz_T2_Diars.Clases;
using Diaz_Ruiz_T2_Diars.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diaz_Ruiz_T2_Diars.Controllers
{
    public class CapturaController : Controller
    {
        // GET: Captura
        private AppConexionDB conexion = new AppConexionDB();

        [HttpGet]
        public ActionResult Index(int id)
        {
     
                var datos = conexion.Capturas.Include(t => t.Entrenador).Include(t=>t.Pokemon).Where(t => t.Entrenador.IdEntrenador == id).ToList();
            
            ViewBag.IdEntrenador = id;
            return View(datos);
        }
        [HttpGet]
        public ActionResult Crear(int id)
        {
            ViewBag.IdEntrenador = id;
            ViewBag.Pokemones = conexion.Pokemones.ToList();
            return View(new Captura());
        }
        [HttpPost]
        public ActionResult Crear(Captura captura, int id)
        {
            validar(captura);
            if (ModelState.IsValid == true)
            {
                captura.IdEntrenador = id;
                conexion.Capturas.Add(captura);
                conexion.SaveChanges();
                return RedirectToAction("Index", new { id = captura.IdEntrenador });
            }
            ViewBag.IdEntrenador = id;
            ViewBag.Pokemones = conexion.Pokemones.ToList();
            return View(captura);
        }
        
        public ActionResult Eliminar(int id)
        {
            var DbCaptura = conexion.Capturas.Find(id);
            conexion.Capturas.Remove(DbCaptura);
            conexion.SaveChanges();
            return RedirectToAction("Index", new { id = DbCaptura.IdEntrenador });
        }



        public void validar(Captura captura)
        {

        }
    }
}