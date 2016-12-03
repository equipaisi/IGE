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
    public partial class IGE : Form
    {
        public IGE()
        {
            InitializeComponent();
            FormPrincipal xpto = new FormPrincipal();
            xpto.MdiParent = this;
            xpto.Show();
          
           
        }

        private void IGE_Load(object sender, EventArgs e)
        {

        }
    }
}
