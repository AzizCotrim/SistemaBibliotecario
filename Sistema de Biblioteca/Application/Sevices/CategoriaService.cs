using Sistema_de_Biblioteca.Domain.Entities.Categoria;
using Sistema_de_Biblioteca.Infrastructure.Repositories;

namespace Sistema_de_Biblioteca.Application.Sevices
{
    internal class CategoriaService
    {
        private readonly CategoriaRepository _repository;

        public CategoriaService(CategoriaRepository repository)
        {
            _repository = repository;
        }

        public List<Categoria> BuscarCategoriasSimples()
        {
            List<Categoria> list = _repository.BuscarCategoriasSimples();

            return list;
        }

    }
}
