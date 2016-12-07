using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Configurações_Admin config = new Configurações_Admin();
            config.MdiParent = IGE.ActiveForm;
            config.Show();
        }

        private void pictureBoxPesqHab_Click(object sender, EventArgs e)
        {
            PesquisarHabitacao pesq = new PesquisarHabitacao();
            pesq.MdiParent = IGE.ActiveForm;
            pesq.Show();
        }

        private void pictureBoxRegistHab_Click(object sender, EventArgs e)
        {
            RegistarHabitacao regist = new RegistarHabitacao();
            regist.MdiParent = IGE.ActiveForm;
            regist.Show();
        }

        private void pictureBoxproprietario_Click(object sender, EventArgs e)
        {
            Proprietario prop = new Proprietario();
            prop.MdiParent = IGE.ActiveForm;
            prop.Show();
        }

        private void pictureBoxAlunos_Click(object sender, EventArgs e)
        {
            Alunos alun = new Alunos();
            alun.MdiParent = IGE.ActiveForm;
            alun.Show();
        }
    }
}
