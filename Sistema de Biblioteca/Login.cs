using Sistema_de_Biblioteca.Classes;
using Sistema_de_Biblioteca.Classes.Usuario;
namespace Sistema_de_Biblioteca
{
    public partial class Login : Form
    {
        private UsuarioRepository _usuarioRepository;
        private UsuarioService _usuarioService;

        public Login()
        {
            InitializeComponent();

            _usuarioRepository = new UsuarioRepository();
            _usuarioService = new UsuarioService(_usuarioRepository);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = textPass.Text;

            if (login != "" && password != "") {

                try {

                    _usuarioService.LoginUsuario(login, password);
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
