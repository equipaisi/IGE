using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class GerarRelatorio : Form
    {
        public GerarRelatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alun = new RelatorioAlunos();
            alun.MdiParent = IGE.ActiveForm;
            alun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var habt = new RelatorioHabitacoes();
           habt.MdiParent = IGE.ActiveForm;
            habt.Show();
        }
    }
}
