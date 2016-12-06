using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegistarHabitacao rh = new RegistarHabitacao();
            rh.MdiParent= IGE.ActiveForm;
            rh.Show();
            //new RegistarHabitacao().ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //new PesquisarHabitacao().ShowDialog();
            PesquisarHabitacao ph = new PesquisarHabitacao();
            ph.MdiParent = IGE.ActiveForm;
            ph.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //new PesquisarProprietario().ShowDialog();
            PesquisarProprietario pp = new PesquisarProprietario();
            pp.MdiParent = IGE.ActiveForm;
            pp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //new PesquisarAluno().ShowDialog();
            PesquisarAluno pa = new PesquisarAluno();
            pa.MdiParent = IGE.ActiveForm;
            pa.Show();
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
