using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Categoria;
using Sistema_de_Biblioteca.Domain.Exceptions;
using Sistema_de_Biblioteca.Infrastructure.Database;
using Sistema_de_Biblioteca.Infrastructure.Repositories;

namespace Sistema_de_Biblioteca.Application.Sevices
{
    internal class CategoriaService
    {
        private readonly CategoriaRepository _repo;
        private readonly DataBase _db;

        public CategoriaService(CategoriaRepository repo, DataBase db)
        {
            _repo = repo;
            _db = db;
        }

        public string NormalizeNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return string.Empty;

            return string.Join(" ",nome.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }

        public bool VerificarCaracteres(string nomeNormalizado)
        {
            if (string.IsNullOrWhiteSpace(nomeNormalizado))
                return false;

            bool tamanhoMinimo = nomeNormalizado.Length >= 4;
            bool contemLetra = nomeNormalizado.Any(c => char.IsLetter(c));
            bool apenasCaracteresPermitidos = nomeNormalizado.All(c => char.IsLetterOrDigit(c) || c == ' ' || c == '-');

            return tamanhoMinimo && contemLetra && apenasCaracteresPermitidos;
        }

        public void CriarCategoria(string nome, string descricao)
        {
            using (SqlConnection con = _db.GetSqlConnection())
            {
                con.Open();

                using (SqlTransaction tra = con.BeginTransaction())
                {
                    try
                    {
                        string nomeNormalizado = NormalizeNome(nome);

                        if (!VerificarCaracteres(nomeNormalizado))
                            throw new ArgumentException("Nome da categoria inválido", nameof(nome));

                        if (_repo.ExisteCategoria(con, tra, nomeNormalizado))
                        {
                            throw new BusinessException("A categoria ja foi cadastrada");
                        }


                        Categoria categoria = new Categoria(nomeNormalizado, descricao);
                        _repo.CadastrarCategoria(con, tra, categoria);

                        tra.Commit();

                    }
                    catch
                    {
                        tra.Rollback();
                        throw;
                    }
                }
            }

        }

        //Trocar Para CategoriaResponse
        public List<Categoria> BuscarCategoriasSimples()
        {
            using (SqlConnection con = _db.GetSqlConnection())
            {
                con.Open();

                return _repo.BuscarCategoriasSimples(con);
            }
        }

        public List<Categoria> BuscarCategoriaFiltro(List<int> idCategoria)
        {
            using (SqlConnection con = _db.GetSqlConnection())
            {
                con.Open();

                if(idCategoria == null || idCategoria.Count == 0)
                    return _repo.BuscarCategoriasSimples(con);

                return _repo.BuscarCategoriaFiltro(con, idCategoria);

            }
        }
    }
}
