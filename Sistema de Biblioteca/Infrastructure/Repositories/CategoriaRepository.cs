using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Categoria;
using Sistema_de_Biblioteca.Infrastructure.Database;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class CategoriaRepository
    {
        private readonly DataBase _db = new DataBase();

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
    }
}
