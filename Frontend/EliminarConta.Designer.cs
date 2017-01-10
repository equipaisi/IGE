namespace Frontend
{
    partial class EliminarConta
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet = new Frontend.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet();
            this.utilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizadorTableAdapter = new Frontend.db0c197ff0dbc54f2e8d70a6f3000ae158DataSetTableAdapters.UtilizadorTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(45, 111);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 17);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ELIMINAR CONTA DE UTILIZADOR ";
            // 
            // db0c197ff0dbc54f2e8d70a6f3000ae158DataSet
            // 
            this.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet.DataSetName = "db0c197ff0dbc54f2e8d70a6f3000ae158DataSet";
            this.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizadorBindingSource
            // 
            this.utilizadorBindingSource.DataMember = "Utilizador";
            this.utilizadorBindingSource.DataSource = this.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet;
            // 
            // utilizadorTableAdapter
            // 
            this.utilizadorTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 13;
            // 
            // EliminarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 246);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Name = "EliminarConta";
            this.Text = "Eliminar Conta";
            this.Load += new System.EventHandler(this.EliminarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db0c197ff0dbc54f2e8d70a6f3000ae158DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private db0c197ff0dbc54f2e8d70a6f3000ae158DataSet db0c197ff0dbc54f2e8d70a6f3000ae158DataSet;
        private System.Windows.Forms.BindingSource utilizadorBindingSource;
        private db0c197ff0dbc54f2e8d70a6f3000ae158DataSetTableAdapters.UtilizadorTableAdapter utilizadorTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}