using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Middleware;
using System.Text;
using Facebook;
using GoogleMaps;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.WindowsForms;

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
            #region Mapa
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl.SetPositionByKeywords("Barcelos, Portugal");
            gMapControl.ShowCenter = false; // remove a cruz vermelha no centro do gMapControl
            gMapControl.MinZoom = 3;
            gMapControl.Zoom = 5;
            gMapControl.MaxZoom = 12;
            #endregion
        }

        /// <summary>
        /// Clique no botão "buttonAdicionar".
        /// Extrai toda a informação introduzida pelo utilizador e procede à sua validação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            #region Receber Dados
            var morada = new Morada(textBoxRua.Text, new CodigoPostal(maskedTextBoxCodigoPostal.Text), textBoxLocalidade.Text);

            var numDeWcs = ParseNumberOrFail(comboBoxNumDeWC.Text, "Valor de \"Número de Wcs\" inválido");

            // Metros Quadrados
            var metrosQuadrados = ParseNumberOrFail(textBoxMetrosQuadrados.Text, "Valor de \"Metros Quadrados\" inválido");

            // Ano de Construção
            int anoDeConstrucao;
            if (!int.TryParse(numericUpDownAnoDeConstrucao.Text, out anoDeConstrucao))
            {
                MessageBox.Show("Valor de \"Ano de Construção\" inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (anoDeConstrucao > DateTime.Now.Year)
            {
                MessageBox.Show(
                    $"Valor de \"Ano de Construção\" inválido: não pode ser superior ao ano atual {DateTime.Now.Year}",
                    "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Ano de Construção: {anoDeConstrucao}");
            }

            // Nº de Assoalhadas
            var numAssoalhadas = ParseNumberOrFail(comboBoxNumDeAssoalhadas.Text, "Valor de \"Nº de Assoalhadas\" inválido: não é número inteiro");

            // Nº de Quartos
            var numQuartos = ParseNumberOrFail(comboBoxNumDeQuartos.Text, "Valor de \"Nº de Quartos\" inválido: não é número inteiro");
            #endregion

            // Comodidades
            var comodidades = new Comodidades(checkBoxTelevisao.Checked, checkBoxInternet.Checked, checkBoxServicosDeLimpeza.Checked);

            // Descrição da Habitação
            var descricao = textBoxDescricao.Text.Trim();

            // Despesas incluidas?
            var despesasIncluidas = checkBoxDespesasIncluidas.Checked;

            var custoMensal = decimal.Parse(textBoxPreco.Text);

            #region Validar
            // validar
            // e depois
            var habitacao = new Habitacao(descricao, numQuartos, numAssoalhadas, numDeWcs, metrosQuadrados, anoDeConstrucao, morada, custoMensal, despesasIncluidas, comodidades);
            #endregion

            #region Redes Sociais
            if (checkBoxFacebook.Checked) PostFacebook(habitacao);
            if (checkBoxTwitter.Checked) PostTwitter(habitacao);
            #endregion
        }

        private void PostFacebook(IHabitacao habitacao)
        {
            //1. imagens da habitação
            #region Imagem
            var ultimaFoto = _imgFilenames.LastOrDefault();
            if (string.IsNullOrEmpty(ultimaFoto))
            {
                throw new Exception("Por favor, insira uma ou mais imagens da habitação");
            }
            var img = Image.FromFile(ultimaFoto);
            var foto = (byte[]) new ImageConverter().ConvertTo(img, typeof(byte[]));
            var mediaObject = new FacebookMediaObject
            {
                ContentType = "image/jpeg",
                FileName = Path.GetFileName(ultimaFoto),
            }.SetValue(foto);
            #endregion

            //2. descriçao textual para publicar no facebook
            var message = FacebookPost(habitacao);

            //3. publicar no facebook
            try
            {
                var resp = Facebook.PublishPost(message, mediaObject);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Facebook error: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FacebookPost(IHabitacao habitacao)
        {
            var despesas = habitacao.IncluiDespesas ? "(Inclui despesas)" : "(Não inclui despesas)";

            #region Comodidades

            var televisao = habitacao.Comodidades.Televisao ? "Televisão" : string.Empty;
            var internet = habitacao.Comodidades.Internet ? "Internet" : string.Empty;
            var limpeza = habitacao.Comodidades.ServicoDeLimpeza ? "Serviço de Limpeza" : string.Empty;
            var com = string.Join(", ", televisao, internet, limpeza);
            //var comodidades = new StringBuilder(com) {[com.LastIndexOf(",", StringComparison.Ordinal)] = 'e'}; TODO

            #endregion

            var message =
                $@"{habitacao.Descricao}

Morada: {habitacao.Morada.Arruamento}, {habitacao.Morada.CodigoPostal}, {habitacao
                    .Morada.Localidade}
Metros quadrados: {habitacao.MetrosQuadrados} m2
Ano de construção: {habitacao
                        .AnoDeConstrucao}
Custo mensal de um quarto: {habitacao.CustoMensal}€ {despesas}
Quartos: {habitacao
                            .NumeroDeQuartos}
Assoalhadas: {habitacao.NumeroDeAssoalhadas}
Casas de banho:  {habitacao
                                .NumeroDeWcs}
{com}
";
            return message;
        }

        private void PostTwitter(Habitacao habitacao)
        {
            #region Mensagem

            var custosIncluidos = habitacao.IncluiDespesas ? " (c/ custos inc.)" : "";
            var descricao = char.IsPunctuation(habitacao.Descricao.Last())
                ? habitacao.Descricao
                : $"{habitacao.Descricao}.";
            var message = $"{descricao} {habitacao.TQuartos}, {habitacao.MetrosQuadrados} m2, {habitacao.CustoMensal} €/mês por quarto{custosIncluidos}, {habitacao.Morada.Localidade}";
            // Um tweet não pode ter mais do que a 140 caracteres
            if (message.Length > 140) return;
            #endregion

            #region Imagens
            var lastPhoto = _imgFilenames.LastOrDefault();
            if (string.IsNullOrEmpty(lastPhoto))
            {
                throw new Exception("Por favor, insira uma ou mais imagens da habitação");
            }
            #endregion

            try
            {
                var tweetId = Twitter.PostTweet(message, lastPhoto);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Twitter error: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TODO: move this function from here
        private static int ParseNumberOrFail(string s, string errorMsg)
        {
            int result;
            if (!int.TryParse(s, out result))
            {
                MessageBox.Show(errorMsg, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string cod = maskedTextBoxCodigoPostal.Text;

            var f = new GoogleMaps.GoogleMaps();
            var local = f.GetCoordinates($"{rua}, {cod}, {loc}");

            var markersOverlay = new GMapOverlay("markers");

            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(local.lat, local.lng), GMarkerGoogleType.green);
            marker.ToolTipText = string.Format("Sua Habitação");
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markersOverlay.Markers.Add(marker);
            gMapControl.Overlays.Add(markersOverlay);
        }

        private void gMapControl_DoubleClick(object sender, EventArgs e)
        {
            gMapControl.Zoom += 1;
        }
    }
}
