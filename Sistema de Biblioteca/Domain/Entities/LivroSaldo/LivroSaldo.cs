using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Domain.Entities.Estoque
{
    internal class LivroSaldo
    {
        //O estoque tem que ter um id?
        //Id para o estoque seria de localizacao?
        public int IdLivro { get; set; }
        public int Qtd { get; set; }

        public LivroSaldo(int idLivro, int qtd)
        {
            IdLivro = idLivro;
            Qtd = qtd;
        }
    }
}
