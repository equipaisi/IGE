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
                IGE xpto = new IGE();
                xpto.Show();
                this.Hide();
            }
            if (textBox_Name.Text == "admin" && textBox_Password.Text == "admin")
            {
                IGE xpto = new IGE();
                xpto.Show();
                //var newForm2 = new Administrador();
                //newForm2.ShowDialog();
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

       // private void button1_Click(object sender, EventArgs e)
       // {

            //Conexao conex = new Conexao();

//            SqlCommand cmd = new SqlCommand("Select * from LoginUsuario where usuario = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "'", conex.conectar());
  //          SqlDataReader dr = cmd.ExecuteReader();

    //        if (dr.Read())
         //   {

      //          this.Hide();
        //         Principal princ = new Principal();
          //      princ.ShowDialog();

            //}


       //     else
         //   {
           //     MessageBox.Show("[Usuario][Senha] incorretos. Tente Novamente");

            //}
            //
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
