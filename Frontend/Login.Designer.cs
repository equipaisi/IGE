namespace Frontend
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxLogin
            // 
            resources.ApplyResources(this.pictureBoxLogin, "pictureBoxLogin");
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelNome
            // 
            resources.ApplyResources(this.labelNome, "labelNome");
            this.labelNome.Name = "labelNome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Name
            // 
            resources.ApplyResources(this.textBox_Name, "textBox_Name");
            this.textBox_Name.Name = "textBox_Name";
            // 
            // textBox_Password
            // 
            resources.ApplyResources(this.textBox_Password, "textBox_Password");
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.pictureBoxLogo);
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}

