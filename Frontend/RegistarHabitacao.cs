﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleMaps.DistanceMatrix;
using GoogleMaps.Geocoding;
using Middleware;

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

            #if DEBUG
            textBoxRua.Text = "R. Duques de Bragança 185";
            maskedTextBoxCodigoPostal.Text = "4750-272";
            textBoxLocalidade.Text = "Barcelos";
            textBoxMetrosQuadrados.Text = "56";
            comboBoxNumDeAssoalhadas.Text = "5";
            comboBoxNumDeQuartos.Text = "3";
            comboBoxNumDeWC.Text = "1";
            textBoxPreco.Text = "179";
            checkBoxTelevisao.Checked = true;
            checkBoxInternet.Checked = true;
            textBoxDescricao.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            #endif
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

            try
            {
                if (checkBoxFacebook.Checked) PostFacebook(habitacao);
                if (checkBoxTwitter.Checked) PostTwitter(habitacao);
            }
            catch (Exception)
            {
                // se for levantada alguma excepção, ignorar
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
                var texto = Facebook.CreatePost(habitacao);
                // publicar post/story
                Facebook.PublishPost(texto, _imgsFilepath);
            }
            catch (NoPhotosException)
            {
                MessageBox.Show("Por favor, insira uma ou mais imagens da habitação.", "Publicação no Facebook",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (ExcessiveImageFilesizeException)
            {
                MessageBox.Show("Uma imagem excede o tamanho permitido pelo Facebook.", "Publicação no Facebook",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var texto = Twitter.CreateTweet(habitacao);
                // fotos a publicar
                var fotos = _imgsFilepath;
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
            catch (ExcessiveImageFilesizeException)
            {
                MessageBox.Show("Uma imagem excede o tamanho permitido pelo Twitter.", "Publicação no Twitter", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region pictureBoxImagem

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
            //MessageBox.Show(_imgsFilepath.Count.ToString());
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

        /// <summary>
        /// Atualiza a foto a ser apresentada no <see cref="pictureBoxImagem"/>.
        /// </summary>
        /// <param name="filepath">Caminho completo da foto a ser apresentada</param>
        private void AtualizarFoto(string filepath)
        {
            pictureBoxImagem.Image = filepath != null ? Image.FromFile(filepath) : null;
            _displayedImage = filepath;
        }

        #endregion

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
            new PesquisarProprietario {MdiParent = ActiveForm}.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NovoProprietario {MdiParent = ActiveForm}.Show();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            var googleMaps = new GoogleMaps.GoogleMaps();

            var habitacao =
                googleMaps.GetCoordinates(
                    $"{textBoxRua.Text}, {maskedTextBoxCodigoPostal.Text}, {textBoxLocalidade.Text}");
            if (habitacao == null) return;

            var pontosDeInteresse = new GooglePlaces.GooglePlaces().GetPointsOfInterest(habitacao.lat, habitacao.lng, 250);

            var markersOverlay = new GMapOverlay("markers");
            gMapControl.Overlays.Clear();

            foreach (var t in pontosDeInteresse)
            {
                var pontoDeInteresse = new Location {lat = t.Latitude, lng = t.Longitude};
                var distance = googleMaps.DistanceBetween(habitacao, pontoDeInteresse, TravelMode.Walking);

                var marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(t.Latitude.ToString()), Convert.ToDouble(t.Longitude.ToString())), GMarkerGoogleType.green);
                marker.ToolTipText = $"{t.Name}\n{Utils.FormatPontosDeInteresse(t.Types)}\nDistância (a pé): {distance}m";
                markersOverlay.Markers.Add(marker);
                gMapControl.Overlays.Add(markersOverlay);
            }

            var habitacaoMarker = new GMarkerGoogle(new PointLatLng(habitacao.lat, habitacao.lng), GMarkerGoogleType.red);
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
