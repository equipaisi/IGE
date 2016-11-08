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
                comboBox2.Items.Add("xau");
                comboBox2.Items.Add("ola");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox2.SelectedItem == "ola")
            {
                label9.Text = " HELLOOOOO";
            }

            label8.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 80;
            trackBar1.Maximum = 400;
            label8.Text = trackBar1.Value.ToString();
        }

        private void PesquisarHabitacao_Load(object sender, EventArgs e)
        {

        }
    }
}
