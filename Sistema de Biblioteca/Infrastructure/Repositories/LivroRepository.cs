using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Livro;
using Sistema_de_Biblioteca.Infrastructure.Database;
using Sistema_de_Biblioteca.Application.DTOs;
using System.Data;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class LivroRepository
    {
        private readonly DataBase _db = new DataBase();

        public bool ExisteLivro(string titulo, string autor, int? dataLancamento)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                string sql = @"SELECT COUNT(*)
                                 FROM BI_LIVROS 
                                WHERE LIV_NOME = @nome
                                  AND LIV_AUTOR = @autor
                                  AND LIV_DATA_LANCAMENTO = @ano";

                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.AddWithValue("@nome", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.Add("@ano", SqlDbType.Int).Value = dataLancamento;

                    int qtd = (int)cmd.ExecuteScalar();

                    return qtd > 0;
                }
            }
        }

        public void CadastrarLivro(Livro livro)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                using SqlTransaction tra = con.BeginTransaction();

                try {
                    string sql = @"INSERT INTO BI_LIVROS (LIV_CAT_ID, LIV_NOME, LIV_AUTOR, LIC_DATA_LANCAMENTO)
                               VALUES (@categoria, @titulo, @autor, @ano)";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = livro.Categoria;
                        cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
                        cmd.Parameters.AddWithValue("@autor", livro.Autor);
                        cmd.Parameters.Add("@ano", SqlDbType.Int).Value = livro.DataLancamento;
                        cmd.ExecuteNonQuery();
                    }

                    tra.Commit();

                } catch (Exception ex) {
                    tra.Rollback();
                    throw;
                }
            }
        }

        public List<Livro> BuscarLivros(int orderBy)
        {
            List<Livro> list = new List<Livro>();

            string orderBySql;

            switch (orderBy) {
                case (1):
                    orderBySql = "LIV_CAT_ID";
                    break;

                case (2):
                    orderBySql = "LIV_NOME";
                    break;

                case (3):
                    orderBySql = "LIV_AUTOR";
                    break;

                case (4):
                    orderBySql = "LIV_DATA_LANCAMENTO";
                    break;

                default:
                    orderBySql = "LIV_ID";
                    break;
            }

            using (SqlConnection con = _db.GetSqlConnection()) {
                string sql = $@"SELECT LIV_ID, LIV_CAT_ID, LIV_NOME, LIV_AUTOR,
                                      LIV_DATA_LANCAMENTO
                                 FROM BI_LIVROS
                                ORDER BY {orderBySql}";

                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    using (SqlDataReader dr = cmd.ExecuteReader()) {

                        while (dr.Read()) {
                            int id = dr.GetInt32(0);
                            int categoriaId = dr.GetInt32(1);
                            string titulo = dr.GetString(2);
                            string autor = dr.GetString(3);
                            int anoLancamento = dr.GetInt32(4);

                            list.Add(new Livro(id, categoriaId, titulo, autor, anoLancamento));
                        }

                    }
                }
            }
            return list;
        }

        public List<Livro> FiltrarLivros(string filtro)
        {
            List<Livro> list = new List<Livro>();

            using (SqlConnection con = _db.GetSqlConnection()) {
                string sql = $@"SELECT LIV_ID, LIV_CAT_ID, LIV_NOME, LIV_AUTOR,
                                      LIV_DATA_LANCAMENTO
                                 FROM BI_LIVROS
                                WHERE 1 = 1
                                  {filtro}";

                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    /*cmd.Parameters.Add("@id", SqlDbType.Int).Value = ;
                    cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = ;
                    cmd.Parameters.AddWithValue("@titulo", "%" +  + "%");
                    cmd.Parameters.AddWithValue("@autor", "%" +  + "%");
                    cmd.Parameters.Add("@dataLancamento", SqlDbType.Int).Value = livro.DataLancamento;*/

                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            int id = dr.GetInt32(0);
                            int categoriaId = dr.GetInt32(1);
                            string titulo = dr.GetString(2);
                            string autor = dr.GetString(3);
                            int anoLancamento = dr.GetInt32(4);

                            list.Add(new Livro(id, categoriaId, titulo, autor, anoLancamento));
                        }
                    }
                }
            }
            return list;
        }

    }

}
