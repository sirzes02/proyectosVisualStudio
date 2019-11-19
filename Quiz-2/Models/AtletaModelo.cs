using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quiz2ProgramaciónWEBen.NET2019_II.Models
{
    public class AtletaModelo
    {
        [Required(ErrorMessage = "El campo nombre es requerido.")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "El campo numero de espalda es requerido.")]
        public int numeroEspalda { get; set; }
    }
}