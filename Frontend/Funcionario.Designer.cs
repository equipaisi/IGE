using System.Windows.Forms;

namespace Frontend
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegistHab = new System.Windows.Forms.PictureBox();
            this.labelRegistHab = new System.Windows.Forms.Label();
            this.pictureBoxPesqHab = new System.Windows.Forms.PictureBox();
            this.labelPesqHab = new System.Windows.Forms.Label();
            this.pictureBoxAlunos = new System.Windows.Forms.PictureBox();
            this.labelAlunos = new System.Windows.Forms.Label();
            this.pictureBoxproprietario = new System.Windows.Forms.PictureBox();
            this.labelProprietarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesqHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproprietario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(174, 32);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(241, 138);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxRegistHab
            // 
            this.pictureBoxRegistHab.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistHab.Image")));
            this.pictureBoxRegistHab.Location = new System.Drawing.Point(174, 196);
            this.pictureBoxRegistHab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxRegistHab.Name = "pictureBoxRegistHab";
            this.pictureBoxRegistHab.Size = new System.Drawing.Size(88, 89);
            this.pictureBoxRegistHab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRegistHab.TabIndex = 1;
            this.pictureBoxRegistHab.TabStop = false;
            this.pictureBoxRegistHab.Click += new System.EventHandler(this.pictureBoxRegistarHabitacao_Click);
            // 
            // labelRegistHab
            // 
            this.labelRegistHab.AutoSize = true;
            this.labelRegistHab.Location = new System.Drawing.Point(172, 287);
            this.labelRegistHab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistHab.Name = "labelRegistHab";
            this.labelRegistHab.Size = new System.Drawing.Size(98, 13);
            this.labelRegistHab.TabIndex = 2;
            this.labelRegistHab.Text = "Registar Habitação";
            // 
            // pictureBoxPesqHab
            // 
            this.pictureBoxPesqHab.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPesqHab.Image")));
            this.pictureBoxPesqHab.Location = new System.Drawing.Point(38, 196);
            this.pictureBoxPesqHab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPesqHab.Name = "pictureBoxPesqHab";
            this.pictureBoxPesqHab.Size = new System.Drawing.Size(88, 89);
            this.pictureBoxPesqHab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesqHab.TabIndex = 3;
            this.pictureBoxPesqHab.TabStop = false;
            this.pictureBoxPesqHab.Click += new System.EventHandler(this.pictureBoxPesquisarHabitacao_Click);
            // 
            // labelPesqHab
            // 
            this.labelPesqHab.AutoSize = true;
            this.labelPesqHab.Location = new System.Drawing.Point(35, 287);
            this.labelPesqHab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesqHab.Name = "labelPesqHab";
            this.labelPesqHab.Size = new System.Drawing.Size(105, 13);
            this.labelPesqHab.TabIndex = 4;
            this.labelPesqHab.Text = "Pesquisar Habitação";
            // 
            // pictureBoxAlunos
            // 
            this.pictureBoxAlunos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlunos.Image")));
            this.pictureBoxAlunos.Location = new System.Drawing.Point(440, 196);
            this.pictureBoxAlunos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAlunos.Name = "pictureBoxAlunos";
            this.pictureBoxAlunos.Size = new System.Drawing.Size(88, 89);
            this.pictureBoxAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlunos.TabIndex = 5;
            this.pictureBoxAlunos.TabStop = false;
            this.pictureBoxAlunos.Click += new System.EventHandler(this.pictureBoxPesquisarAluno_Click);
            // 
            // labelAlunos
            // 
            this.labelAlunos.AutoSize = true;
            this.labelAlunos.Location = new System.Drawing.Point(470, 287);
            this.labelAlunos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlunos.Name = "labelAlunos";
            this.labelAlunos.Size = new System.Drawing.Size(39, 13);
            this.labelAlunos.TabIndex = 6;
            this.labelAlunos.Text = "Alunos";
            // 
            // pictureBoxproprietario
            // 
            this.pictureBoxproprietario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxproprietario.Image")));
            this.pictureBoxproprietario.Location = new System.Drawing.Point(313, 196);
            this.pictureBoxproprietario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxproprietario.Name = "pictureBoxproprietario";
            this.pictureBoxproprietario.Size = new System.Drawing.Size(87, 89);
            this.pictureBoxproprietario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxproprietario.TabIndex = 7;
            this.pictureBoxproprietario.TabStop = false;
            this.pictureBoxproprietario.Click += new System.EventHandler(this.pictureBoxPesquisarProprietario_Click);
            // 
            // labelProprietarios
            // 
            this.labelProprietarios.AutoSize = true;
            this.labelProprietarios.Location = new System.Drawing.Point(321, 287);
            this.labelProprietarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProprietarios.Name = "labelProprietarios";
            this.labelProprietarios.Size = new System.Drawing.Size(65, 13);
            this.labelProprietarios.TabIndex = 8;
            this.labelProprietarios.Text = "Proprietários";
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 355);
            this.Controls.Add(this.labelProprietarios);
            this.Controls.Add(this.pictureBoxproprietario);
            this.Controls.Add(this.labelAlunos);
            this.Controls.Add(this.pictureBoxAlunos);
            this.Controls.Add(this.labelPesqHab);
            this.Controls.Add(this.pictureBoxPesqHab);
            this.Controls.Add(this.labelRegistHab);
            this.Controls.Add(this.pictureBoxRegistHab);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesqHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproprietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxRegistHab;
        private System.Windows.Forms.Label labelRegistHab;
        private System.Windows.Forms.PictureBox pictureBoxPesqHab;
        private System.Windows.Forms.Label labelPesqHab;
        private System.Windows.Forms.PictureBox pictureBoxAlunos;
        private System.Windows.Forms.Label labelAlunos;
        private System.Windows.Forms.PictureBox pictureBoxproprietario;
        private System.Windows.Forms.Label labelProprietarios;
    }
}