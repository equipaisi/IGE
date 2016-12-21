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
            pesqAluno.MdiParent = IGE.ActiveForm;
            pesqAluno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovoAluno novo_alu = new NovoAluno();
            novo_alu.MdiParent = IGE.ActiveForm;
            novo_alu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quarto Alugado com sucesso ");
            Aluguer al = new Aluguer();
            al.Close();
        }
    }
}
