using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PesquisarProprietario : Form
    {
        public PesquisarProprietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm3 = new FormProprietarios();
            newForm3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
