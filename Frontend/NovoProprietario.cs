using System;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class NovoProprietario : Form
    {
        private IMiddlewareClient _middleware;

        public NovoProprietario()
        {
            InitializeComponent();
            _middleware = new MiddlewareClient("IGE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string bi = textBox2.Text;
            string dt = textBox6.Text;

            string localidade = textBoxLocalidade.Text;
            string cp = maskedTextBoxCodigoPostal.Text;
            string rua = textBoxRua.Text;

            string telefone = textBox4.Text;
            string email = textBox5.Text;


            try
            {
                if (!_middleware.CriarProprietario(nome, bi, dt, rua, cp, localidade, telefone, email))
                {
                    MessageBox.Show("Não foi possível criar o proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possível criar o proprietário.\n{exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("Proprietário criado com sucesso.");
        }
    }
}
