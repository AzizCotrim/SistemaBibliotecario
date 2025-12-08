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

        public CadastroDeUsuario()
        {
            InitializeComponent();

            _db = new DataBase();
        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {

            var permissoes = _db.BuscarPemissoes();

            foreach (var x in permissoes)
            {
                MessageBox.Show(x.ToString());
            }

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

           

            MessageBox.Show($"nome: {name}; permissao{permissao}; login{login}; senha:{senha};");
        }
    }
}
