using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using quiz1_2019_2.Models;

namespace quiz1_2019_2.Controllers
{
    public class PeliculasController : Controller{
        // GET: Peliculas
        public ActionResult Index(){
            return View();
        }

        public ActionResult Buscar(){
            const byte CANTPELICULAS = 3;

            Pelicula[] proyecciones = {
            new Pelicula("It chapter two", "New Line Cinema", 2019),
            new Pelicula("The lion king", "Walt Disney Pictures", 2019),
            new Pelicula("Ready or not", "Fox Searchlight ", 2019) };

            String nombrePelicula = RouteData.Values["nombrePelicula"].ToString();

            for(int i = 0; i < CANTPELICULAS; i++){
                if (String.Equals(proyecciones[i].titulo, nombrePelicula, StringComparison.OrdinalIgnoreCase)){
                    return Content("<h4>Titulo:</h4>" + proyecciones[i].titulo +
                        ".<h4>Productora:</h4>" + proyecciones[i].productora +
                        ".<h4>Año:</h4>" + proyecciones[i].anio + "." +
                        "<br><br>Posición en el arreglo: " + i + ".");
                }
            }

            return Content("La pelicula de titulo: " + nombrePelicula +", no se encuentra.");
        }
    }
}