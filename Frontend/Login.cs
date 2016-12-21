using System;
using System.Windows.Forms;

namespace Frontend

{

    
    public partial class FormLogin : Form
    {
       

        public FormLogin()
        {
            InitializeComponent();
            // A janela do login vai ficar centralizada no monitor do pc
            this.StartPosition = FormStartPosition.CenterScreen;

           
        }

        private void Form1_Load(object sender, Keys e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "a" && textBox_Password.Text == "a")
            {
                IGE xpto = new IGE();
                xpto.Show();
                FormPrincipal fp = new FormPrincipal();
                fp.MdiParent = xpto;
                fp.Show();            
                this.Hide();// a janela fica oculta
            }
            if (textBox_Name.Text == "admin" && textBox_Password.Text == "admin")
            {
                IGE xpto = new IGE();
                xpto.Show();
                Administrador adm = new Administrador();
                adm.MdiParent = IGE.ActiveForm;
                adm.Show();
                this.Hide(); // a janela fica oculta
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

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_Name.Text == "a" && textBox_Password.Text == "a")
                {
                    IGE xpto = new IGE();
                    xpto.Show();
                    FormPrincipal fp = new FormPrincipal();
                    fp.MdiParent = xpto;
                    fp.Show();
                    this.Hide();// a janela fica oculta
                }
                if (textBox_Name.Text == "admin" && textBox_Password.Text == "admin")
                {
                    IGE xpto = new IGE();
                    xpto.Show();
                    Administrador adm = new Administrador();
                    adm.MdiParent = IGE.ActiveForm;
                    adm.Show();
                    this.Hide(); // a janela fica oculta
                }
            }
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
