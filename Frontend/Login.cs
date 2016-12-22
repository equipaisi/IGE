using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            // A janela do login vai ficar centralizada no monitor do pc
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Mostrar o nome e a versão da aplicação como título da form
            this.Text = Application.ProductName + " " + Application.ProductVersion;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "a" && textBox_Password.Text == "a")
            {
                IGE xpto = new IGE();
                xpto.Show();
                FormPrincipal fp = new FormPrincipal();
                fp.MdiParent = xpto;
                fp.Show();
                this.Hide(); // a janela fica oculta
            }
            if (textBox_Name.Text == "admin" && textBox_Password.Text == "admin")
            {
                IGE xpto = new IGE();
                xpto.Show();
                Administrador adm = new Administrador();
                adm.MdiParent = IGE.ActiveForm;
                adm.Show();
                this.Hide(); // a janela fica oculta
            }
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Name.Text == "a" && textBox_Password.Text == "a")
                {
                    IGE xpto = new IGE();
                    xpto.Show();
                    FormPrincipal fp = new FormPrincipal();
                    fp.MdiParent = xpto;
                    fp.Show();
                    this.Hide(); // a janela fica oculta
                }
                if (textBox_Name.Text == "admin" && textBox_Password.Text == "admin")
                {
                    IGE xpto = new IGE();
                    xpto.Show();
                    Administrador adm = new Administrador();
                    adm.MdiParent = IGE.ActiveForm;
                    adm.Show();
                    this.Hide(); // a janela fica oculta
                }
            }
        }
    }
}
