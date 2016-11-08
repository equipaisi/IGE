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
    public partial class PesquisarAluno : Form
    {
        public PesquisarAluno()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if ((string)listBox1.SelectedItem == "JOão ")
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
            //if( textBox1_TextChanged.Select =="") { }
        }
    }
}
