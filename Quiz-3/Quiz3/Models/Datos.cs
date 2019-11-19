using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_2009_II_clase_6.Models
{
    public class DatosPersonales
    {
        [Required(ErrorMessage = "El campo nombre es requerido.")]
        [Display(Name = "Nombre")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "El campo apellido es requerido.")]
        [Display(Name = "Apellido")]
        public String apellido { get; set; }
        [Required(ErrorMessage = "El campo edad es requerido.")]
        [Display(Name = "Edad")]
        public short Edad { get; set; }
    }

    public class DatosEmail
    {
        [Required(ErrorMessage ="El correo electronico es requerido")]
        [Display(Name = "Correo electronico")]
        public String Email { get; set; }
        [Required(ErrorMessage = "La contraseña es requerido")]
        [Display(Name = "Contrasena")]
        public String Password { get; set; }
        [Required(ErrorMessage = "La VERIFICACIÓN contraseña es requerido")]
        [Display(Name = "Nueva Contrasena")]
        public String PasswordVerificacion { get; set; }

    }
}