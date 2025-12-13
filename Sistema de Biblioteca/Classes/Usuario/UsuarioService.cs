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

        public void VerificarLogin(string login)
        {
            if (login.Length >= 3) {

                for (int i = 0; i < login.Length; i++) {
                    if (i == 0 && !char.IsLetter(login[i])) {
                        throw new Exception("O Login deve comecar com uma letra");
                    }

                    if (!char.IsLetterOrDigit(login[i])) {
                        throw new Exception("O Login nao deve possuir caractere especial");
                    }
                }

                if (_repository.ExisteLogin(login)) {
                    throw new Exception("O Login ja esta sendo utilizado");
                }

            } else {
                throw new Exception("Login precisa ter no minimo 8 caracteres");
            }
        }
        
        public bool VerificarSenha(string pw)
        {
            //MELHORAR ESSA FUNCAO, AINDA ESTA RUIM
            if (pw.Length >= 8) {
                int low = 0;
                int upp = 0;
                int num = 0;
                int esp = 0;

                for (int i = 0; i < pw.Length; i++) {
                    if (i == 0 && !char.IsLetter(pw[i])) {
                        return false;
                    }

                    if (char.IsLower(pw[i])) {
                        low++;

                    } else if (char.IsUpper(pw[i])) {
                        upp++;

                    } else if (char.IsNumber(pw[i])) {
                        num++;

                    } else {
                        esp++;
                    }

                }

                if (low == 0 || upp == 0 || num == 0 || esp == 0) {
                    return false;
                }

                return true;

            } else {
                return false;
            }
        }

        public void CadastrarUsuario(string name, int cargo, string login , string pw)
        {
            try {

                //VerificarLogin(login);

                //if (VerificarSenha(pw)) {

                    byte[] salt = PasswordService.GerarSalt();
                    string hash = PasswordService.GerarHash(pw, salt);

                    _repository.CriarUsuario(name, cargo, login, salt, hash);

                /*} else {
                    throw new Exception("A senha nao obedece aos requisitos minimos");
                }*/

            } catch (Exception ex) {
                MessageBox.Show($"Erro: {ex}");
            }
        }

        public void LoginUsuario(string)
        {

        }

    }
}
