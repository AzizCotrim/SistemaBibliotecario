using Sistema_de_Biblioteca.Application.Sevices;
using Sistema_de_Biblioteca.Infrastructure.Database;
using Sistema_de_Biblioteca.Infrastructure.Repositories;

namespace Sistema_de_Biblioteca
{
    public partial class CadastroDeLivroForm : System.Windows.Forms.Form
    {
        private DataBase _db;
        private CategoriaRepository _categoriaRepository;
        private CategoriaService _categoriaService;
        private LivroRepository _livroRepository;
        private LivroService _livroService;

        public CadastroDeLivroForm()
        {
            InitializeComponent();

            _categoriaRepository = new CategoriaRepository();
            _categoriaService = new CategoriaService(_categoriaRepository);
            _livroRepository = new LivroRepository();
            _livroService = new LivroService(_livroRepository);
        }

        private void LimparCampos()
        {
            textBoxTitle.Clear();
            textBoxAutor.Clear();
            comboBoxCategoria.SelectedIndex = 0;
            textBoxDescr.Clear();
        }

        private void CadastroDeLivro_Load(object sender, EventArgs e)
        {
            var categorias = _categoriaService.BuscarCategoriasSimples();

            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "Nome";
            comboBoxCategoria.ValueMember = "Id";
        }

        private void buttonCadastrarCate_Click(object sender, EventArgs e)
        {
            string titulo = textBoxTitle.Text;
            string autor = textBoxAutor.Text;
            int categoria = (int)comboBoxCategoria.SelectedIndex;
            string descricao = textBoxDescr.Text;
            /*CRIAR UMA TEXTBOX PARA CADA VALOR ABAIXO*/
            int dataLancamento = 0;
            int qtd = 0;

            try {

                //_livroService.CadastroDeLivro(categoria, titulo, autor, dataLancamento, qtd);
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

                LimparCampos();
            }

        }
    }
}
