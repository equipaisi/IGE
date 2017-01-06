using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Middleware;
using Facebook;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace Frontend
{
    public partial class RegistarHabitacao : Form
    {
        private readonly UniqueList<string> _imgsFilepath;
        private string _displayedImage;
        private readonly ErrorProvider _errorProvider1;

        public RegistarHabitacao()
        {
            InitializeComponent();
            _displayedImage = null;
            _imgsFilepath = new UniqueList<string>();
            _errorProvider1 = new ErrorProvider();
        }

        public void RegistarHabitacao_Load(object sender, EventArgs e)
        {
            maskedTextBoxCodigoPostal.MaskInputRejected += maskedTextBoxCodigoPostal_MaskInputRejected;
            AllowDrop = true;

            // TODO: eliminar
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

            var morada = new Morada(textBoxRua.Text, new CodigoPostal(maskedTextBoxCodigoPostal.Text),
                textBoxLocalidade.Text);

            var numDeWcs = ParseNumberOrFail(comboBoxNumDeWC.Text, "Valor de \"Número de Wcs\" inválido");

            // Metros Quadrados
            var metrosQuadrados = ParseNumberOrFail(textBoxMetrosQuadrados.Text,
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
            var numAssoalhadas = ParseNumberOrFail(comboBoxNumDeAssoalhadas.Text,
                "Valor de \"Nº de Assoalhadas\" inválido: não é número inteiro");

            // Nº de Quartos
            var numQuartos = ParseNumberOrFail(comboBoxNumDeQuartos.Text,
                "Valor de \"Nº de Quartos\" inválido: não é número inteiro");

            #endregion

            // Comodidades
            var comodidades = new Comodidades(checkBoxTelevisao.Checked, checkBoxInternet.Checked,
                checkBoxServicosDeLimpeza.Checked);

            // Descrição da Habitação
            var descricao = textBoxDescricao.Text.Trim();

            // Despesas incluidas?
            var despesasIncluidas = checkBoxDespesasIncluidas.Checked;

            var custoMensal = decimal.Parse(textBoxPreco.Text);

            #region Validar

            // validar
            // e depois
            var habitacao = new Habitacao(descricao, numQuartos, numAssoalhadas, numDeWcs, metrosQuadrados,
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

            var ultimaFoto = _imgsFilepath.LastOrDefault();
            if (string.IsNullOrEmpty(ultimaFoto))
            {
                throw new Exception("Por favor, insira uma ou mais imagens da habitação");
            }
            var img = Image.FromFile(ultimaFoto);
            var foto = (byte[])new ImageConverter().ConvertTo(img, typeof(byte[]));
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
            var message =
                $"{habitacao.TQuartos}, {habitacao.MetrosQuadrados} m2, {habitacao.CustoMensal} €/mês por quarto{custosIncluidos}, contruído em {habitacao.AnoDeConstrucao}, {habitacao.Morada.Localidade}";
            // Um tweet não pode ter mais do que a 140 caracteres
            if (message.Length > 140) return;

            #endregion

            try
            {
                var photos = _imgsFilepath.Take(Twitter.MaxAllowedUploadedPhotos);
                var tweetId = Twitter.PostTweet(message, photos);
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
        /// Adiciona uma ou mais fotos.
        /// </summary>
        private void buttonAdicionarFotos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"JPG|*.jpg;*.jpeg|PNG|*.png";
            // TODO: introduzir esta informação (e o tamanho, resolução num requisito funcional
            openFileDialog1.Multiselect = true; // Aceitar múltiplas fotos
            var result = openFileDialog1.ShowDialog(); // Mostra o Dialog.
            if (result == DialogResult.OK) // Test result.
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    _imgsFilepath.Add(filename);
                }
                AtualizarFoto(_imgsFilepath.LastOrDefault());
            }
            MessageBox.Show(_imgsFilepath.Count.ToString());
        }

        /// <summary>
        /// Remove a foto atualmente visível eem pictureBoxImagem. 
        /// </summary>
        private void buttonRemoverFoto_Click(object sender, EventArgs e)
        {
            // se nenhuma imagem estiver a ser exibida
            if (_displayedImage == null) return;
            // se alguma imagem estiver a ser exibida
            _imgsFilepath.Remove(_displayedImage);
            AtualizarFoto(_imgsFilepath.LastOrDefault());
        }

        /// <summary>
        /// Mostra a foto anterior.
        /// </summary>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // se nenhuma imagem estiver a ser exibida
            if (_displayedImage == null) return;
            // se alguma imagem estiver a ser exibida
            var indexDisplayedImage = _imgsFilepath.IndexOf(_displayedImage);
            if (indexDisplayedImage > 0) // se houver mais de uma foto
            {
                var previousPhoto = _imgsFilepath[indexDisplayedImage - 1];
                AtualizarFoto(previousPhoto);
            }
        }

        /// <summary>
        /// Mostra a foto seguinte.
        /// </summary>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // se nenhuma imagem estiver a ser exibida
            if (_displayedImage == null) return;
            // se alguma imagem estiver a ser exibida
            var indexDisplayedImage = _imgsFilepath.IndexOf(_displayedImage);
            if (indexDisplayedImage < _imgsFilepath.Count - 1)
            {
                var nextPhoto = _imgsFilepath[indexDisplayedImage + 1];
                AtualizarFoto(nextPhoto);
            }
        }

        private void AtualizarFoto(string filepath)
        {
            pictureBoxImagem.Image = filepath != null ? Image.FromFile(filepath) : null;
            _displayedImage = filepath;
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

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            var local =
                new GoogleMaps.GoogleMaps().GetCoordinates(
                    $"{textBoxRua.Text}, {maskedTextBoxCodigoPostal.Text}, {textBoxLocalidade.Text}");
            if (local == null) return;
            var pontosDeInteresse = new GooglePlaces.GooglePlaces().GetPointsOfInterest(local.lat, local.lng, 250);
            var markersOverlay = new GMapOverlay("markers");

            gMapControl.Overlays.Clear();
            foreach (var t in pontosDeInteresse)
            {
                var marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(t.Latitude.ToString()), Convert.ToDouble(t.Longitude.ToString())), GMarkerGoogleType.green);
                marker.ToolTipText = $"{t.Name} \n {FormatPontosDeInteresse(t.Types)}";
                markersOverlay.Markers.Add(marker);
                gMapControl.Overlays.Add(markersOverlay);
            }

            var habitacaoMarker = new GMarkerGoogle(new PointLatLng(local.lat, local.lng), GMarkerGoogleType.red);
            habitacaoMarker.ToolTipText = "Habitação";
            markersOverlay.Markers.Add(habitacaoMarker);

            gMapControl.ZoomAndCenterMarkers(markersOverlay.Id);
        }

        private static string FormatPontosDeInteresse(IList<string> types)
        {
            types.Remove("point_of_interest");
            return $"Categoria: {types[0]}";
        }

        private void gMapControl_DoubleClick(object sender, EventArgs e)
        {
            gMapControl.Zoom += 1;
        }
    }
}
