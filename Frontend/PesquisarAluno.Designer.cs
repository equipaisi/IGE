namespace Frontend
{
    partial class PesquisarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarAluno));
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxBI = new System.Windows.Forms.TextBox();
            this.labelBI = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(469, 14);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(76, 24);
            this.buttonPesquisar.TabIndex = 6;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(59, 16);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(193, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 19);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome: ";
            // 
            // textBoxBI
            // 
            this.textBoxBI.Location = new System.Drawing.Point(289, 16);
            this.textBoxBI.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBI.Name = "textBoxBI";
            this.textBoxBI.Size = new System.Drawing.Size(130, 20);
            this.textBoxBI.TabIndex = 9;
            // 
            // labelBI
            // 
            this.labelBI.AutoSize = true;
            this.labelBI.Location = new System.Drawing.Point(266, 19);
            this.labelBI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBI.Name = "labelBI";
            this.labelBI.Size = new System.Drawing.Size(20, 13);
            this.labelBI.TabIndex = 8;
            this.labelBI.Text = "BI:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 287);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(474, 358);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(70, 24);
            this.buttonInfo.TabIndex = 11;
            this.buttonInfo.Text = "MAIS INFO";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // PesquisarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 392);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxBI);
            this.Controls.Add(this.labelBI);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PesquisarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxBI;
        private System.Windows.Forms.Label labelBI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInfo;
    }
}