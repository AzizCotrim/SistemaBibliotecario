using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Permissao;
using Sistema_de_Biblioteca.Infrastructure.Database;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class PermissaoRepository
    {

        public List<Permissao> BuscarPermissoes(SqlConnection con)
        {
            List<Permissao> list = new List<Permissao>();

            string sql = "SELECT PERM_ID, PERM_CARGO FROM BS_PERMISSOES";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string cargo = dr.GetString(1);

                    list.Add(new Permissao(id, cargo));
                }
            }

            return list;
        }
    }
}
