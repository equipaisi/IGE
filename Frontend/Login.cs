using System;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class Login : Form
    {
        //private readonly IMiddlewareClient _middleMiddlewareClient;

        public Login()
        {
            //_middleMiddlewareClient = new MiddlewareClient("IGE");
            InitializeComponent();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {   
            // Mostrar o nome e a versão da aplicação como título da form
            this.Text = $"Login - {Application.ProductName} {Application.ProductVersion}";

            //_middleMiddlewareClient.DropDatabase();
            //_middleMiddlewareClient.CreateDatabase();
            //_middleMiddlewareClient.PopulateDatabase();
        }

        /*
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var username = textBox_Name.Text;
            var password = textBox_Password.Text;

            // se _db.GetUserType(username, password) retornar null, as credenciais eram inválidas,
            // senão retorna o tipo de utilizador como string, eg: "funcionario", "administrador", ou "estudante"
            var userType = _middleMiddlewareClient.GetUserType(username, password);

            if (userType != null)
            {
                // TODO: usar o userType para aparecer as forms correspondentes
                new IGE().Show();
            }
            else
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor, contacte apoiotecnico@imovcelos.pt", "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ValidateCredentials();
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ValidateCredentials();
        }

        private void ValidateCredentials()
        {
            if (textBox_Name.Text == "a" && textBox_Password.Text == "a")
            {
                var xpto = new IGE();
                xpto.Show();
                var fp = new Principal {MdiParent = xpto};
                fp.Show();
                this.Hide(); // a janela fica oculta
            }
            if (textBox_Name.Text == "admin" && textBox_Password.Text == "admin")
            {
                var xpto = new IGE();
                xpto.Show();
                var adm = new Administrador {MdiParent = IGE.ActiveForm};
                adm.Show();
                this.Hide(); // a janela fica oculta
            }
        }
    }
}

