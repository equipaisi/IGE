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
            if (textBox1.Text == "Joao")
            {

                listBox1.Items.Add("Joao Andre FIlipe");
                listBox1.Items.Add("Joao Ricardo Manuel");
                listBox1.Items.Add("Joao Ferreira Tavares");
                listBox1.Items.Add("Joao Esteves");
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
