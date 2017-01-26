using System;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class Login : Form
    {
        private readonly IMiddlewareClient _middlewareClient;

        #region Constructors

        public Login() : this(new MiddlewareClient("IGE"))
        {
        }

        public Login(IMiddlewareClient middlewareClient)
        {
            _middlewareClient = middlewareClient;
            InitializeComponent();
        }

        #endregion

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Mostrar o nome e a versão da aplicação como título da form
            Text = $"Login - {Application.ProductName} {Application.ProductVersion}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateCretentials();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possivel conectar à base de dados.\n{exception.Message}", "Erro fatal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ValidateCretentials()
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            var pass = _middlewareClient.GetPassword(username, password);
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor, contacte apoiotecnico@imovcelos.pt",
                    "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pass != password)
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor, contacte apoiotecnico@imovcelos.pt",
                    "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

#if DEBUG
            //MessageBox.Show($"Feito login como {username}");
#endif

            var userType = _middlewareClient.GetUserType(username);
            if (string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Erro no tipo de conta", "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // TODO: usar o userType para aparecer as forms correspondentes
            switch (userType)
            {
                case "funcionario":
                    var a = new MainWindow();
                    a.Show();
                    //var fp = new Funcionario {MdiParent = a};
                    //fp.Show();
                    Hide(); // a janela fica oculta
                    break;
                case "administrador":
                    var b = new MainWindow();
                    b.Show();
                    var adm = new Administrador {MdiParent = ActiveForm};
                    adm.Show();
                    Hide(); // a janela fica oculta
                    break;
            }
        }


        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) pictureBox2_Click(sender, e);
        }
    }
}