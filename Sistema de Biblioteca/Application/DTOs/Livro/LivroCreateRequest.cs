namespace Sistema_de_Biblioteca.Application.DTOs.Livro
{
    internal class LivroCreateRequest
    {
        public int Categoria { get; set; }
        public string Titulo { get; set; }
        public string? Autor { get; set; }
        public int? DataLancamento { get; set; }
    }
}
