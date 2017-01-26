using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PesquisarAluno : Form
    {
        public PesquisarAluno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pesquisa um <see cref="Middleware.Aluno"/> no sistema.
        /// </summary>
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var bi = textBoxNome.Text;

            // se não for fornecido nem o nome nem o número de BI
            if (string.IsNullOrWhiteSpace(nome) && string.IsNullOrWhiteSpace(bi))
            {
                MessageBox.Show("Por favor, introduza um nome ou um número de BI para pesquisar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // TODO
            throw new NotImplementedException("Ainda falta implementar esta funcionalidade.");
        }

        /// <summary>
        /// Fornece informações extra sobre o <see cref="Middleware.Aluno"/> atualmente selecionado.
        /// </summary>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            new Alunos {MdiParent = MainWindow.ActiveForm}.Show();
        }
    }
}
