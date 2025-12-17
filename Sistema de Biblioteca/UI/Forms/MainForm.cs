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
    public partial class MainForm : System.Windows.Forms.Form
    {

        private Form _formAtual;

        public MainForm()
        {
            InitializeComponent();
        }

        public void AbrirTela(Form tela)
        {
            if (_formAtual != null) {
                _formAtual.Close();
            }

            _formAtual = tela;

            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(tela);

            tela.Show();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            AbrirTela(new CadastroDeUsuarioForm());
        }

        private void buttonLivros_Click(object sender, EventArgs e)
        {
            AbrirTela(new CadastroDeLivroForm());
        }

        private void buttonListagem_Click(object sender, EventArgs e)
        {
            AbrirTela(new ListagemForm());
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            AbrirTela(new CadastroDeUsuarioForm());
        }
    }
}
