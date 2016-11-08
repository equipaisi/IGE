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
    public partial class PesquisarProprietario : Form
    {
        public PesquisarProprietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProprietarios newForm3 = new FormProprietarios();
            newForm3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
