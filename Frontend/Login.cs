using System;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class Login : Form
    {
        private readonly IMiddlewareClient _middleMiddlewareClient;

        public Login()
        {
            _middleMiddlewareClient = new MiddlewareClient("IGE");
            InitializeComponent();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {   
            // Mostrar o nome e a versão da aplicação como título da form
            this.Text = $"Login - {Application.ProductName} {Application.ProductVersion}";
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possivel conectar à base de dados.\n{exception.Message}", "Erro fatal", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Validate()
        {
            var username = textBox_Name.Text;
            var password = textBox_Password.Text;

            string pass = _middleMiddlewareClient.GetPassword(username, password);
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
            MessageBox.Show($"Feito login como {username}");
            #endif

            var userType = _middleMiddlewareClient.GetUserType(username);
            if (string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Erro no tipo de conta", "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // TODO: usar o userType para aparecer as forms correspondentes
            switch (userType)
            {
                case "funcionario":
                    IGE a = new IGE();
                    a.Show();
                    Principal fp = new Principal {MdiParent = a};
                    fp.Show();
                    this.Hide(); // a janela fica oculta
                    break;
                case "administrador":
                    IGE b = new IGE();
                    b.Show();
                    Administrador adm = new Administrador {MdiParent = IGE.ActiveForm};
                    adm.Show();
                    this.Hide(); // a janela fica oculta
                    break;
            }
        }


        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    ValidateCredentials();
        //}

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) pictureBox2_Click(sender, e);
        }

        ///// <summary>
        ///// Valida as credencias introduzidas.
        ///// </summary>
        //private void ValidateCredentials()
        //{
        //    if (textBox_Name.Text == "a" && textBox_Password.Text == "a")
        //    {
        //        IGE xpto = new IGE();
        //        xpto.Show();
        //        Principal fp = new Principal {MdiParent = xpto};
        //        fp.Show();
        //        this.Hide(); // a janela fica oculta
        //        return;
        //    }

        //    if (textBox_Name.Text == "admin" && textBox_Password.Text == "admin")
        //    {
        //        IGE xpto = new IGE();
        //        xpto.Show();
        //        Administrador adm = new Administrador {MdiParent = IGE.ActiveForm};
        //        adm.Show();
        //        this.Hide(); // a janela fica oculta
        //        return;
        //    }
        //    MessageBox.Show("Username ou password incorrecta.\n\nPor favor, contacte apoiotecnico@imovcelos.pt", "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }
}

