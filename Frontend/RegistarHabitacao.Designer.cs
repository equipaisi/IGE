namespace Frontend
{
    partial class RegistarHabitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistarHabitacao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMetrosQuadrados = new System.Windows.Forms.TextBox();
            this.labelMetrosQuadrados = new System.Windows.Forms.Label();
            this.labelNumDeAssoalhadas = new System.Windows.Forms.Label();
            this.labelAnoDeConstrucao = new System.Windows.Forms.Label();
            this.labelNumDeQuartos = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxNumDeQuartos = new System.Windows.Forms.ComboBox();
            this.labelProprietario = new System.Windows.Forms.Label();
            this.comboBoxProprietario = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAdicionarFotos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxMapa = new System.Windows.Forms.PictureBox();
            this.checkBoxInternet = new System.Windows.Forms.CheckBox();
            this.checkBoxTelevisao = new System.Windows.Forms.CheckBox();
            this.checkBoxServicosDeLimpeza = new System.Windows.Forms.CheckBox();
            this.groupBoxMorada = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLocalidade = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.groupBoxComodidades = new System.Windows.Forms.GroupBox();
            this.comboBoxNumDeAssoalhadas = new System.Windows.Forms.ComboBox();
            this.numericUpDownAnoDeConstrucao = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.groupBoxFotos = new System.Windows.Forms.GroupBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRemoverFoto = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelNumDeWC = new System.Windows.Forms.Label();
            this.comboBoxNumDeWC = new System.Windows.Forms.ComboBox();
            this.checkBoxDespesasIncluidas = new System.Windows.Forms.CheckBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.toolTipCodigoPostal = new System.Windows.Forms.ToolTip(this.components);
            this.descricaoGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).BeginInit();
            this.groupBoxMorada.SuspendLayout();
            this.groupBoxComodidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnoDeConstrucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.groupBoxFotos.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.descricaoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTAR HABITAÇÃO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMetrosQuadrados
            // 
            this.textBoxMetrosQuadrados.Location = new System.Drawing.Point(164, 32);
            this.textBoxMetrosQuadrados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMetrosQuadrados.Name = "textBoxMetrosQuadrados";
            this.textBoxMetrosQuadrados.Size = new System.Drawing.Size(97, 22);
            this.textBoxMetrosQuadrados.TabIndex = 5;
            this.textBoxMetrosQuadrados.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxMetrosQuadrados.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMetrosQuadrados_Validating);
            this.textBoxMetrosQuadrados.Validated += new System.EventHandler(this.textBoxMetrosQuadrados_Validated);
            // 
            // labelMetrosQuadrados
            // 
            this.labelMetrosQuadrados.AutoSize = true;
            this.labelMetrosQuadrados.Location = new System.Drawing.Point(9, 36);
            this.labelMetrosQuadrados.Name = "labelMetrosQuadrados";
            this.labelMetrosQuadrados.Size = new System.Drawing.Size(130, 17);
            this.labelMetrosQuadrados.TabIndex = 88;
            this.labelMetrosQuadrados.Text = "Metros Quadrados:";
            // 
            // labelNumDeAssoalhadas
            // 
            this.labelNumDeAssoalhadas.AutoSize = true;
            this.labelNumDeAssoalhadas.Location = new System.Drawing.Point(9, 78);
            this.labelNumDeAssoalhadas.Name = "labelNumDeAssoalhadas";
            this.labelNumDeAssoalhadas.Size = new System.Drawing.Size(136, 17);
            this.labelNumDeAssoalhadas.TabIndex = 86;
            this.labelNumDeAssoalhadas.Text = "Nº de Assoalhadas: ";
            this.labelNumDeAssoalhadas.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelAnoDeConstrucao
            // 
            this.labelAnoDeConstrucao.AutoSize = true;
            this.labelAnoDeConstrucao.Location = new System.Drawing.Point(289, 41);
            this.labelAnoDeConstrucao.Name = "labelAnoDeConstrucao";
            this.labelAnoDeConstrucao.Size = new System.Drawing.Size(137, 17);
            this.labelAnoDeConstrucao.TabIndex = 87;
            this.labelAnoDeConstrucao.Text = "Ano de Construção: ";
            // 
            // labelNumDeQuartos
            // 
            this.labelNumDeQuartos.AutoSize = true;
            this.labelNumDeQuartos.Location = new System.Drawing.Point(241, 81);
            this.labelNumDeQuartos.Name = "labelNumDeQuartos";
            this.labelNumDeQuartos.Size = new System.Drawing.Size(102, 17);
            this.labelNumDeQuartos.TabIndex = 85;
            this.labelNumDeQuartos.Text = "Nº de Quartos:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(16, 22);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(509, 149);
            this.textBoxDescricao.TabIndex = 15;
            // 
            // comboBoxNumDeQuartos
            // 
            this.comboBoxNumDeQuartos.FormattingEnabled = true;
            this.comboBoxNumDeQuartos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxNumDeQuartos.Location = new System.Drawing.Point(349, 78);
            this.comboBoxNumDeQuartos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNumDeQuartos.Name = "comboBoxNumDeQuartos";
            this.comboBoxNumDeQuartos.Size = new System.Drawing.Size(60, 24);
            this.comboBoxNumDeQuartos.TabIndex = 8;
            this.comboBoxNumDeQuartos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.Location = new System.Drawing.Point(67, 74);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(90, 17);
            this.labelProprietario.TabIndex = 92;
            this.labelProprietario.Text = "Proprietário: ";
            this.labelProprietario.Click += new System.EventHandler(this.labelProprietario_Click);
            // 
            // comboBoxProprietario
            // 
            this.comboBoxProprietario.FormattingEnabled = true;
            this.comboBoxProprietario.Items.AddRange(new object[] {
            "ADICIONAR ",
            "José Afonso Manuel da Silva Correia (12154270)",
            "Filipe Ricardo (24564110)",
            "João Pereira (14214529)"});
            this.comboBoxProprietario.Location = new System.Drawing.Point(160, 70);
            this.comboBoxProprietario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProprietario.Name = "comboBoxProprietario";
            this.comboBoxProprietario.Size = new System.Drawing.Size(369, 24);
            this.comboBoxProprietario.TabIndex = 1;
            this.comboBoxProprietario.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 697);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 80;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonAdicionarFotos
            // 
            this.buttonAdicionarFotos.Location = new System.Drawing.Point(391, 324);
            this.buttonAdicionarFotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarFotos.Name = "buttonAdicionarFotos";
            this.buttonAdicionarFotos.Size = new System.Drawing.Size(52, 33);
            this.buttonAdicionarFotos.TabIndex = 20;
            this.buttonAdicionarFotos.Text = "+";
            this.buttonAdicionarFotos.UseVisualStyleBackColor = true;
            this.buttonAdicionarFotos.Click += new System.EventHandler(this.buttonAdicionarFotos_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 21;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBoxMapa
            // 
            this.pictureBoxMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMapa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMapa.Image")));
            this.pictureBoxMapa.Location = new System.Drawing.Point(659, 426);
            this.pictureBoxMapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMapa.Name = "pictureBoxMapa";
            this.pictureBoxMapa.Size = new System.Drawing.Size(533, 307);
            this.pictureBoxMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMapa.TabIndex = 23;
            this.pictureBoxMapa.TabStop = false;
            this.pictureBoxMapa.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // checkBoxInternet
            // 
            this.checkBoxInternet.AutoSize = true;
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
            this.checkBoxTelevisao.Location = new System.Drawing.Point(100, 30);
            this.checkBoxTelevisao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTelevisao.Name = "checkBoxTelevisao";
            this.checkBoxTelevisao.Size = new System.Drawing.Size(91, 21);
            this.checkBoxTelevisao.TabIndex = 13;
            this.checkBoxTelevisao.Text = "Televisão";
            this.checkBoxTelevisao.UseVisualStyleBackColor = true;
            this.checkBoxTelevisao.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
            // groupBoxMorada
            // 
            this.groupBoxMorada.Controls.Add(this.maskedTextBoxCodigoPostal);
            this.groupBoxMorada.Controls.Add(this.textBoxLocalidade);
            this.groupBoxMorada.Controls.Add(this.textBoxRua);
            this.groupBoxMorada.Controls.Add(this.labelLocalidade);
            this.groupBoxMorada.Controls.Add(this.labelCodigoPostal);
            this.groupBoxMorada.Controls.Add(this.labelRua);
            this.groupBoxMorada.Location = new System.Drawing.Point(69, 119);
            this.groupBoxMorada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMorada.Name = "groupBoxMorada";
            this.groupBoxMorada.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxMorada.Size = new System.Drawing.Size(543, 145);
            this.groupBoxMorada.TabIndex = 93;
            this.groupBoxMorada.TabStop = false;
            this.groupBoxMorada.Text = "Morada";
            // 
            // maskedTextBoxCodigoPostal
            // 
            this.maskedTextBoxCodigoPostal.BeepOnError = true;
            this.maskedTextBoxCodigoPostal.Location = new System.Drawing.Point(121, 103);
            this.maskedTextBoxCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxCodigoPostal.Mask = "0000-999";
            this.maskedTextBoxCodigoPostal.Name = "maskedTextBoxCodigoPostal";
            this.maskedTextBoxCodigoPostal.Size = new System.Drawing.Size(76, 22);
            this.maskedTextBoxCodigoPostal.TabIndex = 3;
            this.maskedTextBoxCodigoPostal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCodigoPostal_MaskInputRejected);
            // 
            // textBoxLocalidade
            // 
            this.textBoxLocalidade.AutoCompleteCustomSource.AddRange(new string[] {
            "Braga",
            "Viana do Castelo",
            "Porto",
            "Guimarães",
            "Lisboa",
            "Sesimbra"});
            this.textBoxLocalidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxLocalidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxLocalidade.Location = new System.Drawing.Point(324, 103);
            this.textBoxLocalidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocalidade.Name = "textBoxLocalidade";
            this.textBoxLocalidade.Size = new System.Drawing.Size(191, 22);
            this.textBoxLocalidade.TabIndex = 4;
            this.textBoxLocalidade.TextChanged += new System.EventHandler(this.textBoxLocalidade_TextChanged);
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(59, 32);
            this.textBoxRua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRua.Multiline = true;
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(456, 57);
            this.textBoxRua.TabIndex = 2;
            this.textBoxRua.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Location = new System.Drawing.Point(236, 107);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(81, 17);
            this.labelLocalidade.TabIndex = 89;
            this.labelLocalidade.Text = "Localidade:";
            this.labelLocalidade.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(9, 107);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(103, 17);
            this.labelCodigoPostal.TabIndex = 90;
            this.labelCodigoPostal.Text = "Código Postal: ";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Location = new System.Drawing.Point(9, 36);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(42, 17);
            this.labelRua.TabIndex = 91;
            this.labelRua.Text = "Rua: ";
            // 
            // groupBoxComodidades
            // 
            this.groupBoxComodidades.Controls.Add(this.checkBoxInternet);
            this.groupBoxComodidades.Controls.Add(this.checkBoxTelevisao);
            this.groupBoxComodidades.Controls.Add(this.checkBoxServicosDeLimpeza);
            this.groupBoxComodidades.Location = new System.Drawing.Point(69, 428);
            this.groupBoxComodidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxComodidades.Name = "groupBoxComodidades";
            this.groupBoxComodidades.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxComodidades.Size = new System.Drawing.Size(543, 62);
            this.groupBoxComodidades.TabIndex = 95;
            this.groupBoxComodidades.TabStop = false;
            this.groupBoxComodidades.Text = "Comodidades ";
            // 
            // comboBoxNumDeAssoalhadas
            // 
            this.comboBoxNumDeAssoalhadas.FormattingEnabled = true;
            this.comboBoxNumDeAssoalhadas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNumDeAssoalhadas.Location = new System.Drawing.Point(152, 74);
            this.comboBoxNumDeAssoalhadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNumDeAssoalhadas.Name = "comboBoxNumDeAssoalhadas";
            this.comboBoxNumDeAssoalhadas.Size = new System.Drawing.Size(71, 24);
            this.comboBoxNumDeAssoalhadas.TabIndex = 7;
            this.comboBoxNumDeAssoalhadas.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumDeAssoalhadas_SelectedIndexChanged);
            // 
            // numericUpDownAnoDeConstrucao
            // 
            this.numericUpDownAnoDeConstrucao.Location = new System.Drawing.Point(439, 33);
            this.numericUpDownAnoDeConstrucao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownAnoDeConstrucao.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownAnoDeConstrucao.Minimum = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            this.numericUpDownAnoDeConstrucao.Name = "numericUpDownAnoDeConstrucao";
            this.numericUpDownAnoDeConstrucao.Size = new System.Drawing.Size(77, 22);
            this.numericUpDownAnoDeConstrucao.TabIndex = 6;
            this.numericUpDownAnoDeConstrucao.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagem.Location = new System.Drawing.Point(9, 20);
            this.pictureBoxImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(514, 294);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagem.TabIndex = 22;
            this.pictureBoxImagem.TabStop = false;
            this.pictureBoxImagem.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxImagem_DragDrop);
            this.pictureBoxImagem.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxImagem_DragEnter);
            this.pictureBoxImagem.DoubleClick += new System.EventHandler(this.buttonAdicionarFotos_Click);
            // 
            // groupBoxFotos
            // 
            this.groupBoxFotos.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxFotos.Controls.Add(this.buttonPrevious);
            this.groupBoxFotos.Controls.Add(this.buttonNext);
            this.groupBoxFotos.Controls.Add(this.buttonRemoverFoto);
            this.groupBoxFotos.Controls.Add(this.buttonAdicionarFotos);
            this.groupBoxFotos.Controls.Add(this.pictureBoxImagem);
            this.groupBoxFotos.Location = new System.Drawing.Point(659, 50);
            this.groupBoxFotos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxFotos.Name = "groupBoxFotos";
            this.groupBoxFotos.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxFotos.Size = new System.Drawing.Size(533, 367);
            this.groupBoxFotos.TabIndex = 34;
            this.groupBoxFotos.TabStop = false;
            this.groupBoxFotos.Text = "Fotos";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(113, 324);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(73, 33);
            this.buttonPrevious.TabIndex = 37;
            this.buttonPrevious.Text = "<=";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(192, 324);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(73, 33);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "=>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRemoverFoto
            // 
            this.buttonRemoverFoto.Location = new System.Drawing.Point(333, 324);
            this.buttonRemoverFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoverFoto.Name = "buttonRemoverFoto";
            this.buttonRemoverFoto.Size = new System.Drawing.Size(52, 33);
            this.buttonRemoverFoto.TabIndex = 35;
            this.buttonRemoverFoto.Text = "-";
            this.buttonRemoverFoto.UseVisualStyleBackColor = true;
            this.buttonRemoverFoto.Click += new System.EventHandler(this.buttonRemoverFoto_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelNumDeWC);
            this.groupBoxInfo.Controls.Add(this.comboBoxNumDeWC);
            this.groupBoxInfo.Controls.Add(this.checkBoxDespesasIncluidas);
            this.groupBoxInfo.Controls.Add(this.textBoxPreco);
            this.groupBoxInfo.Controls.Add(this.labelPreco);
            this.groupBoxInfo.Controls.Add(this.textBoxMetrosQuadrados);
            this.groupBoxInfo.Controls.Add(this.labelMetrosQuadrados);
            this.groupBoxInfo.Controls.Add(this.numericUpDownAnoDeConstrucao);
            this.groupBoxInfo.Controls.Add(this.labelNumDeAssoalhadas);
            this.groupBoxInfo.Controls.Add(this.comboBoxNumDeAssoalhadas);
            this.groupBoxInfo.Controls.Add(this.labelAnoDeConstrucao);
            this.groupBoxInfo.Controls.Add(this.labelNumDeQuartos);
            this.groupBoxInfo.Controls.Add(this.comboBoxNumDeQuartos);
            this.groupBoxInfo.Location = new System.Drawing.Point(69, 270);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxInfo.Size = new System.Drawing.Size(543, 153);
            this.groupBoxInfo.TabIndex = 94;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Informações";
            // 
            // labelNumDeWC
            // 
            this.labelNumDeWC.AutoSize = true;
            this.labelNumDeWC.Location = new System.Drawing.Point(208, 118);
            this.labelNumDeWC.Name = "labelNumDeWC";
            this.labelNumDeWC.Size = new System.Drawing.Size(80, 17);
            this.labelNumDeWC.TabIndex = 83;
            this.labelNumDeWC.Text = "Nº de WCs:";
            // 
            // comboBoxNumDeWC
            // 
            this.comboBoxNumDeWC.FormattingEnabled = true;
            this.comboBoxNumDeWC.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxNumDeWC.Location = new System.Drawing.Point(297, 113);
            this.comboBoxNumDeWC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNumDeWC.Name = "comboBoxNumDeWC";
            this.comboBoxNumDeWC.Size = new System.Drawing.Size(60, 24);
            this.comboBoxNumDeWC.TabIndex = 10;
            // 
            // checkBoxDespesasIncluidas
            // 
            this.checkBoxDespesasIncluidas.AutoSize = true;
            this.checkBoxDespesasIncluidas.Location = new System.Drawing.Point(373, 116);
            this.checkBoxDespesasIncluidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDespesasIncluidas.Name = "checkBoxDespesasIncluidas";
            this.checkBoxDespesasIncluidas.Size = new System.Drawing.Size(152, 21);
            this.checkBoxDespesasIncluidas.TabIndex = 11;
            this.checkBoxDespesasIncluidas.Text = "Despesas Incluídas";
            this.checkBoxDespesasIncluidas.UseVisualStyleBackColor = true;
            this.checkBoxDespesasIncluidas.CheckedChanged += new System.EventHandler(this.checkBoxDespesasIncluidas_CheckedChanged);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(125, 114);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(72, 22);
            this.textBoxPreco.TabIndex = 9;
            this.textBoxPreco.TextChanged += new System.EventHandler(this.textBoxPreco_TextChanged);
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(11, 118);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(108, 17);
            this.labelPreco.TabIndex = 84;
            this.labelPreco.Text = "Preço (Mensal):";
            // 
            // descricaoGroupBox
            // 
            this.descricaoGroupBox.Controls.Add(this.textBoxDescricao);
            this.descricaoGroupBox.Location = new System.Drawing.Point(70, 496);
            this.descricaoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoGroupBox.Name = "descricaoGroupBox";
            this.descricaoGroupBox.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.descricaoGroupBox.Size = new System.Drawing.Size(543, 187);
            this.descricaoGroupBox.TabIndex = 82;
            this.descricaoGroupBox.TabStop = false;
            this.descricaoGroupBox.Text = "Descrição";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 96;
            this.button2.Text = "CRIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 31);
            this.button3.TabIndex = 97;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegistarHabitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 764);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxFotos);
            this.Controls.Add(this.groupBoxComodidades);
            this.Controls.Add(this.groupBoxMorada);
            this.Controls.Add(this.pictureBoxMapa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxProprietario);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.descricaoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RegistarHabitacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registar Habitação";
            this.Load += new System.EventHandler(this.RegistarHabitacao_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).EndInit();
            this.groupBoxMorada.ResumeLayout(false);
            this.groupBoxMorada.PerformLayout();
            this.groupBoxComodidades.ResumeLayout(false);
            this.groupBoxComodidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnoDeConstrucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.groupBoxFotos.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.descricaoGroupBox.ResumeLayout(false);
            this.descricaoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMetrosQuadrados;
        private System.Windows.Forms.Label labelMetrosQuadrados;
        private System.Windows.Forms.Label labelNumDeAssoalhadas;
        private System.Windows.Forms.Label labelAnoDeConstrucao;
        private System.Windows.Forms.Label labelNumDeQuartos;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxNumDeQuartos;
        private System.Windows.Forms.Label labelProprietario;
        private System.Windows.Forms.ComboBox comboBoxProprietario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAdicionarFotos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxMapa;
        private System.Windows.Forms.CheckBox checkBoxInternet;
        private System.Windows.Forms.CheckBox checkBoxTelevisao;
        private System.Windows.Forms.CheckBox checkBoxServicosDeLimpeza;
        private System.Windows.Forms.GroupBox groupBoxMorada;
        private System.Windows.Forms.TextBox textBoxLocalidade;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label labelLocalidade;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.GroupBox groupBoxComodidades;
        private System.Windows.Forms.ComboBox comboBoxNumDeAssoalhadas;
        private System.Windows.Forms.NumericUpDown numericUpDownAnoDeConstrucao;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.GroupBox groupBoxFotos;
        private System.Windows.Forms.Button buttonRemoverFoto;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigoPostal;
        private System.Windows.Forms.ToolTip toolTipCodigoPostal;
        private System.Windows.Forms.GroupBox descricaoGroupBox;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.CheckBox checkBoxDespesasIncluidas;
        private System.Windows.Forms.Label labelNumDeWC;
        private System.Windows.Forms.ComboBox comboBoxNumDeWC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}