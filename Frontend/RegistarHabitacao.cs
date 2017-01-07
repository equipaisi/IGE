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
using GoogleMaps;
using Place = GooglePlaces.Place;

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

            try
            {
                if (checkBoxFacebook.Checked) PostFacebook(habitacao);
                if (checkBoxTwitter.Checked) PostTwitter(habitacao);
            }
            catch (NoPhotosException)
            {
                return;
            }
            catch (TweetTooLongException)
            {
                return;
            }

            MessageBox.Show("Habitação registada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            #endregion
        }

        private void PostFacebook(IHabitacao habitacao)
        {
            try
            {
                // texto do post a publicar
                string texto = Facebook.CreatePost(habitacao);
                // publicar post/story
                Facebook.PublishPost(texto, _imgsFilepath);
            }
            catch (NoPhotosException)
            {
                MessageBox.Show("Por favor, insira uma ou mais imagens da habitação.", "Publicação no Facebook", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Facebook error: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PostTwitter(IHabitacao habitacao)
        {
            try
            {
                // texto do tweet a publicar
                string texto = Twitter.CreateTweet(habitacao);
                // fotos a publicar
                UniqueList<string> fotos = _imgsFilepath;
                // publicar tweet
                Twitter.PostTweet(texto, fotos);
            }
            catch (NoPhotosException)
            {
                MessageBox.Show("Por favor, insira uma ou mais imagens da habitação.", "Publicação no Twitter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (TweetTooLongException)
            {
                MessageBox.Show("O texto da publicação no Twitter excede os 140 caracteres.", "Publicação no Twitter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
            DialogResult result = openFileDialog1.ShowDialog(); // Mostra o Dialog.
            if (result == DialogResult.OK) // Test result.
            {
                foreach (string filename in openFileDialog1.FileNames)
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
            int indexDisplayedImage = _imgsFilepath.IndexOf(_displayedImage);
            if (indexDisplayedImage > 0) // se houver mais de uma foto
            {
                string previousPhoto = _imgsFilepath[indexDisplayedImage - 1];
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
            int indexDisplayedImage = _imgsFilepath.IndexOf(_displayedImage);
            if (indexDisplayedImage < _imgsFilepath.Count - 1)
            {
                string nextPhoto = _imgsFilepath[indexDisplayedImage + 1];
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
            PictureBox transfo = (PictureBox)e.Data.GetData(typeof(PictureBox));
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
            Location local =
                new GoogleMaps.GoogleMaps().GetCoordinates(
                    $"{textBoxRua.Text}, {maskedTextBoxCodigoPostal.Text}, {textBoxLocalidade.Text}");
            if (local == null) return;
            List<Place> pontosDeInteresse = new GooglePlaces.GooglePlaces().GetPointsOfInterest(local.lat, local.lng, 250);
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            gMapControl.Overlays.Clear();
            foreach (Place t in pontosDeInteresse)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(t.Latitude.ToString()), Convert.ToDouble(t.Longitude.ToString())), GMarkerGoogleType.green);
                marker.ToolTipText = $"{t.Name} \n {Utils.FormatPontosDeInteresse(t.Types)}";
                markersOverlay.Markers.Add(marker);
                gMapControl.Overlays.Add(markersOverlay);
            }

            GMarkerGoogle habitacaoMarker = new GMarkerGoogle(new PointLatLng(local.lat, local.lng), GMarkerGoogleType.red);
            habitacaoMarker.ToolTipText = "Habitação";
            markersOverlay.Markers.Add(habitacaoMarker);

            gMapControl.ZoomAndCenterMarkers(markersOverlay.Id);
        }

        private void gMapControl_DoubleClick(object sender, EventArgs e)
        {
            gMapControl.Zoom += 1;
        }
    }
}
