using Sistema_de_Biblioteca.Classes.Database;
using Sistema_de_Biblioteca.Classes.Usuario;
using Sistema_de_Biblioteca.Classes.Verificacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Biblioteca
{
    public partial class CadastroDeUsuario : Form
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

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {

            var permissoes = _db.BuscarPemissoes();

            comboPermissao.DataSource = permissoes;
            comboPermissao.DisplayMember = "Cargo";
            comboPermissao.ValueMember = "Id";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int permissao = (int)comboPermissao.SelectedValue;
            string login = textBox2.Text;
            string senha = textBox3.Text;



            _usuarioService.CadastrarUsuario(name, permissao, login, senha);
        }
    }
}
