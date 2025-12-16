using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Application.DTOs
{
    internal class PedidoBuscaLivro
    {
        public int? Id;
        public int? Categoria;
        public string? Titulo;
        public string? Autor;
        public int? DataLancamento;
        public int? Qtd;


        public PedidoBuscaLivro(int id, int categoria, string titulo, string autor, int datalancamento, int qtd)
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
