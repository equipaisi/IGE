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


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox3.Text == " " )
            {
                MessageBox.Show("Pf introduza um Nome ou BI para pesquisa");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alunos alun = new Alunos();
            alun.ShowDialog();
        }
    }
}
