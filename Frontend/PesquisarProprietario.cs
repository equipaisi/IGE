﻿using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PesquisarProprietario : Form
    {
        public PesquisarProprietario()
        {
            InitializeComponent();
        }

        private void PesquisarProprietario_Load(object sender, EventArgs e)
        {
#if DEBUG
            textBoxNome.Text = "João Alberto da Silva Gomes";
            textBoxBI.Text = "143687305ZZ5";
#endif
        }

        /// <summary>
        /// Pesquisa um <see cref="Middleware.Proprietario"/> no sistema.
        /// </summary>
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var bi = textBoxBI.Text;

            // se não for fornecido nem o nome nem o número de BI
            if (string.IsNullOrWhiteSpace(nome) && string.IsNullOrWhiteSpace(bi))
            {
                MessageBox.Show("Por favor, introduza um nome ou um número de BI para pesquisar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // TODO
            throw new NotImplementedException("Ainda falta implementar esta funcionalidade.");
        }

        /// <summary>
        /// Fornece informações extra sobre o <see cref="Middleware.Proprietario"/> atualmente selecionado.
        /// </summary>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            var prt = new Proprietario();
            prt.MdiParent = IGE.ActiveForm;
            prt.Show();
        }

    }
}
