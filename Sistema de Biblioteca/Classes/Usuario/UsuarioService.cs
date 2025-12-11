namespace Sistema_de_Biblioteca.Classes.Usuario
{
    internal class UsuarioService
    {
        public bool VerificarLogin(string login)
        {
            if (login.Length >= 8) {

                for (int i = 0; i < login.Length; i++) {
                    if (i == 0 && !char.IsLetter(login[i])) {
                        return false;
                    }

                    if (!char.IsLetterOrDigit(login[i]))
                        return false;
                }

                return true;

            } else {
                return false;
            }
        }
        //FAZER A VERIFICACAO DEPOIS DE CADASTRAR A SENHA 1234
        public bool VerificarSenha(string pw)
        {
            if (pw.Length >= 8) {
                int low = 0;
                int upp = 0;
                int num = 0;
                int esp = 0;

                for (int i = 0; i < pw.Length; i++) {
                    if (i == 0 && char.IsLetter(pw[i])) {
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

    }
}
