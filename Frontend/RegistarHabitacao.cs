using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Middleware;
using System.Text;

namespace Frontend
{
    public partial class RegistarHabitacao : Form
    {
        private List<string> _imgFilenames = new List<string>();
        private int _indexImgAtual = -1;
        private ErrorProvider _errorProvider1 = new ErrorProvider();

        public RegistarHabitacao()
        {
            InitializeComponent();
        }

        public void RegistarHabitacao_Load(object sender, EventArgs e)
        {
            maskedTextBoxCodigoPostal.MaskInputRejected += maskedTextBoxCodigoPostal_MaskInputRejected;
            AllowDrop = true;
        }

        /// <summary>
        /// Clique no botão "buttonAdicionar".
        /// Extrai toda a informação introduzida pelo utilizador e procede à sua validação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionar_Click(object sender, EventArgs e)
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
            var comodidades = new Comodidades(checkBoxTelevisao.Checked, checkBoxInternet.Checked, checkBoxServicosDeLimpeza.Checked);

            // Descrição da Habitação
            var descricao = textBoxDescricao.Text;

            // Construir a habitação
            var quartos = new List<Quarto>(numQuartos);
            for (var i = 0; i < numQuartos; i++)
            {
                quartos.Add(new Quarto(new List<ICama> {new Cama(TipoCama.Single)}));
            }
//            var morada = new Morada(null, 0, null); // TODO
//            var habitacao = new Habitacao(quartos, numAssoalhadas, metrosQuadrados, anoDeConstrucao, null, comodidades);
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
        private void buttonAdicionarFotos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"JPG|*.jpg;*.jpeg|PNG|*.png"; // TODO: introduzir esta informação (e o tamanho, resolução num requisito funcional
            openFileDialog1.Multiselect = true; // Aceitar múltiplas fotos
            var result = openFileDialog1.ShowDialog(); // Mostra o Dialog.
            if (result == DialogResult.OK) // Test result.
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    if (_imgFilenames.Contains(filename)) continue;

                    // Adiciona filename ao nosso nomes de ficheiros
                    _imgFilenames.Add(filename);
                    _indexImgAtual += 1;
                    AtualizarFoto(_indexImgAtual);
                   
                }
            }
            MessageBox.Show(_imgFilenames.Count.ToString());      
        }

        /// <summary>
        /// Clique no botão "buttonRemoverFoto".
        /// Remove a foto atualmente selecionada e visível em pictureBoxImagem. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoverFoto_Click(object sender, EventArgs e)
        {
            var ultimaFoto = _imgFilenames.LastOrDefault();
            
            if (!string.IsNullOrEmpty(ultimaFoto))
            {
                // Remover a última foto
                _imgFilenames.Remove(ultimaFoto);
                ultimaFoto = _imgFilenames.LastOrDefault();
            }
            pictureBoxImagem.Image = ultimaFoto != null ? Image.FromFile(ultimaFoto) : null;
        }

        /// <summary>
        /// Clique no botão "buttonPrevious".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (_indexImgAtual >= 0)
            {
                if (_indexImgAtual + 1 < _imgFilenames.Count) // index 1, 2 fotos -> index 0, 2 fotos
                {
                    _indexImgAtual -= 1;
                    AtualizarFoto(_indexImgAtual);
                }
            }
            else
            {
                AtualizarFoto(-1);
            }
        }

        /// <summary>
        /// Clique no botão "buttonNext".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_imgFilenames.Count > 0)
            {
                if (_indexImgAtual + 1 < _imgFilenames.Count)
                {
                    _indexImgAtual += 1;
                    AtualizarFoto(_indexImgAtual);
                }
            }
            else
            {
                AtualizarFoto(-1);
            }
        }

        private void AtualizarFoto(int index)
        {
            // bounds checking
            if (index >= 0 && index < _imgFilenames.Count)
            {
                var img = _imgFilenames[index];
                if (img == null) throw new ArgumentNullException(nameof(img));
                pictureBoxImagem.Image = Image.FromFile(img);
            }
            else
            {
                pictureBoxImagem.Image = null;
            }
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

        private void pictureBoxImagem_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBoxImagem_DragDrop(object sender, DragEventArgs e)
        {
            /*int x = this.PointToClient(new Point(e.X, e.Y)).X;
            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBoxImagem.Location.X && x <= pictureBoxImagem.Location.X + pictureBoxImagem.Width && y >= pictureBoxImagem.Location.Y && y <= pictureBoxImagem.Location.Y + pictureBoxImagem.Height)
            {
                var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
                pictureBoxImagem.Image = Image.FromFile(files[0]);

            }*/

            var transfo = (PictureBox)e.Data.GetData(typeof(PictureBox));
            transfo.Location = PointToClient(new Point(e.X, e.Y));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesquisarProprietario prop = new PesquisarProprietario();
            prop.MdiParent = IGE.ActiveForm;
            prop.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovoProprietario newProp = new NovoProprietario();
            newProp.MdiParent = IGE.ActiveForm;
            newProp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rua = textBoxRua.Text;
            string loc = textBoxLocalidade.Text;
            string cod = maskedTextBoxCodigoPostal.Text.ToString();

            StringBuilder add = new StringBuilder("http://maps.google.com/maps?q=");
            add.Append(rua);
            add.Append(loc);
            add.Append(cod);
            webBrowser1.Navigate(add.ToString());
         
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
