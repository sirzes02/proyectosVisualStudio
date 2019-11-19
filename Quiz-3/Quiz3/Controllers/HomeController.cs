using Ejercicio_2009_II_clase_6.Models;
using System.Web.Mvc;

namespace Ejercicio_2009_II_clase_6.Controllers
{
    public class HomeController : Controller
    {

        static short cont;

        // GET: Home
        public ActionResult Index(){
            cont = 0;
            return View();
        }

        public ActionResult DatosPersonales(DatosEmail obj){
            if (ModelState.IsValid)
                if (cont <= 2)
                    if (obj.Password == obj.PasswordVerificacion)
                        if (obj.Email == "pepito@hotmail.com" && obj.Password == "123" && cont < 3)
                        {
                            cont = 0;
                            return View();
                        }
                        else
                        {
                            cont++;
                            return View("Index");
                        }
                    else
                    {
                        cont++;
                        return Content("Las contraseñas no coinciden.");
                    }
                else return Content("Suplantacion, superaste el numero de intentos.");
            else return Content("Error");
        }
        public ActionResult MostrarDatos(DatosPersonales obj){
            if (ModelState.IsValid && obj.Edad > 0 && obj.Edad < 100)
                if (obj.Edad >= 18)
                    return View(obj);
                else return Content("Es menor de edad, ingreso no valido.");
            else return Content("Error en el ingreso de la edad, no es valida.");
        }
    }
}