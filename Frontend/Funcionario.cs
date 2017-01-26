using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Funcionario : Form
    {

        public Funcionario()
        {
            InitializeComponent();
        }

        private void pictureBoxRegistarHabitacao_Click(object sender, EventArgs e)
        {
            new RegistarHabitacao().Show();
        }

        private void pictureBoxPesquisarHabitacao_Click(object sender, EventArgs e)
        {
            new PesquisarHabitacao().Show();
        }

        private void pictureBoxPesquisarProprietario_Click(object sender, EventArgs e)
        {
            new PesquisarProprietario().Show();
        }

        private void pictureBoxPesquisarAluno_Click(object sender, EventArgs e)
        {
            new PesquisarAluno().Show();
        }
    }
}
