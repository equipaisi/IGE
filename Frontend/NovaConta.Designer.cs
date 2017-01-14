namespace Frontend
{
    partial class NovaConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTipoUtilizador = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonFunc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADICIONAR CONTA DE UTILIZADOR ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(60, 209);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 17);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelTipoUtilizador
            // 
            this.labelTipoUtilizador.AutoSize = true;
            this.labelTipoUtilizador.Location = new System.Drawing.Point(60, 144);
            this.labelTipoUtilizador.Name = "labelTipoUtilizador";
            this.labelTipoUtilizador.Size = new System.Drawing.Size(107, 17);
            this.labelTipoUtilizador.TabIndex = 2;
            this.labelTipoUtilizador.Text = "Tipo Utilizador: ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(60, 257);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(202, 204);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(203, 22);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(202, 254);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 22);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(202, 129);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(116, 21);
            this.radioButtonAdmin.TabIndex = 6;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Administrador";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonFunc
            // 
            this.radioButtonFunc.AutoSize = true;
            this.radioButtonFunc.Location = new System.Drawing.Point(202, 156);
            this.radioButtonFunc.Name = "radioButtonFunc";
            this.radioButtonFunc.Size = new System.Drawing.Size(103, 21);
            this.radioButtonFunc.TabIndex = 7;
            this.radioButtonFunc.TabStop = true;
            this.radioButtonFunc.Text = "Funcionário";
            this.radioButtonFunc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NovaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonFunc);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTipoUtilizador);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Name = "NovaConta";
            this.Text = "Nova Conta";
            this.Load += new System.EventHandler(this.NovaConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTipoUtilizador;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonFunc;
        private System.Windows.Forms.Button button1;
    }
}