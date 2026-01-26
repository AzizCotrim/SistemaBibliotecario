using Sistema_de_Biblioteca.Application.DTOs.Categoria;

namespace Sistema_de_Biblioteca.Application.DTOs.Livro
{
    internal class LivroResponse
    {
        public int Id { get; set; }
        public CategoriaResumoResponse Categoria { get; set; }
        public int Titulo { get; set; }
        public int Autor { get; set; }
        public int? DataLancamento { get; set; }
    }
}
