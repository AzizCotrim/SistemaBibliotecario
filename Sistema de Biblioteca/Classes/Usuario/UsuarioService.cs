using Sistema_de_Biblioteca.Classes.Verificacoes;

namespace Sistema_de_Biblioteca.Classes.Usuario
{
    internal class UsuarioService
    {

        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public void VerificarExisteLogin(string login)
        {
            if (_repository.ExisteLogin(login)) {
                throw new Exception("O Login ja esta sendo utilizado");
            }
        }

        public bool VerificarLenFormatLogin(string login)
        {
            bool tamanhoOk = login.Length >= 5;
            bool formatoOk = login.All(c => char.IsLetterOrDigit(c));

            return tamanhoOk && formatoOk;
        }


        public bool VerificarRequisitosSenha(string pw)
        {
            bool len = pw.Length >= 4;
            bool temMaiuscula = pw.Any(c => char.IsUpper(c));
            bool temMinuscula = pw.Any(c => char.IsLower(c));
            bool temNumero = pw.Any(c => char.IsDigit(c));
            bool temEspecial = pw.Any(c => !char.IsLetterOrDigit(c));

            bool senhaOk = len
                        && temMaiuscula
                        && temMinuscula
                        && temNumero
                        && temEspecial;

            return senhaOk;
        }

        public void CadastrarUsuario(string name, int cargo, string login, string pw)
        {
            VerificarExisteLogin(login);

            if (!VerificarLenFormatLogin(login)) {
                throw new Exception("O login deve conter apenas letras e numeros");

            } else if (!VerificarRequisitosSenha(pw)) {
                throw new Exception("A senha nao cumpre os requisitos minimos");

            }

            byte[] salt = PasswordService.GerarSalt();
            string hash = PasswordService.GerarHash(pw, salt);

            _repository.CriarUsuario(name, cargo, login, salt, hash);

        }

        public void LoginUsuario(string login, string senha)
        {

            Usuario user = _repository.GetUsuarioPorLogin(login);

            if (user == null) {
                throw new Exception("Login inexistente");
            }

            string hashTest = PasswordService.GerarHash(senha, user.GetSalt());

            if (user.GetHash() != hashTest) {
                throw new Exception("Senha incorreta");
            }

        }
    }
}
