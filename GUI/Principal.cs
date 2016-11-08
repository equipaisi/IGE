using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockups
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegistarHabitacao newForm3 = new RegistarHabitacao();
            newForm3.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PesquisarHabitacao newForm1 = new PesquisarHabitacao();
            newForm1.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PesquisarProprietario newForm3 = new PesquisarProprietario();
            newForm3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PesquisarAluno newForm4 = new PesquisarAluno ();
            newForm4.ShowDialog();
        }
    }
}
