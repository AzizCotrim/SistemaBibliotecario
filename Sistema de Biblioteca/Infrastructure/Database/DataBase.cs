using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Permissao;

namespace Sistema_de_Biblioteca.Infrastructure.Database
{
    internal class DataBase
    {
        private readonly string _conn;

        public DataBase()
        {
            _conn = "Server=localhost,1433;Database=S_Biblioteca;User Id=sa;Password=Root123!@;TrustServerCertificate=True";
        }

        public SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(_conn);
            conn.Open();
            return conn;
        }   

        public List<Permissao> BuscarPemissoes()
        {
            List<Permissao> lista = new List<Permissao>();

            using (SqlConnection con = GetSqlConnection())
            {

                string sql = "SELECT PERM_ID, PERM_CARGO FROM BS_PERMISSOES";


                using (SqlCommand cmd = new SqlCommand(sql, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = dr.GetInt32(0);
                        string cargo = dr.GetString(1);

                        lista.Add(new Permissao(id, cargo));
                    }
                }
            }

            return lista;
        }

    }
}
