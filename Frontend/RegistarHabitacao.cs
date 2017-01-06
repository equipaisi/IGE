using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Middleware;
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
        private GMarkerGoogle marker;

        public RegistarHabitacao()
        {
            InitializeComponent();
        }

        public void RegistarHabitacao_Load(object sender, EventArgs e)
        {
            maskedTextBoxCodigoPostal.MaskInputRejected += maskedTextBoxCodigoPostal_MaskInputRejected;
            AllowDrop = true;

            textBoxRua.Text = "R. Duques de Bragança 185";
            maskedTextBoxCodigoPostal.Text = "4750-272";
            textBoxLocalidade.Text = "Barcelos";
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

            Morada morada = new Morada(textBoxRua.Text, new CodigoPostal(maskedTextBoxCodigoPostal.Text),
                textBoxLocalidade.Text);

            int numDeWcs = ParseNumberOrFail(comboBoxNumDeWC.Text, "Valor de \"Número de Wcs\" inválido");

            // Metros Quadrados
            int metrosQuadrados = ParseNumberOrFail(textBoxMetrosQuadrados.Text,
                "Valor de \"Metros Quadrados\" inválido");

            // Ano de Construção
            int anoDeConstrucao;
            if (!int.TryParse(numericUpDownAnoDeConstrucao.Text, out anoDeConstrucao))
            {
                MessageBox.Show("Valor de \"Ano de Construção\" inválido", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
            int numAssoalhadas = ParseNumberOrFail(comboBoxNumDeAssoalhadas.Text,
                "Valor de \"Nº de Assoalhadas\" inválido: não é número inteiro");

            // Nº de Quartos
            int numQuartos = ParseNumberOrFail(comboBoxNumDeQuartos.Text,
                "Valor de \"Nº de Quartos\" inválido: não é número inteiro");

            #endregion

            // Comodidades
            Comodidades comodidades = new Comodidades(checkBoxTelevisao.Checked, checkBoxInternet.Checked,
                checkBoxServicosDeLimpeza.Checked);

            // Descrição da Habitação
            string descricao = textBoxDescricao.Text.Trim();

            // Despesas incluidas?
            bool despesasIncluidas = checkBoxDespesasIncluidas.Checked;

            decimal custoMensal = decimal.Parse(textBoxPreco.Text);

            #region Validar

            // validar
            // e depois
            Habitacao habitacao = new Habitacao(descricao, numQuartos, numAssoalhadas, numDeWcs, metrosQuadrados,
                anoDeConstrucao, morada, custoMensal, despesasIncluidas, comodidades);

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

            string ultimaFoto = _imgFilenames.LastOrDefault();
            if (string.IsNullOrEmpty(ultimaFoto))
            {
                throw new Exception("Por favor, insira uma ou mais imagens da habitação");
            }
            Image img = Image.FromFile(ultimaFoto);
            byte[] foto = (byte[]) new ImageConverter().ConvertTo(img, typeof(byte[]));
            FacebookMediaObject mediaObject = new FacebookMediaObject
            {
                ContentType = "image/jpeg",
                FileName = Path.GetFileName(ultimaFoto),
            }.SetValue(foto);

            #endregion

            //2. descriçao textual para publicar no facebook
            string message = FacebookPost(habitacao);

            //3. publicar no facebook
            try
            {
                object resp = Facebook.PublishPost(message, mediaObject);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Facebook error: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FacebookPost(IHabitacao habitacao)
        {
            string despesas = habitacao.IncluiDespesas ? "(Inclui despesas)" : "(Não inclui despesas)";

            #region Comodidades

            string televisao = habitacao.Comodidades.Televisao ? "Televisão" : string.Empty;
            string internet = habitacao.Comodidades.Internet ? "Internet" : string.Empty;
            string limpeza = habitacao.Comodidades.ServicoDeLimpeza ? "Serviço de Limpeza" : string.Empty;
            string com = string.Join(", ", televisao, internet, limpeza);
            //var comodidades = new StringBuilder(com) {[com.LastIndexOf(",", StringComparison.Ordinal)] = 'e'}; TODO

            #endregion

            string message =
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

            string custosIncluidos = habitacao.IncluiDespesas ? " (c/ custos inc.)" : "";
            string message =
                $"{habitacao.TQuartos}, {habitacao.MetrosQuadrados} m2, {habitacao.CustoMensal} €/mês por quarto{custosIncluidos}, contruído em {habitacao.AnoDeConstrucao}, {habitacao.Morada.Localidade}";
            // Um tweet não pode ter mais do que a 140 caracteres
            if (message.Length > 140) return;

            #endregion

            #region Imagens

            string lastPhoto = _imgFilenames.LastOrDefault();
            if (string.IsNullOrEmpty(lastPhoto))
            {
                throw new Exception("Por favor, insira uma ou mais imagens da habitação");
            }

            #endregion

            try
            {
                long tweetId = Twitter.PostTweet(message, lastPhoto);
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
            openFileDialog1.Filter = @"JPG|*.jpg;*.jpeg|PNG|*.png";
                // TODO: introduzir esta informação (e o tamanho, resolução num requisito funcional
            openFileDialog1.Multiselect = true; // Aceitar múltiplas fotos
            DialogResult result = openFileDialog1.ShowDialog(); // Mostra o Dialog.
            if (result == DialogResult.OK) // Test result.
            {
                foreach (string filename in openFileDialog1.FileNames)
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
            string ultimaFoto = _imgFilenames.LastOrDefault();

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
                string img = _imgFilenames[index];
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
            PictureBox transfo = (PictureBox) e.Data.GetData(typeof(PictureBox));
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

            Location habitacao = new GoogleMaps.GoogleMaps().GetCoordinates(
                                 $"{textBoxRua.Text}, {maskedTextBoxCodigoPostal.Text}, {textBoxLocalidade.Text}");
            PointLatLng position = new PointLatLng(habitacao.lat, habitacao.lng);
            List<GooglePlaces.Place> pontosDeInteresse = new GooglePlaces.GooglePlaces().GetPointsOfInterest(habitacao.lat, habitacao.lng, 250);
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            //limpar maps 
            gMapControl.Overlays.Clear();

            for (int i = 0; i < pontosDeInteresse.Count; i++)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(pontosDeInteresse[i].Latitude.ToString()), Convert.ToDouble(pontosDeInteresse[i].Longitude.ToString())), GMarkerGoogleType.green);
                marker.ToolTipText = string.Format("{0} \n {1}", pontosDeInteresse[i].Name, FormatPontosDeInteresse(pontosDeInteresse[i].Types));
                markersOverlay.Markers.Add(marker);
                gMapControl.Overlays.Add(markersOverlay);
            }

            marker = new GMarkerGoogle(position, GMarkerGoogleType.red);
            marker.ToolTipText = string.Format("Habitação");
            markersOverlay.Markers.Add(marker);

            gMapControl.ZoomAndCenterMarkers(markersOverlay.Id);
        }

        private string FormatPontosDeInteresse(List<string> types) {
            types.Remove("point_of_interest");
            return $"Categoria: {types[0]}";
        }

        private void gMapControl_DoubleClick(object sender, EventArgs e)
        {
            gMapControl.Zoom += 1;
        }
    }
}
