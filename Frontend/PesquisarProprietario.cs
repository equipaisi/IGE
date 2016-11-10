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
            listBox1.Items.Clear();
            if (textBox1.Text == "Joao"  )
            {

                listBox1.Items.Add("Joao Andre FIlipe");
                listBox1.Items.Add("Joao Ricardo Manuel");
                listBox1.Items.Add("Joao Ferreira Tavares");
                listBox1.Items.Add("Joao Esteves");
            }
            if (textBox3.Text == "12345678")
            {

               
                listBox1.Items.Add("Joao Ferreira Tavares");
              
            }
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
            if ((string)listBox1.SelectedItem == "Joao Ferreira Tavares")
            {

                
            }
        }
    }
}
