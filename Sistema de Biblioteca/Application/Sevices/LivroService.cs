using Sistema_de_Biblioteca.Application.DTOs;
using Sistema_de_Biblioteca.Domain.Entities.Livro;
using Sistema_de_Biblioteca.Infrastructure.Repositories;

namespace Sistema_de_Biblioteca.Application.Sevices
{
    internal class LivroService
    {
        private readonly LivroRepository _repository;

        public LivroService(LivroRepository repository)
        {
            _repository = repository;
        }

        public void VerificarExisteLivro(string titulo, string autor, int? dataLancamento)
        {
            if (_repository.ExisteLivro(titulo, autor, dataLancamento)) {
                throw new Exception("O livro já foi cadastrado!");
            }
        }

        public bool VerificarRequisitosTitulo(string titulo)
        {
            bool whiteSpace = !string.IsNullOrWhiteSpace(titulo);
            bool tituloOk = whiteSpace;

            return tituloOk;
        }

        public bool VerificarRequisitosAutor(string autor)
        {
            char[] simbolosPermitidos = { ' ', '.', ',', ':', '-', '\'' };

            bool semEspecial = true;
            bool whiteSpace = !string.IsNullOrWhiteSpace(autor);

            foreach (char l in autor) {

                if (char.IsLetter(l))
                    continue;

                if (simbolosPermitidos.Contains(l))
                    continue;

                semEspecial = false;
            }

            bool autorOk = whiteSpace
                        && semEspecial;

            return autorOk;
        }

        /*FAZER AS VERIFICACOES DE ESCRITA (SIMB E WHITE SPACES)*/
        public void CadastroDeLivro(int categoria, string titulo, string autor, int? dataLancamento, int qtd)
        {

            VerificarExisteLivro(titulo, autor, dataLancamento);

            if (!VerificarRequisitosTitulo(titulo))
                throw new Exception("O titulo do Livro nao pode estar vazio ou conter apenas espaços");

            if (!VerificarRequisitosAutor(autor))
                throw new Exception("O nome do autor nao pode estar vazio, conter apenas espaços ou qualquer simbolo");

            Livro livro = new Livro(categoria, titulo, autor, dataLancamento);

            //_repository.CadastrarLivro(livro);

        }
        /**/
        public List<Livro> BuscarTodosLivros(int orderBy)
        {
            List<Livro> list = _repository.BuscarLivros(orderBy);

            return list;
        }

        public List<Livro> FiltrarBuscaLivros(PedidoBuscaLivro pedidoBusca)
        {
            string filtro = "";

            List<Livro> list = _repository.FiltrarLivros(filtro);



            return list;
        }

    }
}
