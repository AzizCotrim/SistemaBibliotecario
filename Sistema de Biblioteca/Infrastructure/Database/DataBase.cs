using Microsoft.Data.SqlClient;

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
            return conn;
        }
    }
}
