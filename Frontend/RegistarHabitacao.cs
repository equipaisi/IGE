using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Middleware;

namespace Frontend
{
    public partial class RegistarHabitacao : Form
    {
        private HashSet<string> _imgFilenames = new HashSet<string>();
        private int _indexImgAtual = -1;
        private ErrorProvider _errorProvider1 = new ErrorProvider();

        public RegistarHabitacao()
        {
            InitializeComponent();
        }

        public void RegistarHabitacao_Load(object sender, EventArgs e)
        {
            //maskedTextBoxCodigoPostal.Mask = "4715-343";
            maskedTextBoxCodigoPostal.MaskInputRejected += maskedTextBoxCodigoPostal_MaskInputRejected;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxProprietario.SelectedItem == "ADICIONAR ")
            {
                new NovoProprietario().ShowDialog();
            }
        }

        /// <summary>
        /// Clique no botão "buttonAdicionar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            #region Morada
            // Rua
            var rua = textBoxRua.Text;

            // Código Postal
//            var cp = new Middleware.CodigoPostal(textBoxCodigoPostal.Text);
//            MessageBox.Show($"O seu código postal é {cp}");

            // Localidade
            var localidade = textBoxLocalidade.Text;
            #endregion

            #region Informações
            // Metros Quadrados
            int metrosQuadrados;
            if (!int.TryParse(textBoxMetrosQuadrados.Text, out metrosQuadrados))
            {
                MessageBox.Show("Valor de \"Metros Quadrados\" inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Metros quadrados: {metrosQuadrados} m2");
            }
            // Ano de Construção
            var ac = numericUpDownAnoDeConstrucao.Text;
            int anoDeConstrucao;
            if (!int.TryParse(ac, out anoDeConstrucao))
            {
                MessageBox.Show("Valor de \"Ano de Construção\" inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (anoDeConstrucao > DateTime.Now.Year)
            {
                MessageBox.Show(
                    $"Valor de \"Ano de Construção\" inválido: não pode ser superior ao ano atual {DateTime.Now.Year}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Ano de Construção: {anoDeConstrucao}");
            }

            // Nº de Assoalhadas
            int numAssoalhadas;
            if (!int.TryParse(comboBoxNumDeAssoalhadas.Text, out numAssoalhadas))
            {
                MessageBox.Show("Valor de \"Nº de Assoalhadas\" inválido: não é número inteiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nº de Quartos

            var numQuartos = ParseNumberOrFail(comboBoxNumDeQuartos.Text, "Valor de \"Nº de Quartos\" inválido: não é número inteiro");
            #endregion

            // Comodidades
            var comodidades = new Middleware.Comodidades(checkBoxTelevisao.Checked, checkBoxInternet.Checked, checkBoxServicosDeLimpeza.Checked);

            // Descrição da Habitação
            var descricao = textBoxDescricao.Text;

            // Construir a habitação
            var quartos = new List<Middleware.Quarto>(numQuartos);
            for (var i = 0; i < numQuartos; i++)
            {
                quartos.Add(new Quarto(new List<ICama> {new Cama(TipoCama.Single)}));
            }
//            var morada = new Middleware.Morada(null, 0, null); // TODO
//            var habitacao = new Middleware.Habitacao(quartos, numAssoalhadas, metrosQuadrados, anoDeConstrucao, null, comodidades);
//            MessageBox.Show(habitacao.ToString());
        }

        // TODO: move this function from here
        private static int ParseNumberOrFail(string s, string errorMsg)
        {
            int result;
            if (!int.TryParse(s, out result))
            {
                MessageBox.Show(errorMsg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        /// <summary>
        /// Clique no botão "buttonAdicionarFotos".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"JPG|*.jpg;*.jpeg|PNG|*.png"; // TODO: introduzir esta informação (e o tamanho, resolução num requisito funcional
            openFileDialog1.Multiselect = true; // Aceitar múltiplas fotos
            var result = openFileDialog1.ShowDialog(); // Mostra o Dialog.
            if (result == DialogResult.OK) // Test result.
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    // Adiciona filename ao nosso nomes de ficheiros
                    _imgFilenames.Add(filename);
                    var img = Image.FromFile(filename);
                    
                    pictureBoxImagem.Image = img;
                    //pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                _indexImgAtual = _imgFilenames.Count - 1;
            }
            MessageBox.Show(_imgFilenames.Count.ToString());
            
        }

        /// <summary>
        /// Clique no botão "buttonRemoverFoto".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // Remover a última foto
            _imgFilenames.Remove(_imgFilenames.Last());
            var ultimaFoto = _imgFilenames.LastOrDefault();
            if (!string.IsNullOrEmpty(ultimaFoto))
            {
                pictureBoxImagem.Image = Image.FromFile(ultimaFoto);
            }
            else
            {
                // no caso de não termos fotos para mostrar
                pictureBoxImagem.Image = null;
            }
            
        }

        /// <summary>
        /// Clique no bõtão "buttonPrevious".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (_indexImgAtual > -1)
            {
                _indexImgAtual -= 1;
            }
            //pictureBoxImagem.Image = Image.FromFile(_imgFilenames.Where());
        }

        /// <summary>
        /// Clique no bõtão "buttonNext".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            _indexImgAtual += 1;
        }


        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //if (textBox1.Text != "") { pictureBoxMapa.Show(); }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCodigoPostal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTipCodigoPostal.ToolTipTitle = "Input Inválido";
            toolTipCodigoPostal.Show("Código postal tem que ter o formato [0-9]{4}-[0-9]{3}", maskedTextBoxCodigoPostal,
                maskedTextBoxCodigoPostal.Location, 5000);
        }

        private void textBoxMetrosQuadrados_Validating(object sender, CancelEventArgs e)
        {
            int metrosQuadrados;
            if (!int.TryParse(textBoxMetrosQuadrados.Text, out metrosQuadrados))
            {
                e.Cancel = true;
                textBoxMetrosQuadrados.Select(0, textBoxMetrosQuadrados.Text.Length);

                _errorProvider1.SetError(textBoxMetrosQuadrados, "Valor de \"Metros Quadrados\" inválido");
            }
        }

        private void textBoxMetrosQuadrados_Validated(object sender, EventArgs e)
        {
            _errorProvider1.SetError(textBoxMetrosQuadrados, "");
        }

        private void RegistarHabitacao_Load_1(object sender, EventArgs e)
        {
            
        }

        private void labelProprietario_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDespesasIncluidas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLocalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNumDeAssoalhadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
