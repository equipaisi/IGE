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
    public partial class GerarRelatorio : Form
    {
        public GerarRelatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatorioAlunos alun = new RelatorioAlunos();
            alun.MdiParent = IGE.ActiveForm;
            alun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelatorioHabitacoes habt = new RelatorioHabitacoes();
           habt.MdiParent = IGE.ActiveForm;
            habt.Show();
        }
    }
}
