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
        protected override void OnResize(EventArgs e)
        {
            CenterForms();
            base.OnResize(e);
        }
        private void CenterForms()
        {
            //Isto vai centralizar todos os filhos do forms
            foreach (var form in MdiChildren) 
            {
                form.Left = (ClientRectangle.Width - form.Width) / 2;
                form.Top = (ClientRectangle.Height - form.Height) / 2;
            }

        }
        private void IGE_Load(object sender, EventArgs e)
        {
            
        }
    }
}
