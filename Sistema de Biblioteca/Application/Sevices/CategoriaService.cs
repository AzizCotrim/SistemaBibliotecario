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

        public void CriarCategoria(int id, string nome, string descricao)
        {
            if (_repository.ExisteCategoria(nome)) {
                throw new Exception("A categoria ja foi cadastrada");
            }

            Categoria categoria = new Categoria(nome, descricao);
            _repository.CadastrarCategoria(categoria);

        }

        public List<Categoria> BuscarCategoriasSimples()
        {
            List<Categoria> list = _repository.BuscarCategoriasSimples();

            return list;
        }

        public List<Categoria> BuscarCategoriaFiltro(List<int> idCategoria)
        {
            List<Categoria> list = _repository.BuscarCategoriaFiltro(idCategoria);

            return list;
        }
    }
}
