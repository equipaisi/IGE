using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PesquisarHabitacao : Form
    {
        public PesquisarHabitacao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Braga")
            {
                comboBox2.Items.Add("Barcelos");
                comboBox2.Items.Add("Povoa de Lanhoso");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox2.SelectedItem == "Barcelos")
            {
               
                    comboBox3.Items.Add("IPCA - Instituto Politécnico Cavado Ave");
                    
                
            }

            label8.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 80;
            trackBar1.Maximum = 400;
            label8.Text = trackBar1.Value.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (comboBox1.Text == "Braga" || comboBox2.Text == ("Barcelos") || comboBox3.Text == ("IPCA - Instituto Politécnico Cavado Ave")){ pictureBox1.Show();
                pictureBox2.Show(); richTextBox1.Show(); richTextBox2.Show();  linkLabel1.Show();
                linkLabel2.Show();
               
            }
                
                    }
        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Habitação alun = new Habitação();
            alun.MdiParent = IGE.ActiveForm;
            alun.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
