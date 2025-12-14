using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Livro;
using Sistema_de_Biblioteca.Infrastructure.Database;
using System.Data;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class LivroRepository
    {
        private readonly DataBase _db = new DataBase();

        public bool ExisteLivro(string nome, string autor, int ano)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                string sql = @"SELECT COUNT(*)
                                 FROM BI_LIVROS 
                                WHERE LIV_NOME = @nome
                                  AND LIV_AUTOR = @autor
                                  AND LIV_DATA_LANCAMENTO = @ano";

                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.Add("@ano", SqlDbType.Int).Value = ano;

                    int qtd = (int)cmd.ExecuteScalar();

                    return qtd > 0;
                }
            }
        }

        public void CadastrarLivro(int categoria, string nome, string autor, int ano, int qtd)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                using SqlTransaction tra = con.BeginTransaction();

                try {
                    string sql = @"INSERT INTO BI_LIVROS (LIV_CAT_ID, LIV_NOME, LIV_AUTOR, LIC_DATA_LANCAMENTO, LIV_QUANTIDADE)
                               VALUES (@categoria, @nome, @autor, @ano, @qtd)";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = categoria;
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        cmd.Parameters.Add("@ano", SqlDbType.Int).Value = ano;
                        cmd.Parameters.Add("@qtd", SqlDbType.Int).Value = qtd;
                        cmd.ExecuteNonQuery();
                    }

                    tra.Commit();

                } catch (Exception ex) {
                    tra.Rollback();
                    throw;
                }
            }
        }

        public List<Livro> BuscarLivros()
        {
            List<Livro> lista = new List<Livro>();

            using(SqlConnection con = _db.GetSqlConnection()) {
                string sql = @"SELECT LIV_ID, LIV_CAT_ID, LIV_NOME, LIV_AUTOR,
                                      LIC_DATA_LANCAMENTO, LIV_QUANTIDADE
                                 FROM BI_LIVROS
                                ORDER BY 1";

                using(SqlCommand cmd = new SqlCommand(sql, con)) {
                    using(SqlDataReader dr = cmd.ExecuteReader()) {

                        while (dr.Read()) {
                            int id = dr.GetInt32(0);
                            int categoriaId = dr.GetInt32(1);
                            string titulo = dr.GetString(2);
                            string autor = dr.GetString(3);
                            int anoLancamento = dr.GetInt32(4);
                            int qtd = dr.GetInt32(5);

                            lista.Add(new Livro(id, categoriaId, titulo, autor, anoLancamento ,qtd));
                        }

                    }
                }
            }
            return lista;
        }

    }

}
