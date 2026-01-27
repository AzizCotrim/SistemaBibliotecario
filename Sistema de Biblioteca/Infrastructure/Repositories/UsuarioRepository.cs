using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Usuario;
using Sistema_de_Biblioteca.Infrastructure.Database;
using System.Data;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class UsuarioRepository
    {

        public bool ExisteLogin(SqlConnection con, string login)
        {
           string sql = @"SELECT COUNT(*)
                                 FROM BS_USUARIOS
                                WHERE UPPER(USU_LOGIN) = @login";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@login", login.ToUpper());

                    int qtd = (int)cmd.ExecuteScalar();

                    return qtd > 0;
                }
            
        }
        // SUBSTITUIR PELO DTO UsuarioCreateRequest
        public int CadastrarUsuario(SqlConnection con, SqlTransaction tra, string name, int cargo, string login, byte[] salt, string hash)
        {
            string sql = @"INSERT INTO BS_USUARIOS (USU_PERM_ID, USU_NOME, USU_LOGIN, USU_SALT, USU_HASH) 
                                   VALUES (@cargo, @name, @login, @salt, @hash)";

            using (SqlCommand cmd = new SqlCommand(sql, con, tra))
            {
                cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = cargo;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.Add("@salt", SqlDbType.VarBinary, 32).Value = salt;
                cmd.Parameters.AddWithValue("@hash", hash);
                return cmd.ExecuteNonQuery();
            }
        }

        public Usuario? GetUsuarioPorLogin(SqlConnection con, string login)
        {
            string sql = @"SELECT USU_ID, USU_NOME, USU_SALT, USU_HASH, USU_PERM_ID
                                 FROM BS_USUARIOS
                                WHERE USU_LOGIN = @login";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@login", login);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {

                        int vId = dr.GetInt32(0);
                        string vNome = dr.GetString(1);
                        byte[] vSalt = dr.GetFieldValue<byte[]>(2);
                        string vHash = dr.GetString(3);
                        int vPerm = dr.GetInt32(4);

                        return new Usuario(vId, vNome, login, vSalt, vHash, vPerm);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
