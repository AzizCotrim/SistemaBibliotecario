using Sistema_de_Biblioteca.Infrastructure.Database;
using Sistema_de_Biblioteca.Infrastructure.Repositories;

namespace Sistema_de_Biblioteca.Application.Sevices
{
    internal class LivroSaldoService
    {
        private readonly LivroSaldoRepository _repo;
        private readonly DataBase _db;

        public LivroSaldoService(LivroSaldoRepository repo, DataBase db)
        {
            _repo = repo;
            _db = db;
        }


    }
}
