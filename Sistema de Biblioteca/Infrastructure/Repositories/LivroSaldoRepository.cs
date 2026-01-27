using Microsoft.Data.SqlClient;
using System.Data;
namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class LivroSaldoRepository
    {
        public int InserirLivros(SqlConnection con, SqlTransaction tra, int idLivro, int qtd)
        {
            string sql = @"INSERT INTO BI_LIVRO_SALDO (LIV_ID, LIS_QTD)
                               VALUES (@Id, @Qtd)";

            using (SqlCommand cmd = new SqlCommand(sql, con, tra))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idLivro;
                cmd.Parameters.Add("@Qtd", SqlDbType.Int).Value = qtd;
                return cmd.ExecuteNonQuery();
            }

        }

        public int? GetQuantidade(SqlConnection con, int idLivro)
        {
            string sql = @"SELECT LIS_QTD
                             FROM BI_LIVRO_SALDO
                            WHERE LIV_ID = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, con))

            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idLivro;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        return dr.GetInt32(0);

                    return null;
                }

            }
        }

        public int UpdateQuantidade(SqlConnection con, SqlTransaction tra, int idLivro, int Qtd)
        {
            string sql = @"UPDATE BI_LIVRO_SALDO
                              SET LIS_QTD = @Qtd
                            WHERE LIV_ID = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, con, tra))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idLivro;
                cmd.Parameters.Add("@Qtd", SqlDbType.Int).Value = Qtd;

                return cmd.ExecuteNonQuery();
            }
        }

        public int RetirarUnidade(SqlConnection con, SqlTransaction tra, int idLivro)
        {

            string sql = @"UPDATE BI_LIVRO_SALDO
                              SET LIS_QTD = LIS_QTD - 1
                            WHERE LIV_ID = @Id
                              AND LIS_QTD >= 1";

            using (SqlCommand cmd = new SqlCommand(sql, con, tra))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idLivro;

                return cmd.ExecuteNonQuery();
            }

        }

        public int AdicionarUnidade(SqlConnection con, SqlTransaction tra, int idLivro)
        {

            string sql = @"UPDATE BI_LIVRO_SALDO
                              SET LIS_QTD = LIS_QTD + 1
                            WHERE LIV_ID = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, con, tra))
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idLivro;

                return cmd.ExecuteNonQuery();
            }

        }
    }
}
