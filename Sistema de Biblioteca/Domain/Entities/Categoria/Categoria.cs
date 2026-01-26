using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Domain.Entities.Categoria
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Categoria()
        {
        }

        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
