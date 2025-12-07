using Sistema_de_Biblioteca.Classes;
namespace Sistema_de_Biblioteca
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginText.Text;
            string password = PassText.Text;

            MessageBox.Show($"login: {login}, password: {password}");
        }

        
    }
}
