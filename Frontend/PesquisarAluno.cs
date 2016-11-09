using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PesquisarAluno : Form
    {
        public PesquisarAluno()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if ((string)listBox1.SelectedItem == "Joao Ferreira Tavares")
            {
                Alunos newForm4 = new Alunos();
                newForm4.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            if (textBox1.Text == "Andre")
            {

                listBox1.Items.Add("Andre Filipe Jorge");
                listBox1.Items.Add("Andre GIl");
                listBox1.Items.Add("Andre Pedro Figueiredo");
               
            }
        }
    }
}
