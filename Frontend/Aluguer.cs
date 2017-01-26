﻿using System;
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
            new PesquisarAluno {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NovoAluno {MdiParent = MainWindow.ActiveForm}.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quarto Alugado com sucesso");
            var al = new Aluguer();
            al.Close();
        }
    }
}
