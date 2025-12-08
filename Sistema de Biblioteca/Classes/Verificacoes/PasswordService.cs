using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Classes.Verificacoes
{
    internal class PasswordService
    {
        public static byte[] GerarSalt(int tamanho = 16)
        {
            byte[] salt = new byte[tamanho];
            RandomNumberGenerator.Fill(salt);
            return salt;
        }

        public static string GerarHash(string senha, byte[] salt)
        {
            byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);
            byte[] senhaCSalt = new byte[senhaBytes.Length + salt.Length];

            Buffer.BlockCopy(senhaBytes, 0, senhaCSalt, 0, senhaBytes.Length);
            Buffer.BlockCopy(salt, 0, senhaCSalt, senhaBytes.Length, salt.Length);

            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(senhaCSalt);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static bool CheckHash(string pass, byte[] salt, string hash)
        {
            string check = GerarHash(pass, salt);

            if (hash == check)
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
