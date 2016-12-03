using System;
using System.Windows.Forms;
using Backend;
using Middleware;

namespace Frontend
{
    public partial class FormLogin : Form
    {
        private readonly MySqlDb _db;

        public FormLogin()
        {
            _db = new MySqlDb();
            InitializeComponent();
        }
        public FormLogin(MySqlDb db)
        {
            _db = db;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var username = textBox_Name.Text;
            var password = textBox_Password.Text;

            // se _db.ValidUser(username, password) retornar null, as credenciais eram inválidas,
            // senão retorna o tipo de utilizador como string, eg: "funcionario", "administrador", ou "estudante"
            var userType = _db.ValidUser(username, password);
            if (userType != null)
            {
                // TODO: ver que tipo de utilizador (creds.Item2) e fazer o dispatch apropriado
                //var newForm2 = new FormPrincipal();
                //newForm2.ShowDialog();
                IGE xpto = new IGE();
                xpto.Show();
            }
            else
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor, contacte apoiotecnico@imovcelos.pt", "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
