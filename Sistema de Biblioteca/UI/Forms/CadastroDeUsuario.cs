using Sistema_de_Biblioteca.Application.Sevices;
using Sistema_de_Biblioteca.Infrastructure.Database;
using Sistema_de_Biblioteca.Infrastructure.Repositories;

namespace Sistema_de_Biblioteca
{
    public partial class CadastroDeUsuario : System.Windows.Forms.Form
    {
        private DataBase _db;
        private UsuarioService _usuarioService;
        private UsuarioRepository _usuarioRepository;

        public CadastroDeUsuario()
        {
            InitializeComponent();

            _db = new DataBase();
            _usuarioRepository = new UsuarioRepository();
            _usuarioService = new UsuarioService(_usuarioRepository);
        }

        private void LimparCampos()
        {
            txtName.Clear();
            txtlogin.Clear();
            txtpassword.Clear();
            comboPermissao.SelectedIndex = 0;
        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {

            var permissoes = _db.BuscarPemissoes();

            comboPermissao.DataSource = permissoes;
            comboPermissao.DisplayMember = "Cargo";
            comboPermissao.ValueMember = "Id";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int permissao = (int)comboPermissao.SelectedValue;
            string login = txtlogin.Text;
            string senha = txtpassword.Text;

            try {

                _usuarioService.CadastrarUsuario(name, permissao, login, senha);
                MessageBox.Show("Cadastro efetuado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                LimparCampos();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                txtpassword.Clear();
            }
        }
    }
}
