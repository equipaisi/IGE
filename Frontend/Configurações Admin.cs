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
    public partial class Configurações_Admin : Form
    {
        public Configurações_Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GerarRelatorio relat = new GerarRelatorio();
            relat.MdiParent = IGE.ActiveForm;
            relat.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DesativarPropriatario desatProp = new DesativarPropriatario();
            desatProp.MdiParent = IGE.ActiveForm;
            desatProp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DesativarHabitacao desat_hab = new DesativarHabitacao();
            desat_hab.MdiParent = IGE.ActiveForm;
            desat_hab.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DesativarAluno desat_aluno = new DesativarAluno();
            desat_aluno.MdiParent = IGE.ActiveForm;
            desat_aluno.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NovaConta conta = new NovaConta();
            conta.MdiParent = IGE.ActiveForm;
            conta.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            EliminarConta elconta = new EliminarConta();
            elconta.MdiParent = IGE.ActiveForm;
            elconta.Show();
        }
    }
}
