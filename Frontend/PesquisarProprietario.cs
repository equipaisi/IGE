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
           
            if (textBox3.Text == " " || textBox1.Text==" ")
            {


                MessageBox.Show("Pf introduza um Nome ou BI para pesquisa");

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text == " " || textBox1.Text == " ")
            {


                MessageBox.Show("Pf introduza um Nome ou BI para pesquisa");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proprietario prt = new Proprietario();
            prt.ShowDialog();
        }
    }
}
