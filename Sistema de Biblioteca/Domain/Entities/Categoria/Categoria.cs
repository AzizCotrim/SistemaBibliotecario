using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Domain.Entities.Categoria
{
    internal class Categoria
    {
        public int Id;
        public string CategoriaName;

        public Categoria(int id, string categoriaName)
        {
            Id = id;
            CategoriaName = categoriaName;
        }
    }
}
