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
        public string Name { get; }
        private byte[] _Salt { get; set; }
        private string _Hash { get; set; }

        public int Permission { get; }

        public Usuario(string name, byte[] salt, string hash, int permission)
        {
            Name = name;
            _Salt = salt;
            _Hash = hash;
            Permission = permission;
        }

        

        public override string ToString()
        {
            return $"Nome: {Name}";
        }
    }
}
