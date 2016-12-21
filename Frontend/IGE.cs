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
            this.WindowState = FormWindowState.Maximized;



        }
        //protected override void OnResize(EventArgs e)
        //{
        //    CenterForms();
        //    base.OnResize(e);
        //}
        //private void CenterForms()
        //{
        //    //Isto vai centralizar todos os filhos do forms
        //    foreach (var form in MdiChildren) 
        //    {
        //        form.Left = (ClientRectangle.Width - form.Width) / 2;
        //        form.Top = (ClientRectangle.Height - form.Height) / 2;
        //    }

        //}
        private void IGE_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonSobre_Click(object sender, EventArgs e)
        {
            Sobre sobreForm = new Sobre();
            sobreForm.MdiParent = this;
            sobreForm.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {


            this.Visible = false;

            FormLogin login = new FormLogin();
            login.ShowDialog();
            

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void IGE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
