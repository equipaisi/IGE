using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class ConfiguraçõesAdmin : Form
    {
        public ConfiguraçõesAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new GerarRelatorio {MdiParent = ActiveForm}.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new DesativarPropriatario { MdiParent = ActiveForm }.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new DesativarHabitacao { MdiParent = ActiveForm }.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new DesativarAluno { MdiParent = ActiveForm }.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new NovaConta { MdiParent = ActiveForm }.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new EliminarConta { MdiParent = ActiveForm }.Show();
        }
    }
}
