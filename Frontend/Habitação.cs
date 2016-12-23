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
    public partial class Habitação : Form
    {
        public Habitação()
        {
            InitializeComponent();
            StringBuilder add = new StringBuilder("http://maps.google.com/maps?q=");
            add.Append(labelRua.Text);
            add.Append(labelLocalidade.Text);
            add.Append(labelCodigoPostal.Text);
            webBrowser1.Navigate(add.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxMorada_Enter(object sender, EventArgs e)
        {

        }

        private void descricaoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proprietario prt = new Proprietario();
            prt.MdiParent = IGE.ActiveForm;
            prt.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aluguer alug = new Aluguer();
            alug.MdiParent = IGE.ActiveForm;
            alug.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Habitação_Load(object sender, EventArgs e)
        {
           
        }
    }
}
