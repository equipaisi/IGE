using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void pictureBoxPesqHab_Click(object sender, EventArgs e)
        {
            new PesquisarHabitacao {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void pictureBoxRegistHab_Click(object sender, EventArgs e)
        {
            new RegistarHabitacao {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void pictureBoxproprietario_Click(object sender, EventArgs e)
        {
            new PesquisarProprietario {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void pictureBoxAlunos_Click(object sender, EventArgs e)
        {
            new PesquisarAluno {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void pictureBoxConfig_Click(object sender, EventArgs e)
        {
            new ConfiguraçõesAdmin { MdiParent = MainWindow.ActiveForm }.Show();
        }
    }
}
