using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "a" && textBox_Password.Text == "a")
            {
                var newForm2 = new FormPrincipal();
                newForm2.ShowDialog();
            }

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            // ipsum lorem
        }
    }
}
