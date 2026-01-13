namespace Sistema_de_Biblioteca.Domain.Entities.Livro
{
    internal class Livro
    {
        public int Id;
        public int Categoria;
        public string Titulo;
        public string Autor;
        public int? DataLancamento;

        public Livro(int categoria, string titulo, string autor, int? dataLancamento)
        {
            Categoria = categoria;
            Titulo = titulo;
            Autor = autor;
            DataLancamento = dataLancamento;
        }

        public Livro(int id, int categoria, string titulo, string autor, int? datalancamento)
        {
            Id = id;
            Categoria = categoria;
            Titulo = titulo;
            Autor = autor;
            DataLancamento = datalancamento;
        }



    }
}
