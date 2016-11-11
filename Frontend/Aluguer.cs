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
    public partial class Aluguer : Form
    {
        public Aluguer()
        {
            InitializeComponent();
        }

        private void Aluguer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesquisarAluno pesqAluno = new PesquisarAluno();
            pesqAluno.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovoAluno novo_alu = new NovoAluno();
            novo_alu.ShowDialog();
        }
    }
}
