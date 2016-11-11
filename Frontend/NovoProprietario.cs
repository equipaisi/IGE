using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class NovoProprietario : Form
    {
        public NovoProprietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==" "|| textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " " || textBox6.Text == " " ) {
                MessageBox.Show("Pf introduza todos os Dados"); }
        }
    }
}
