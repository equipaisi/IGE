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
            relat.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DesativarPropriatario Desatprop = new DesativarPropriatario();
            Desatprop.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DesativarHabitacao desat_hab = new DesativarHabitacao();
            desat_hab.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DesativarAluno desat_aluno = new DesativarAluno();
            desat_aluno.ShowDialog();
        }
    }
}
