﻿namespace Frontend
{
    partial class Habitação
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Habitação));
            this.groupBoxFotos = new System.Windows.Forms.GroupBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRemoverFoto = new System.Windows.Forms.Button();
            this.buttonAdicionarFotos = new System.Windows.Forms.Button();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMorada = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelNumDeWC = new System.Windows.Forms.Label();
            this.checkBoxDespesasIncluidas = new System.Windows.Forms.CheckBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelMetrosQuadrados = new System.Windows.Forms.Label();
            this.labelNumDeAssoalhadas = new System.Windows.Forms.Label();
            this.labelAnoDeConstrucao = new System.Windows.Forms.Label();
            this.labelNumDeQuartos = new System.Windows.Forms.Label();
            this.groupBoxComodidades = new System.Windows.Forms.GroupBox();
            this.checkBoxInternet = new System.Windows.Forms.CheckBox();
            this.checkBoxTelevisao = new System.Windows.Forms.CheckBox();
            this.checkBoxServicosDeLimpeza = new System.Windows.Forms.CheckBox();
            this.descricaoGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mapa = new Frontend.Mapa("Barcelos, Portugal");
            this.labelmetros = new System.Windows.Forms.Label();
            this.labelano = new System.Windows.Forms.Label();
            this.labelassoalhadas = new System.Windows.Forms.Label();
            this.labelquartos = new System.Windows.Forms.Label();
            this.labelprec = new System.Windows.Forms.Label();
            this.labelwcs = new System.Windows.Forms.Label();
            this.labelprop = new System.Windows.Forms.Label();
            this.groupBoxFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.groupBoxMorada.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxComodidades.SuspendLayout();
            this.descricaoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFotos
            // 
            this.groupBoxFotos.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxFotos.Controls.Add(this.buttonPrevious);
            this.groupBoxFotos.Controls.Add(this.buttonNext);
            this.groupBoxFotos.Controls.Add(this.buttonRemoverFoto);
            this.groupBoxFotos.Controls.Add(this.buttonAdicionarFotos);
            this.groupBoxFotos.Controls.Add(this.pictureBoxImagem);
            this.groupBoxFotos.Location = new System.Drawing.Point(594, 79);
            this.groupBoxFotos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxFotos.Name = "groupBoxFotos";
            this.groupBoxFotos.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxFotos.Size = new System.Drawing.Size(616, 336);
            this.groupBoxFotos.TabIndex = 35;
            this.groupBoxFotos.TabStop = false;
            this.groupBoxFotos.Text = "Fotos";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(151, 295);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(73, 33);
            this.buttonPrevious.TabIndex = 37;
            this.buttonPrevious.Text = "<=";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(230, 295);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(73, 33);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "=>";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverFoto
            // 
            this.buttonRemoverFoto.Location = new System.Drawing.Point(371, 295);
            this.buttonRemoverFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoverFoto.Name = "buttonRemoverFoto";
            this.buttonRemoverFoto.Size = new System.Drawing.Size(52, 33);
            this.buttonRemoverFoto.TabIndex = 35;
            this.buttonRemoverFoto.Text = "-";
            this.buttonRemoverFoto.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarFotos
            // 
            this.buttonAdicionarFotos.Location = new System.Drawing.Point(429, 295);
            this.buttonAdicionarFotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarFotos.Name = "buttonAdicionarFotos";
            this.buttonAdicionarFotos.Size = new System.Drawing.Size(52, 33);
            this.buttonAdicionarFotos.TabIndex = 20;
            this.buttonAdicionarFotos.Text = "+";
            this.buttonAdicionarFotos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagem.Location = new System.Drawing.Point(13, 23);
            this.pictureBoxImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(593, 260);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagem.TabIndex = 22;
            this.pictureBoxImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Vivenda T2";
            // 
            // groupBoxMorada
            // 
            this.groupBoxMorada.Controls.Add(this.label15);
            this.groupBoxMorada.Controls.Add(this.label14);
            this.groupBoxMorada.Controls.Add(this.label13);
            this.groupBoxMorada.Controls.Add(this.labelLocalidade);
            this.groupBoxMorada.Controls.Add(this.labelCodigoPostal);
            this.groupBoxMorada.Controls.Add(this.labelRua);
            this.groupBoxMorada.Location = new System.Drawing.Point(21, 82);
            this.groupBoxMorada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMorada.Name = "groupBoxMorada";
            this.groupBoxMorada.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxMorada.Size = new System.Drawing.Size(543, 125);
            this.groupBoxMorada.TabIndex = 94;
            this.groupBoxMorada.TabStop = false;
            this.groupBoxMorada.Text = "Morada";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(241, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 95;
            this.label15.Text = "Localidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 94;
            this.label14.Text = "Codigo Postal : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 93;
            this.label13.Text = "Rua:";
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Location = new System.Drawing.Point(328, 85);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(120, 17);
            this.labelLocalidade.TabIndex = 89;
            this.labelLocalidade.Text = " Alvelos, Barcelos";
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(125, 85);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(73, 17);
            this.labelCodigoPostal.TabIndex = 90;
            this.labelCodigoPostal.Text = "4755-116 ";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Location = new System.Drawing.Point(51, 35);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(127, 17);
            this.labelRua.TabIndex = 91;
            this.labelRua.Text = "Rua da Estrada 31";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelNumDeWC);
            this.groupBoxInfo.Controls.Add(this.checkBoxDespesasIncluidas);
            this.groupBoxInfo.Controls.Add(this.labelPreco);
            this.groupBoxInfo.Controls.Add(this.labelMetrosQuadrados);
            this.groupBoxInfo.Controls.Add(this.labelNumDeAssoalhadas);
            this.groupBoxInfo.Controls.Add(this.labelAnoDeConstrucao);
            this.groupBoxInfo.Controls.Add(this.labelNumDeQuartos);
            this.groupBoxInfo.Location = new System.Drawing.Point(21, 233);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxInfo.Size = new System.Drawing.Size(543, 153);
            this.groupBoxInfo.TabIndex = 95;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Informações";
            // 
            // labelNumDeWC
            // 
            this.labelNumDeWC.AutoSize = true;
            this.labelNumDeWC.Location = new System.Drawing.Point(208, 118);
            this.labelNumDeWC.Name = "labelNumDeWC";
            this.labelNumDeWC.Size = new System.Drawing.Size(96, 17);
            this.labelNumDeWC.TabIndex = 83;
            this.labelNumDeWC.Text = "Nº de WCs: 2 ";
            // 
            // checkBoxDespesasIncluidas
            // 
            this.checkBoxDespesasIncluidas.AutoSize = true;
            this.checkBoxDespesasIncluidas.Checked = true;
            this.checkBoxDespesasIncluidas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDespesasIncluidas.Location = new System.Drawing.Point(373, 116);
            this.checkBoxDespesasIncluidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDespesasIncluidas.Name = "checkBoxDespesasIncluidas";
            this.checkBoxDespesasIncluidas.Size = new System.Drawing.Size(152, 21);
            this.checkBoxDespesasIncluidas.TabIndex = 11;
            this.checkBoxDespesasIncluidas.Text = "Despesas Incluídas";
            this.checkBoxDespesasIncluidas.UseVisualStyleBackColor = true;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(11, 118);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(185, 17);
            this.labelPreco.TabIndex = 84;
            this.labelPreco.Text = "Preço (Mensal):  210/quarto";
            // 
            // labelMetrosQuadrados
            // 
            this.labelMetrosQuadrados.AutoSize = true;
            this.labelMetrosQuadrados.Location = new System.Drawing.Point(9, 36);
            this.labelMetrosQuadrados.Name = "labelMetrosQuadrados";
            this.labelMetrosQuadrados.Size = new System.Drawing.Size(162, 17);
            this.labelMetrosQuadrados.TabIndex = 88;
            this.labelMetrosQuadrados.Text = "Metros Quadrados: 150 ";
            // 
            // labelNumDeAssoalhadas
            // 
            this.labelNumDeAssoalhadas.AutoSize = true;
            this.labelNumDeAssoalhadas.Location = new System.Drawing.Point(9, 78);
            this.labelNumDeAssoalhadas.Name = "labelNumDeAssoalhadas";
            this.labelNumDeAssoalhadas.Size = new System.Drawing.Size(148, 17);
            this.labelNumDeAssoalhadas.TabIndex = 86;
            this.labelNumDeAssoalhadas.Text = "Nº de Assoalhadas:  2";
            // 
            // labelAnoDeConstrucao
            // 
            this.labelAnoDeConstrucao.AutoSize = true;
            this.labelAnoDeConstrucao.Location = new System.Drawing.Point(289, 41);
            this.labelAnoDeConstrucao.Name = "labelAnoDeConstrucao";
            this.labelAnoDeConstrucao.Size = new System.Drawing.Size(169, 17);
            this.labelAnoDeConstrucao.TabIndex = 87;
            this.labelAnoDeConstrucao.Text = "Ano de Construção: 2015";
            // 
            // labelNumDeQuartos
            // 
            this.labelNumDeQuartos.AutoSize = true;
            this.labelNumDeQuartos.Location = new System.Drawing.Point(241, 81);
            this.labelNumDeQuartos.Name = "labelNumDeQuartos";
            this.labelNumDeQuartos.Size = new System.Drawing.Size(114, 17);
            this.labelNumDeQuartos.TabIndex = 85;
            this.labelNumDeQuartos.Text = "Nº de Quartos: 2";
            // 
            // groupBoxComodidades
            // 
            this.groupBoxComodidades.Controls.Add(this.checkBoxInternet);
            this.groupBoxComodidades.Controls.Add(this.checkBoxTelevisao);
            this.groupBoxComodidades.Controls.Add(this.checkBoxServicosDeLimpeza);
            this.groupBoxComodidades.Location = new System.Drawing.Point(21, 392);
            this.groupBoxComodidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxComodidades.Name = "groupBoxComodidades";
            this.groupBoxComodidades.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxComodidades.Size = new System.Drawing.Size(543, 62);
            this.groupBoxComodidades.TabIndex = 96;
            this.groupBoxComodidades.TabStop = false;
            this.groupBoxComodidades.Text = "Comodidades ";
            // 
            // checkBoxInternet
            // 
            this.checkBoxInternet.AutoSize = true;
            this.checkBoxInternet.Checked = true;
            this.checkBoxInternet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInternet.Location = new System.Drawing.Point(12, 30);
            this.checkBoxInternet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInternet.Name = "checkBoxInternet";
            this.checkBoxInternet.Size = new System.Drawing.Size(78, 21);
            this.checkBoxInternet.TabIndex = 12;
            this.checkBoxInternet.Text = "Internet";
            this.checkBoxInternet.UseVisualStyleBackColor = true;
            // 
            // checkBoxTelevisao
            // 
            this.checkBoxTelevisao.AutoSize = true;
            this.checkBoxTelevisao.Checked = true;
            this.checkBoxTelevisao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTelevisao.Location = new System.Drawing.Point(100, 30);
            this.checkBoxTelevisao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTelevisao.Name = "checkBoxTelevisao";
            this.checkBoxTelevisao.Size = new System.Drawing.Size(91, 21);
            this.checkBoxTelevisao.TabIndex = 13;
            this.checkBoxTelevisao.Text = "Televisão";
            this.checkBoxTelevisao.UseVisualStyleBackColor = true;
            // 
            // checkBoxServicosDeLimpeza
            // 
            this.checkBoxServicosDeLimpeza.AutoSize = true;
            this.checkBoxServicosDeLimpeza.Location = new System.Drawing.Point(201, 30);
            this.checkBoxServicosDeLimpeza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxServicosDeLimpeza.Name = "checkBoxServicosDeLimpeza";
            this.checkBoxServicosDeLimpeza.Size = new System.Drawing.Size(161, 21);
            this.checkBoxServicosDeLimpeza.TabIndex = 14;
            this.checkBoxServicosDeLimpeza.Text = "Serviços de Limpeza";
            this.checkBoxServicosDeLimpeza.UseVisualStyleBackColor = true;
            // 
            // descricaoGroupBox
            // 
            this.descricaoGroupBox.Controls.Add(this.label9);
            this.descricaoGroupBox.Location = new System.Drawing.Point(21, 460);
            this.descricaoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoGroupBox.Name = "descricaoGroupBox";
            this.descricaoGroupBox.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.descricaoGroupBox.Size = new System.Drawing.Size(543, 100);
            this.descricaoGroupBox.TabIndex = 97;
            this.descricaoGroupBox.TabStop = false;
            this.descricaoGroupBox.Text = "Descrição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 51);
            this.label9.TabIndex = 0;
            this.label9.Text = "Casa bastante moderna \r\n\r\nExcelente Localização\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelwcs);
            this.groupBox1.Controls.Add(this.labelprec);
            this.groupBox1.Controls.Add(this.labelquartos);
            this.groupBox1.Controls.Add(this.labelassoalhadas);
            this.groupBox1.Controls.Add(this.labelano);
            this.groupBox1.Controls.Add(this.labelmetros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(21, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(543, 153);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Nº de WCs: ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(373, 116);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Despesas Incluídas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Preço (Mensal):  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Metros Quadrados: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Nº de Assoalhadas: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ano de Construção: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 85;
            this.label7.Text = "Nº de Quartos: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelprop);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(21, 568);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox2.Size = new System.Drawing.Size(543, 100);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proprietário:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "DADOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1040, 766);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 45);
            this.button2.TabIndex = 100;
            this.button2.Text = "ALUGAR QUARTO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(494, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 102;
            this.label10.Text = "Classificação:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(72, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 17);
            this.label11.TabIndex = 103;
            this.label11.Text = "1 QUARTO DISPONIVEL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(596, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 43);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "210€/MÊS";
            // 
            // mapa
            // 
            this.mapa.AutoScroll = true;
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(594, 422);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 20;
            this.mapa.MinZoom = 10;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(616, 326);
            this.mapa.TabIndex = 110;
            this.mapa.Zoom = 2D;
            this.mapa.DoubleClick += new System.EventHandler(this.mapa_DoubleClick);
            // 
            // labelmetros
            // 
            this.labelmetros.AutoSize = true;
            this.labelmetros.Location = new System.Drawing.Point(146, 36);
            this.labelmetros.Name = "labelmetros";
            this.labelmetros.Size = new System.Drawing.Size(32, 17);
            this.labelmetros.TabIndex = 89;
            this.labelmetros.Text = "150";
            // 
            // labelano
            // 
            this.labelano.AutoSize = true;
            this.labelano.Location = new System.Drawing.Point(406, 35);
            this.labelano.Name = "labelano";
            this.labelano.Size = new System.Drawing.Size(40, 17);
            this.labelano.TabIndex = 90;
            this.labelano.Text = "2010";
            // 
            // labelassoalhadas
            // 
            this.labelassoalhadas.AutoSize = true;
            this.labelassoalhadas.Location = new System.Drawing.Point(149, 77);
            this.labelassoalhadas.Name = "labelassoalhadas";
            this.labelassoalhadas.Size = new System.Drawing.Size(16, 17);
            this.labelassoalhadas.TabIndex = 91;
            this.labelassoalhadas.Text = "2";
            // 
            // labelquartos
            // 
            this.labelquartos.AutoSize = true;
            this.labelquartos.Location = new System.Drawing.Point(353, 81);
            this.labelquartos.Name = "labelquartos";
            this.labelquartos.Size = new System.Drawing.Size(16, 17);
            this.labelquartos.TabIndex = 92;
            this.labelquartos.Text = "4";
            // 
            // labelprec
            // 
            this.labelprec.AutoSize = true;
            this.labelprec.Location = new System.Drawing.Point(124, 118);
            this.labelprec.Name = "labelprec";
            this.labelprec.Size = new System.Drawing.Size(32, 17);
            this.labelprec.TabIndex = 93;
            this.labelprec.Text = "210";
            // 
            // labelwcs
            // 
            this.labelwcs.AutoSize = true;
            this.labelwcs.Location = new System.Drawing.Point(299, 117);
            this.labelwcs.Name = "labelwcs";
            this.labelwcs.Size = new System.Drawing.Size(16, 17);
            this.labelwcs.TabIndex = 94;
            this.labelwcs.Text = "2";
            // 
            // labelprop
            // 
            this.labelprop.AutoSize = true;
            this.labelprop.Location = new System.Drawing.Point(84, 38);
            this.labelprop.Name = "labelprop";
            this.labelprop.Size = new System.Drawing.Size(140, 17);
            this.labelprop.TabIndex = 2;
            this.labelprop.Text = "Filipe Andre Gouveia";
            // 
            // Habitação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 836);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.descricaoGroupBox);
            this.Controls.Add(this.groupBoxComodidades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxMorada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFotos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Habitação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitação";
            this.Load += new System.EventHandler(this.Habitação_Load);
            this.groupBoxFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.groupBoxMorada.ResumeLayout(false);
            this.groupBoxMorada.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxComodidades.ResumeLayout(false);
            this.groupBoxComodidades.PerformLayout();
            this.descricaoGroupBox.ResumeLayout(false);
            this.descricaoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFotos;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonRemoverFoto;
        private System.Windows.Forms.Button buttonAdicionarFotos;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMorada;
        private System.Windows.Forms.Label labelLocalidade;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelNumDeWC;
        private System.Windows.Forms.CheckBox checkBoxDespesasIncluidas;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelMetrosQuadrados;
        private System.Windows.Forms.Label labelNumDeAssoalhadas;
        private System.Windows.Forms.Label labelAnoDeConstrucao;
        private System.Windows.Forms.Label labelNumDeQuartos;
        private System.Windows.Forms.GroupBox groupBoxComodidades;
        private System.Windows.Forms.CheckBox checkBoxInternet;
        private System.Windows.Forms.CheckBox checkBoxTelevisao;
        private System.Windows.Forms.CheckBox checkBoxServicosDeLimpeza;
        private System.Windows.Forms.GroupBox descricaoGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private Mapa mapa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelwcs;
        private System.Windows.Forms.Label labelprec;
        private System.Windows.Forms.Label labelquartos;
        private System.Windows.Forms.Label labelassoalhadas;
        private System.Windows.Forms.Label labelano;
        private System.Windows.Forms.Label labelmetros;
        private System.Windows.Forms.Label labelprop;
    }
}