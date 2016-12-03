using System;
using System.Windows.Forms;
using Backend;
using Middleware;

namespace Frontend
{
    public partial class FormLogin : Form
    {
        private MySqlDb _db;

        public FormLogin(MySqlDb db)
        {
            _db = db;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var username = textBox_Name.Text;
            var password = textBox_Password.Text;

            if (_db.ValidUser(username, password))
            {
                // ver que tipo de utilizador e fazer o dispatch apropriado
                //var newForm2 = new FormPrincipal();
                //newForm2.ShowDialog();
                IGE xpto = new IGE();
                xpto.Show();
            }
            else
            {
                MessageBox.Show("Username ou password incorrecta.", "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            if (username == "a" && password == "a")
            {
                var newForm2 = new FormPrincipal();
                newForm2.ShowDialog();
            }
            if (username == "admin" && password == "admin")
            {
                IGE xpto = new IGE();
                xpto.Show();
                //var newForm2 = new Administrador();
                //newForm2.ShowDialog();
            }
            */


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
