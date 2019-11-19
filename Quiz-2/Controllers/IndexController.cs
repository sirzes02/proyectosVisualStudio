using Quiz2ProgramaciónWEBen.NET2019_II.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz2ProgramaciónWEBen.NET2019_II.Controllers
{
    public class IndexController : Controller
    {
        static AtletaModelo miAtleta = new AtletaModelo();

        public void crear(String nombre, int num)
        {
            miAtleta.nombre = nombre;
            miAtleta.numeroEspalda = num;
        }

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarNombre(AtletaModelo obj)
        {
            if (obj.nombre != null)
            {
                crear(obj.nombre, obj.numeroEspalda);
                return View(obj);
            }
            return View(miAtleta);
        }
        public ActionResult MostrarNumero()
        {
            return PartialView(miAtleta);  
        }
    }
}