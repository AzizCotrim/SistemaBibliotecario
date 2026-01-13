using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Infrastructure.Database;
using System.Data;
namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class LivroSaldoRepository
    {
        private readonly DataBase _db = new DataBase();

        public void InserirLivros(int idLivro, int qtd)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                using SqlTransaction tra = con.BeginTransaction();

                try {
                    string sql = @"INSERT INTO BI_LIVRO_SALDO (LIV_ID, LIS_QTD)
                               VALUES (@id, @qtd)";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idLivro;
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

        public void GetQuantidade(int idLivro)
        {

        }

        public int UpdateQuantidade(int idLivro, int newQtd)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                using SqlTransaction tra = con.BeginTransaction();

                try {



                    tra.Commit();

                }catch(Exception ex) {
                    tra.Rollback();
                    throw;
                }
            }
        }

        public int RetirarUnidade(int idLivro)
        {
            using(SqlConnection con = _db.GetSqlConnection()) {
                using SqlTransaction tra = con.BeginTransaction();

                try {

                    int result;

                    string sql = @"UPDATE BI_LIVRO_SALDO
                                      SET LIS_QTD = LIS_QTD - 1
                                    WHERE LIV_ID = @id
                                      AND LIS_QTD >= 1";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idLivro;

                        result = cmd.ExecuteNonQuery();


                    }

                    tra.Commit();
                    return result;


                }catch (Exception ex) {
                    tra.Rollback();
                    throw;
                }
            }
        }

        public int AdicionarUnidade(int idLivro)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                using SqlTransaction tra = con.BeginTransaction();

                try {

                    string sql = @"UPDATE BI_LIVRO_SALDO
                                      SET LIS_QTD = LIS_QTD + 1
                                    WHERE LIV_ID = @id";

                    using(SqlCommand cmd = new SqlCommand(sql, con)) {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idLivro;
                    }

                    tra.Commit();

                } catch (Exception ex) {
                    tra.Rollback();
                    throw;
                }
            }
        }
    }
}
