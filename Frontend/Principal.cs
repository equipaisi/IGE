using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegistarHabitacao rh = new RegistarHabitacao();
            rh.MdiParent= IGE.ActiveForm;
            rh.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PesquisarHabitacao ph = new PesquisarHabitacao();
            ph.MdiParent = IGE.ActiveForm;
            ph.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PesquisarProprietario pp = new PesquisarProprietario();
            pp.MdiParent = IGE.ActiveForm;
            pp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PesquisarAluno pa = new PesquisarAluno();
            pa.MdiParent = IGE.ActiveForm;
            pa.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;
        }
    }
}
