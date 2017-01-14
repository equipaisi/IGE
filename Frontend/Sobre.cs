using System;
using System.Drawing;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();

            richTextBox1.Enabled = false;
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectedText = String.Empty;
        }

    }
}
