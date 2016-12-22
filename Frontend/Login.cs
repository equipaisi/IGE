using System;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class FormLogin : Form
    {
        private readonly MiddlewareClient _middleMiddlewareClient;

        public FormLogin()
        {
            _middleMiddlewareClient = new MiddlewareClient();
            //_middleMiddlewareClient.DropDatabase();
            _middleMiddlewareClient.CreateDatabase();
            //_middleMiddlewareClient.PopulateDatabase();
            InitializeComponent();
        }

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
    }
}

