using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Domain.Entities.Livro
{
    internal class Livro
    {
        public int Id;
        public int Categoria;
        public string Titulo;
        public string Autor;
        public int DataLancamento;
        public int Qtd;

        public Livro(int categoria, string titulo, string autor, int dataLancamento, int qtd)
        {
            Categoria = categoria;
            Titulo = titulo;
            Autor = autor;
            DataLancamento = dataLancamento;
            Qtd = qtd;
        }

        public Livro(int id, int categoria, string titulo, string autor, int datalancamento, int qtd)
        {
            Id = id;
            Categoria = categoria;
            Titulo = titulo;
            Autor = autor;
            DataLancamento = datalancamento;
            Qtd = qtd;
        }



    }
}
