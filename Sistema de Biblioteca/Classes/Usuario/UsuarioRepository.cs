using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Classes.Database;
using Sistema_de_Biblioteca.Classes.Verificacoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Classes.Usuario
{
    internal class UsuarioRepository
    {
        private static readonly DataBase _db = new DataBase();

        public static bool LoginExistente(string login)
        {
            using (SqlConnection con = _db.GetSqlConnection())
            {
                string sql = "SELECT 1 FROM BS_USUARIOS WHERE USU_LOGIN = @login";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        return dr.Read();
                    }
                }
            }
        }

        public static void CriarUsuario(string name, int cargo, string login, string passw)
        {
            byte[] salt = PasswordService.GerarSalt();
            string hash = PasswordService.GerarHash(passw, salt);

            using (SqlConnection con = _db.GetSqlConnection())
            {

                string sql = @"INSERT INTO BS_USUARIOS(USU_PERM_ID, USU_NOME, USU_LOGIN, USU_SALT, USU_HASH) VALUES(@cargo, @name, @login, @salt, @hash)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = cargo;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.Add("@salt", SqlDbType.VarBinary, 32).Value = salt;
                    cmd.Parameters.AddWithValue("@hash", hash);
                }

            }
        }

        public static Usuario GetUsuarioPorLogin(string login)
        {

            using (SqlConnection con = _db.GetSqlConnection())
            {
                string sql = @"SELECT USU_ID, USU_NOME, USU_LOGIN, USU_SALT, USU_HASH, USU_PERM_ID FROM BS_USUARIOS WHERE USU_LOGIN = @login";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            //preciso mesmo trazer o login de novo?
                            int vId = dr.GetInt32(0);
                            string vNome = dr.GetString(1);
                            string vLogin = dr.GetString(2);
                            byte[] vSalt = dr.GetFieldValue<byte[]>(3);
                            string vHash = dr.GetString(4);
                            int vPerm = dr.GetInt32(5);

                            return new Usuario(vId, vNome, vLogin, vSalt, vHash, vPerm);
                        }                   
                    }
                }
            }
            return null;
        }

        public static bool VerificarSenha(Usuario user)
        {

        }

    }
}
