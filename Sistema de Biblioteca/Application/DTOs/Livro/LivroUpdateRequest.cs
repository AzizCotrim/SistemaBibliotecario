using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Application.DTOs.Livro
{
    internal class LivroUpdateRequest
    {
        public int Categoria { get; set; }
        public string Titulo { get; set; }
        public string? Autor { get; set; }
        public int? DataLancamento { get; set; }
    }
}
