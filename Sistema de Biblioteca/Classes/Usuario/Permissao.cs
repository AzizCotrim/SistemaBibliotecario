using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Classes.Usuario
{
    internal class Permissao
    {
        public int Id { get; set; }
        public string Cargo { get; set; }

        public Permissao(int id, string cargo)
        {
            Id = id;
            Cargo = cargo;
        }

        public override string ToString()
        {
            return $"Id: {Id} , Cargo: {Cargo}";
        }
    }
}
