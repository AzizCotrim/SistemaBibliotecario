using Sistema_de_Biblioteca.Application.DTOs.Livro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Application.DTOs.Saldo
{
    internal class LivroSaldoCreateRequest
    {
        public LivroResumoResponse Livro { get; set; }
        public int Qtd { get; set; }
    }
}
