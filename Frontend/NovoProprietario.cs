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
            var nome = textBox1.Text;
            var bi = textBox2.Text;
            var dt = textBox6.Text;

            var localidade = textBoxLocalidade.Text;
            var cp = maskedTextBoxCodigoPostal.Text;
            var rua = textBoxRua.Text;

            var telefone = textBox4.Text;
            var email = textBox5.Text;

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


            MessageBox.Show("Proprietário criado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
