using System;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class EliminarConta : Form
    {
        private MiddlewareClient _middleware;

        public EliminarConta()
        {
            InitializeComponent();
        }

        private void EliminarConta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db0c197ff0dbc54f2e8d70a6f3000ae158DataSet.Utilizador' table. You can move, or remove it, as needed.
            this.utilizadorTableAdapter.Fill(this.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet.Utilizador);
            _middleware = new MiddlewareClient();

           



        }

        private void button1_Click(object sender, EventArgs e)
        {
           var username = textBox1.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Por favor, escolha um Username", "Erro", MessageBoxButtons.OK,
     MessageBoxIcon.Error);
                return;
            }

            try
            {
                _middleware.DeleteUser(username);
                
            }

            catch (Exception exception)
            {
                    MessageBox.Show($"Nao foi possível apagar utilizador {username}\n{exception.Message}", "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
               
            }
            MessageBox.Show("Utilizador apagado com sucesso");
        }
    }
}
