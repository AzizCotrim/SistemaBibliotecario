using Sistema_de_Biblioteca.Application.DTOs.Livro;
namespace Sistema_de_Biblioteca.Application.DTOs.LivroSaldo
{
    internal class LivroSaldoResponse
    {
        public LivroResumoResponse Livro { get; set; }
        public int Qtd { get; set; }

    }
}
