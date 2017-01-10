using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class NovaConta : Form
    {
        private IMiddlewareClient _middleware;

        public NovaConta()
        {
            InitializeComponent();
        }

        private void NovaConta_Load(object sender, EventArgs e)
        {
            _middleware = new MiddlewareClient("IGE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            #region Errors
            if (!radioButtonAdmin.Checked && !radioButtonFunc.Checked)
            {
                MessageBox.Show("Por favor, escolha um tipo de utilizador", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (radioButtonAdmin.Checked && radioButtonFunc.Checked)
            {
                MessageBox.Show("Por favor, escolha apenas um tipo de utilizador", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Por favor, insira o Username", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, insira o Username", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;

            }

            #endregion

            try
            {
                if (radioButtonAdmin.Checked)
                {
                    if (_middleware.CreateAdmin(username, password))
                    {
                        MessageBox.Show($"Criado administrador {username}", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                }

                if (radioButtonFunc.Checked)
                {
                    if (_middleware.CreateFuncionario(username, password))
                    {
                        MessageBox.Show($"Criado funcionário {username}", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possível criar utilizador.\n{exception.Message}", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
