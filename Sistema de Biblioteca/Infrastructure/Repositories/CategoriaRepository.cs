using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Categoria;
using Sistema_de_Biblioteca.Infrastructure.Database;
using System.Data;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class CategoriaRepository
    {
        private readonly DataBase _db = new DataBase();

        public bool ExisteCategoria(string nome)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                string sql = @"SELECT COUNT(*)
                                 FROM BI_CATEGORIAS
                                WHERE CAT_NOME LIKE @nome";

                using(SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.AddWithValue("@nome", nome);

                    int qtd = (int)cmd.ExecuteScalar();

                    return qtd > 0;
                }
            }
        }

        public List<Categoria> BuscarCategoriasSimples()
        {
            List<Categoria> list = new List<Categoria>();

            using (SqlConnection con = _db.GetSqlConnection()) {

                string sql = @"SELECT CAT_ID, CAT_NOME
                                 FROM BI_CATEGORIAS";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                using (SqlDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read()) {
                        int id = dr.GetInt32(0);
                        string nome = dr.GetString(1);

                        list.Add(new Categoria(id, nome));
                    }
                }
            }

            return list;
        }
        //Table-Valued Parameter (TVP)
        public List<Categoria> BuscarCategoriaFiltro(List<int> IdCategoria)
        {
            List<Categoria> list = new List<Categoria>();

            using (SqlConnection con = _db.GetSqlConnection()) {
                string sql = @"SELECT CAT_ID, CAT_NOME
                                 FROM BI_CATEGORIAS
                                WHERE CAT_ID IN (@IdCategoria)";

                using (SqlCommand cmd = new SqlCommand(sql,con)) {
                    cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = IdCategoria;
                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            int id = dr.GetInt32(0);
                            string nome = dr.GetString(1);

                            list.Add(new Categoria(id, nome));
                        }
                    }
                }
            }
            return list;
        }
    }
}
