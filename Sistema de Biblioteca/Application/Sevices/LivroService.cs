using Sistema_de_Biblioteca.Domain.Entities.Livro;
using Sistema_de_Biblioteca.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca.Application.Sevices
{
    internal class LivroService
    {
        private readonly LivroRepository _repository;

        public LivroService(LivroRepository repository)
        {
            _repository = repository;
        }

        public void CadastroDeLivro(int categoria, string titulo, string autor, int dataLancamento, int qtd)
        {
            
            if (_repository.ExisteLivro(titulo, autor, dataLancamento)) {
                throw new Exception("O livro já foi cadastrado!");
            }
            
            Livro livro = new Livro(categoria, titulo, autor, dataLancamento, qtd);

            _repository.CadastrarLivro(livro);

        }

    }
}
