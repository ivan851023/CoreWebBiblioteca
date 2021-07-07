using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebBiblioteca.Models
{
    public class AutorModel
    {

        public int Id { get; set; }
        public string Nombres { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Ciudad { get; set; }

        public string Correo { get; set; }


        [Display(Name = "Seleccione Empleado")]
        public string labelAutor { get; set; }

        public int selectValueAutor { get; set; }

        public SelectList listAutor { get; set; }
    }
}
