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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var config = new ConfiguraçõesAdmin();
            config.MdiParent = IGE.ActiveForm;
            config.Show();
        }

        private void pictureBoxPesqHab_Click(object sender, EventArgs e)
        {
            var pesq = new PesquisarHabitacao();
            pesq.MdiParent = IGE.ActiveForm;
            pesq.Show();
        }

        private void pictureBoxRegistHab_Click(object sender, EventArgs e)
        {
            var regist = new RegistarHabitacao();
            regist.MdiParent = IGE.ActiveForm;
            regist.Show();
        }

        private void pictureBoxproprietario_Click(object sender, EventArgs e)
        {
            var prop = new PesquisarProprietario();
            prop.MdiParent = IGE.ActiveForm;
            prop.Show();
        }

        private void pictureBoxAlunos_Click(object sender, EventArgs e)
        {
            var alun = new PesquisarAluno();
            alun.MdiParent = IGE.ActiveForm;
            alun.Show();
        }
    }
}
