using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Classes.Database;
using Sistema_de_Biblioteca.Classes.Verificacoes;
using System.Data;

namespace Sistema_de_Biblioteca.Classes.Usuario
{
    internal class UsuarioRepository
    {
        private readonly DataBase _db = new DataBase();

        public bool ExisteLogin(string login)
        {
            using (SqlConnection con = _db.GetSqlConnection()) {
                string sql = @"SELECT COUNT(*) FROM BS_USUARIOS WHERE UPPER(USU_LOGIN) = @login";

                using (SqlCommand cmd = new SqlCommand(sql,con)) {
                    cmd.Parameters.AddWithValue("@login", login.ToUpper());

                    int quant = (int)cmd.ExecuteScalar();

                    return quant > 0;
                }
            }
        }

        public void CriarUsuario(string name, int cargo, string login, byte[] salt, string hash)
        {
            

            using (SqlConnection con = _db.GetSqlConnection()) {
                SqlTransaction tra = con.BeginTransaction();

                try {
                    string sql = @"INSERT INTO BS_USUARIOS(USU_PERM_ID, USU_NOME, USU_LOGIN, USU_SALT, USU_HASH) VALUES(@cargo, @name, @login, @salt, @hash)";

                    using (SqlCommand cmd = new SqlCommand(sql, con, tra)) {
                        cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = cargo;
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.Add("@salt", SqlDbType.VarBinary, 32).Value = salt;
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.ExecuteNonQuery();
                    }

                    tra.Commit();

                } catch (Exception ex) {
                    tra.Rollback();
                    throw;
                }
            }
        }

        public Usuario GetUsuarioPorLogin(string login)
        {

            using (SqlConnection con = _db.GetSqlConnection()) {

                string sql = @"SELECT USU_ID, USU_NOME, USU_SALT, USU_HASH, USU_PERM_ID FROM BS_USUARIOS WHERE USU_LOGIN = @login";

                using (SqlCommand cmd = new SqlCommand(sql, con)) {
                    cmd.Parameters.AddWithValue("@login", login);

                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        if (dr.Read()) {
                            //preciso mesmo trazer o login de novo?
                            int vId = dr.GetInt32(0);
                            string vNome = dr.GetString(1);
                            byte[] vSalt = dr.GetFieldValue<byte[]>(2);
                            string vHash = dr.GetString(3);
                            int vPerm = dr.GetInt32(4);

                            return new Usuario(vId, vNome, login, vSalt, vHash, vPerm);
                        }
                    }
                }
            }
            return null;
        }

        public bool VerificarSenha(string login, string senha)
        {

            Usuario user = GetUsuarioPorLogin(login);

            if (user == null) {
                return false;
            }

            string hashTest = PasswordService.GerarHash(senha, user.GetSalt());

            return user.GetHash() == hashTest;



        }
    }
}
