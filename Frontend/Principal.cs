using System;
using System.Windows.Forms;

namespace Frontend
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
            new RegistarHabitacao().ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new PesquisarHabitacao().ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new PesquisarProprietario().ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new PesquisarAluno().ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        PictureBox s;
       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
