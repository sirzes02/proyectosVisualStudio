using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quiz1_2019_2.Models{
    public class Pelicula{

        public String titulo { get; set; }
        public String productora { get; set; }
        public short anio { get; set; }

        public Pelicula(String titulo, String productora, short anio){
            this.titulo = titulo;
            this.productora = productora;
            this.anio = anio;
        }
    }
}