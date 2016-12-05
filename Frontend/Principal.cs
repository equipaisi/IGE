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

        protected void pictureBox3_Click(object sender, EventArgs e)
        {
            new PesquisarHabitacao().ShowDialog();
          //  PesquisarHabitacao xpto = new PesquisarHabitacao();
            //xpto.MdiParent = this;
            //this.Show();

         
        



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
            Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;

        }
       
       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public static implicit operator bool(FormPrincipal v)
        {
            throw new NotImplementedException();
        }
    }
}
