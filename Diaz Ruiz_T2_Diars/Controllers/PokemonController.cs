using Diaz_Ruiz_T2_Diars.Clases;
using Diaz_Ruiz_T2_Diars.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diaz_Ruiz_T2_Diars.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        private AppConexionDB conexion = new AppConexionDB();

        [HttpGet]
        public ActionResult Index(string query)
        {
            var datos = new List<Pokemon>();
            if (query == null || query == "")
            {
                datos = conexion.Pokemones.ToList();
            }
            else
            {
                datos = conexion.Pokemones.Where(o => o.Nombre.Contains(query)).ToList();
            }
            ViewBag.datos = query;
            return View(datos);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            //ViewBag.Usuario = con.Usuarios.ToList();
            return View(new Pokemon());
        }
        [HttpPost]
        public ActionResult Crear(Pokemon pokemon)
        {
            validar(pokemon);
            if (ModelState.IsValid == true)
            {
                conexion.Pokemones.Add(pokemon);
                conexion.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pokemon);
        }
        public void validar(Pokemon pokemon)
        {


            if (pokemon.Nombre == null || pokemon.Nombre == "")
                ModelState.AddModelError("Nombre", "El campo nombre es obligatorio");
        }
    }
}