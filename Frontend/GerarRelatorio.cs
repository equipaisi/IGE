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
            new RelatorioAlunos {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RelatorioHabitacoes {MdiParent = MainWindow.ActiveForm}.Show();
        }
    }
}
