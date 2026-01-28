using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Livro;
using Sistema_de_Biblioteca.Infrastructure.Database;
using System.Data;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class LivroRepository
    {

        public bool ExisteLivro(SqlConnection con, string titulo, string autor, int? dataLancamento)
        {

            string sql = @"SELECT COUNT(*)
                                 FROM BI_LIVROS 
                                WHERE LIV_NOME = @nome
                                  AND LIV_AUTOR = @autor
                                  AND LIV_DATA_LANCAMENTO = @ano";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nome", titulo);
                cmd.Parameters.AddWithValue("@autor", autor);
                cmd.Parameters.Add("@ano", SqlDbType.Int).Value = dataLancamento;

                int qtd = (int)cmd.ExecuteScalar();

                return qtd > 0;
            }
        }

        public void CadastrarLivro(SqlConnection con, SqlTransaction tra, Livro livro)
        {

            string sql = @"INSERT INTO BI_LIVROS (LIV_CAT_ID, LIV_NOME, LIV_AUTOR, LIC_DATA_LANCAMENTO)
                               VALUES (@categoria, @titulo, @autor, @ano)";

            using (SqlCommand cmd = new SqlCommand(sql, con, tra))
            {
                cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = livro.Categoria;
                cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
                cmd.Parameters.AddWithValue("@autor", livro.Autor);
                cmd.Parameters.Add("@ano", SqlDbType.Int).Value = livro.DataLancamento;
                cmd.ExecuteNonQuery();
            }

        }

        public List<Livro> BuscarLivros(SqlConnection con, int orderBy)
        {
            List<Livro> list = new List<Livro>();

            string orderBySql;

            switch (orderBy)
            {
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


            string sql = $@"SELECT LIV_ID, LIV_CAT_ID, LIV_NOME, LIV_AUTOR,
                                      LIV_DATA_LANCAMENTO
                                 FROM BI_LIVROS
                                ORDER BY {orderBySql}";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        int id = dr.GetInt32(0);
                        int categoriaId = dr.GetInt32(1);
                        string titulo = dr.GetString(2);
                        string autor = dr.GetString(3);
                        int anoLancamento = dr.GetInt32(4);

                        list.Add(new Livro(id, categoriaId, titulo, autor, anoLancamento));
                    }

                }
            }

            return list;
        }

        public List<Livro> FiltrarLivros(SqlConnection con, string filtro)
        {
            List<Livro> list = new List<Livro>();


            string sql = $@"SELECT LIV_ID, LIV_CAT_ID, LIV_NOME, LIV_AUTOR,
                                      LIV_DATA_LANCAMENTO
                                 FROM BI_LIVROS
                                WHERE 1 = 1
                                  {filtro}";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = dr.GetInt32(0);
                        int categoriaId = dr.GetInt32(1);
                        string titulo = dr.GetString(2);
                        string autor = dr.GetString(3);
                        int anoLancamento = dr.GetInt32(4);

                        list.Add(new Livro(id, categoriaId, titulo, autor, anoLancamento));
                    }
                }
            }

            return list;
        }

    }

}
