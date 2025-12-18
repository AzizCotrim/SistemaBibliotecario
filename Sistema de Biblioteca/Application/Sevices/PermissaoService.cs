using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Biblioteca.Domain.Entities.Permissao;
using Sistema_de_Biblioteca.Infrastructure.Repositories;
namespace Sistema_de_Biblioteca.Application.Sevices
{
    internal class PermissaoService
    {
        private readonly PermissaoRepository _repository;

        public PermissaoService(PermissaoRepository repository)
        {
            _repository = repository;
        }

        public List<Permissao> BuscarPerm()
        {
            List<Permissao> list = _repository.BuscarPermissoes();

            return list;
        }

    }
}
