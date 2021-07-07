using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebBiblioteca.Models
{
    public class LibroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public int Anio { get; set; }

        public string Genero { get; set; }

        public int NumeroPaginas { get; set; }

        public int IdAutor { get; set; }

    }
}
