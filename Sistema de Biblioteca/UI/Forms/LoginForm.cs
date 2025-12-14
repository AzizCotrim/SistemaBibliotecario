using Sistema_de_Biblioteca.Application.Sevices;
using Sistema_de_Biblioteca.Classes;
using Sistema_de_Biblioteca.Infrastructure.Repositories;
namespace Sistema_de_Biblioteca
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        private UsuarioRepository _usuarioRepository;
        private UsuarioService _usuarioService;

        public LoginForm()
        {
            InitializeComponent();

            _usuarioRepository = new UsuarioRepository();
            _usuarioService = new UsuarioService(_usuarioRepository);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPass.Text;

            if (login != "" && password != "") {

                try {

                    _usuarioService.LoginUsuario(login, password);
                    txtLogin.Clear();
                    txtPass.Clear();
                    MessageBox.Show("O usuario entrou",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }


            } else {
                MessageBox.Show("O login ou a senha nao pode ser vazios");
            }
        }

        
    }
}
