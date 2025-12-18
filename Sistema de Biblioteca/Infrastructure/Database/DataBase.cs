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
    }
}
