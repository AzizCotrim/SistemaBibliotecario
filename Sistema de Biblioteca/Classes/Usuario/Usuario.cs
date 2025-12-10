using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sistema_de_Biblioteca.Classes.Usuario
{
    internal class Usuario
    {
        public int Id { get; }
        public string Name { get; }
        public string Login { get; }
        private byte[] _Salt { get; }
        private string _Hash { get; }
        public int Permission { get; }

        public Usuario(string name, string login, byte[] salt, string hash, int permission)
        {
            Name = name;
            Login = login;
            _Salt = salt;
            _Hash = hash;
            Permission = permission;
        }

        public Usuario(int id, string name, string login, byte[] salt, string hash, int permission)
        {
            Id = id;
            Name = name;
            Login = login;
            _Salt = salt;
            _Hash = hash;
            Permission = permission;
        }

        public byte[] GetSalt()
        {
            return (byte[])_Salt.Clone();
        }

        public string GetHash()
        {
            return _Hash;
        }
    }
}
