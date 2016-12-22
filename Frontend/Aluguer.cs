using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Aluguer : Form
    {
        public Aluguer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesquisarAluno pesqAluno = new PesquisarAluno();
            pesqAluno.MdiParent = IGE.ActiveForm;
            pesqAluno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovoAluno novoAluno = new NovoAluno();
            novoAluno.MdiParent = IGE.ActiveForm;
            novoAluno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quarto Alugado com sucesso");
            Aluguer al = new Aluguer();
            al.Close();
        }
    }
}
