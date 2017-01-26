using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void IGE_Load(object sender, EventArgs e)
        {
            // Mostrar o nome e a versão da aplicação como título da form
            Text = $"{Application.ProductName} {Application.ProductVersion}";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sobre { MdiParent = this }.Show();
        }

        private void IGE_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleanExit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            new Login().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanExit();
        }

        private static void CleanExit()
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistarHabitacao { MdiParent = MainWindow.ActiveForm }.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PesquisarHabitacao { MdiParent = MainWindow.ActiveForm }.Show();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new PesquisarAluno { MdiParent = MainWindow.ActiveForm }.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PesquisarProprietario { MdiParent = MainWindow.ActiveForm }.Show();
        }
    }
}
