using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PesquisarHabitacao : Form
    {
        public PesquisarHabitacao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  
            if ((string)comboBox1.SelectedItem == "Castelo Branco")
            {
                comboBox2.Items.Add("Belmonte");
                comboBox2.Items.Add("Castelo Branco");
                comboBox2.Items.Add("Covilhã");
                comboBox2.Items.Add("Fundão");
                comboBox2.Items.Add("Idanha a Nova");
                comboBox2.Items.Add("Oleiros");
                comboBox2.Items.Add("Penamacor");
                comboBox2.Items.Add("Proença a Nova");
                comboBox2.Items.Add("Sertã");
                comboBox2.Items.Add("Vila de Rei");
                comboBox2.Items.Add("Vila Velha de Ródão");
            } else if ((string)comboBox1.SelectedItem == "Aveiro")
            {
                comboBox2.Items.Add("Agueda");
                comboBox2.Items.Add("Albergaria a Velha");
                comboBox2.Items.Add("Anadia");
                comboBox2.Items.Add("Arouca");
                comboBox2.Items.Add("Aveiro");
                comboBox2.Items.Add("Castelo de Paiva");
                comboBox2.Items.Add("Espinho");
                comboBox2.Items.Add("Estarreja ");
                comboBox2.Items.Add("Ilhavo");
                comboBox2.Items.Add("Mealhada");
                comboBox2.Items.Add("Murtosa");
                
                    comboBox2.Items.Add("Oliveira de Azemeis");
                    comboBox2.Items.Add("Oliveira do Bairro");
                    comboBox2.Items.Add("Ovar");
                    comboBox2.Items.Add("Santa Maria da Feira");
                    comboBox2.Items.Add("São João da Madeira");
                    comboBox2.Items.Add("Sever do Vouga");
                    comboBox2.Items.Add("Vagos");
                    comboBox2.Items.Add("Vale de Cambra");
                
            }

            else if ((string)comboBox1.SelectedItem == "Beja")
            {
                comboBox2.Items.Add("Aljustrel");
                comboBox2.Items.Add("Almodovar");
                comboBox2.Items.Add("Alvito");
                comboBox2.Items.Add("Barrancos");
                comboBox2.Items.Add("Beja");
                comboBox2.Items.Add("Castro Verde");
                comboBox2.Items.Add("Cuba");
                comboBox2.Items.Add("Ferreira do Alentejo");
                comboBox2.Items.Add("Mertola");
                comboBox2.Items.Add("Moura");
                comboBox2.Items.Add("Odemira");

                comboBox2.Items.Add("Ourique");
                comboBox2.Items.Add("Serpa");
                comboBox2.Items.Add("Vidigueira");
            }

            else if ((string)comboBox1.SelectedItem == "Braga")
            {
                comboBox2.Items.Add("Amares");
                comboBox2.Items.Add("Barcelos");
                comboBox2.Items.Add("Braga");
                comboBox2.Items.Add("Cabeceuras de Basto");
                comboBox2.Items.Add("Celorico de Basto");
                comboBox2.Items.Add("Esposende");
                comboBox2.Items.Add("Fafe");
                comboBox2.Items.Add("Guimarães");
                comboBox2.Items.Add("Póvoa de Lanhoso");
                comboBox2.Items.Add("Terras de Bouro");
                comboBox2.Items.Add("Vieira do Minho");

                comboBox2.Items.Add("Vila Nova de Famalicão");
                comboBox2.Items.Add("Vila Verde");
                comboBox2.Items.Add("Vizela");
            }

            else if ((string)comboBox1.SelectedItem == "Bragança")
            {
                comboBox2.Items.Add("Alfândega da Fé");
                comboBox2.Items.Add("Bragança");
                comboBox2.Items.Add("Carrazeda de Ansiães");
                comboBox2.Items.Add("Freixo de Espada à Cinta");
                comboBox2.Items.Add("Macedo de Cavaleiros");
                comboBox2.Items.Add("Miranda do Douro");
                comboBox2.Items.Add("Mirandela");
                comboBox2.Items.Add("Mogadouro");
                comboBox2.Items.Add("Torre de Moncorvo");
                comboBox2.Items.Add("Vila Flor");
                comboBox2.Items.Add("Vimioso");
               
            }

            else if ((string)comboBox1.SelectedItem == "Coimbra")
            {
                comboBox2.Items.Add("Arganil");
                comboBox2.Items.Add("Cantanhede");
                comboBox2.Items.Add("Coimbra");
                comboBox2.Items.Add("Condeixa-a-Nova");
                comboBox2.Items.Add("Figueira da Foz");
                comboBox2.Items.Add("Góis");
                comboBox2.Items.Add("Lousã");
                comboBox2.Items.Add("Mira");
                comboBox2.Items.Add("Miranda do Corvo");
                comboBox2.Items.Add("Montemor-o-Velho");
                comboBox2.Items.Add("Oliveira do Hospital");
                comboBox2.Items.Add("Pampilhosa da Serra");
                comboBox2.Items.Add("Penacova");
                comboBox2.Items.Add("Penela");
                comboBox2.Items.Add("Soure");
                comboBox2.Items.Add("Tábua");
                comboBox2.Items.Add("Vila Nova de Poiares");

            }

            else if ((string)comboBox1.SelectedItem == "Évora")
            {
                comboBox2.Items.Add("Alandroal");
                comboBox2.Items.Add("Arraiolos");
                comboBox2.Items.Add("Borba");
                comboBox2.Items.Add("Estremoz");
                comboBox2.Items.Add("Évora");
                comboBox2.Items.Add("Montemor-o-Novo");
                comboBox2.Items.Add("Mora");
                comboBox2.Items.Add("Mourão");
                comboBox2.Items.Add("Olivença");
                comboBox2.Items.Add("Portel");
                comboBox2.Items.Add("Redondo");
                comboBox2.Items.Add("Reguengos de Monsaraz");
                comboBox2.Items.Add("Vendas Novas");
                comboBox2.Items.Add("Viana do Alentejo");
                comboBox2.Items.Add("Vila Viçosa");
                

            }

            else if ((string)comboBox1.SelectedItem == "Faro")
            {
                comboBox2.Items.Add("Albufeira");
                comboBox2.Items.Add("Alcoutim");
                comboBox2.Items.Add("Aljezur");
                comboBox2.Items.Add("Castro Marim");
                comboBox2.Items.Add("Faro");
                comboBox2.Items.Add("Lagoa");
                comboBox2.Items.Add("Lagos");
                comboBox2.Items.Add("Loulé");
                comboBox2.Items.Add("Monchique");
                comboBox2.Items.Add("Olhão");
                comboBox2.Items.Add("Portimão");
                comboBox2.Items.Add("São Brás de Alportel");
                comboBox2.Items.Add("Silves");
                comboBox2.Items.Add("Tavira");
                comboBox2.Items.Add("Vila do Bispo");
                comboBox2.Items.Add("Vila Real de Santo António");


            }

            else if ((string)comboBox1.SelectedItem == "Guarda")
            {
                comboBox2.Items.Add("Aguiar da Beira");
                comboBox2.Items.Add("Almeida");
                comboBox2.Items.Add("Celorico da Beira");
                comboBox2.Items.Add("Figueira de Castelo Rodrigo");
                comboBox2.Items.Add("Fornos de Algodres");
                comboBox2.Items.Add("Gouveia");
                comboBox2.Items.Add("Guarda");
                comboBox2.Items.Add("Manteigas");
                comboBox2.Items.Add("Mêda");
                comboBox2.Items.Add("Pinhel");
                comboBox2.Items.Add("Sabugal");
                comboBox2.Items.Add("Seia");
                comboBox2.Items.Add("Trancoso");
                comboBox2.Items.Add("Vila Nova de Foz Côa");
             


            }

            else if ((string)comboBox1.SelectedItem == "Leiria")
            {
                comboBox2.Items.Add("Alcobaça");
                comboBox2.Items.Add("Alvaiázere");
                comboBox2.Items.Add("Ansião");
                comboBox2.Items.Add("Batalha");
                comboBox2.Items.Add("Bombarral");
                comboBox2.Items.Add("Caldas da Rainha");
                comboBox2.Items.Add("Castanheira de Pera");
                comboBox2.Items.Add("Figueiró dos Vinhos");
                comboBox2.Items.Add("Leiria");
                comboBox2.Items.Add("Marinha Grande");
                comboBox2.Items.Add("Nazaré");
                comboBox2.Items.Add("Óbidos");
                comboBox2.Items.Add("Pedrógão Grande");
                comboBox2.Items.Add("Peniche");
                comboBox2.Items.Add("Pombal");
                comboBox2.Items.Add("Porto de Mós");
            }

            else if ((string)comboBox1.SelectedItem == "Lisboa")
            {
                comboBox2.Items.Add("Alenquer");
                comboBox2.Items.Add("Amadora");
                comboBox2.Items.Add("Arruda dos Vinhos");
                comboBox2.Items.Add("Azambuja");
                comboBox2.Items.Add("Cadaval");
                comboBox2.Items.Add("Cascais");
                comboBox2.Items.Add("Lisboa");
                comboBox2.Items.Add("Loures");
                comboBox2.Items.Add("Lourinhã");
                comboBox2.Items.Add("Mafra");
                comboBox2.Items.Add("Odivelas");
                comboBox2.Items.Add("Oeiras");
                comboBox2.Items.Add("Sintra");
                comboBox2.Items.Add("Sobral de Monte Agraço");
                comboBox2.Items.Add("Torres Vedras");
                comboBox2.Items.Add("Vila Franca de Xira");
            }

            else if ((string)comboBox1.SelectedItem == "Portalegre")
            {
                comboBox2.Items.Add("Alter do Chão");
                comboBox2.Items.Add("Arronches");
                comboBox2.Items.Add("Avis");
                comboBox2.Items.Add("Campo Maior");
                comboBox2.Items.Add("Castelo de Vide");
                comboBox2.Items.Add("Crato");
                comboBox2.Items.Add("Elvas");
                comboBox2.Items.Add("Fronteira");
                comboBox2.Items.Add("Gavião");
                comboBox2.Items.Add("Marvão");
                comboBox2.Items.Add("Monforte");
                comboBox2.Items.Add("Nisa");
                comboBox2.Items.Add("Ponte de Sor");
                comboBox2.Items.Add("Portalegre");
                comboBox2.Items.Add("Sousel");
              
            }

            else if ((string)comboBox1.SelectedItem == "Porto")
            {
                comboBox2.Items.Add("Amarante");
                comboBox2.Items.Add("Baião");
                comboBox2.Items.Add("Felgueiras");
                comboBox2.Items.Add("Gondomar");
                comboBox2.Items.Add("Lousada");
                comboBox2.Items.Add("Maia");
                comboBox2.Items.Add("Marco de Canaveses");
                comboBox2.Items.Add("Matosinhos");
                comboBox2.Items.Add("Paços de Ferreira");
                comboBox2.Items.Add("Paredes");
                comboBox2.Items.Add("Penafiel");
                comboBox2.Items.Add("Porto");
                comboBox2.Items.Add("Póvoa de Varzim");
                comboBox2.Items.Add("Santo Tirso");
                comboBox2.Items.Add("Trofa");
                comboBox2.Items.Add("Valongo");
                comboBox2.Items.Add("Vila do Conde");
                comboBox2.Items.Add("Vila Nova de Gaia");

            }

            else if ((string)comboBox1.SelectedItem == "Santarém")
            {
                comboBox2.Items.Add("Abrantes");
                comboBox2.Items.Add("Alcanena");
                comboBox2.Items.Add("Almeirim");
                comboBox2.Items.Add("Alpiarça");
                comboBox2.Items.Add("Benavente");
                comboBox2.Items.Add("Cartaxo");
                comboBox2.Items.Add("Chamusca");
                comboBox2.Items.Add("Constância");
                comboBox2.Items.Add("Coruche");
                comboBox2.Items.Add("Entroncamento");
                comboBox2.Items.Add("Ferreira do Zêzere");
                comboBox2.Items.Add("Golegã");
                comboBox2.Items.Add("Mação");
                comboBox2.Items.Add("Ourém");
                comboBox2.Items.Add("Rio Maior");
                comboBox2.Items.Add("Salvaterra de Magos");
                comboBox2.Items.Add("Santarém");
                comboBox2.Items.Add("Sardoal");
                comboBox2.Items.Add("Tomar");
                comboBox2.Items.Add("Torres Novas");
                comboBox2.Items.Add("Vila Nova da Barquinha");

            }

            else if ((string)comboBox1.SelectedItem == "Setúbal")
            {
                comboBox2.Items.Add("Alcácer do Sal");
                comboBox2.Items.Add("Alcochete");
                comboBox2.Items.Add("Almada");
                comboBox2.Items.Add("Barreiro");
                comboBox2.Items.Add("Grândola");
                comboBox2.Items.Add("Moita");
                comboBox2.Items.Add("Montijo");
                comboBox2.Items.Add("Palmela");
                comboBox2.Items.Add("Santiago do Cacém");
                comboBox2.Items.Add("Seixal");
                comboBox2.Items.Add("Sesimbra");
                comboBox2.Items.Add("Setúbal");
                comboBox2.Items.Add("Sines");
               

            }

            else if ((string)comboBox1.SelectedItem == "Viana do Castelo")
            {
                comboBox2.Items.Add("Arcos de Valdevez");
                comboBox2.Items.Add("Caminha");
                comboBox2.Items.Add("Melgaço");
                comboBox2.Items.Add("Monção");
                comboBox2.Items.Add("Paredes de Coura");
                comboBox2.Items.Add("Ponte da Barca");
                comboBox2.Items.Add("Ponte de Lima");
                comboBox2.Items.Add("Valença");
                comboBox2.Items.Add("Viana do Castelo");
                comboBox2.Items.Add("Vila Nova de Cerveira");
              


            }

            else if ((string)comboBox1.SelectedItem == "Vila Real")
            {
                comboBox2.Items.Add("Alijó");
                comboBox2.Items.Add("Boticas");
                comboBox2.Items.Add("Chaves");
                comboBox2.Items.Add("Mesão Frio");
                comboBox2.Items.Add("Mondim de Basto");
                comboBox2.Items.Add("Montalegre");
                comboBox2.Items.Add("Murça");
                comboBox2.Items.Add("Peso da Régua");
                comboBox2.Items.Add("Ribeira de Pena");
                comboBox2.Items.Add("Sabrosa");
                comboBox2.Items.Add("Santa Marta de Penaguião");
                comboBox2.Items.Add("Valpaços");
                comboBox2.Items.Add("Vila Pouca de Aguiar");
                comboBox2.Items.Add("Vila Real");

            }

            else if ((string)comboBox1.SelectedItem == "Vila Real")
            {
                comboBox2.Items.Add("Armamar");
                comboBox2.Items.Add("Carregal do Sal");
                comboBox2.Items.Add("Castro Daire");
                comboBox2.Items.Add("Cinfães");
                comboBox2.Items.Add("Lamego");
                comboBox2.Items.Add("Mangualde");
                comboBox2.Items.Add("Moimenta da Beira");
                comboBox2.Items.Add("Mortágua");
                comboBox2.Items.Add("Nelas");
                comboBox2.Items.Add("Oliveira de Frades");
                comboBox2.Items.Add("Penalva do Castelo");
                comboBox2.Items.Add("Penedono");
                comboBox2.Items.Add("Resende");
                comboBox2.Items.Add("Santa Comba Dão");
                comboBox2.Items.Add("São João da Pesqueira");
                comboBox2.Items.Add("São Pedro do Sul");
                comboBox2.Items.Add("Sátão");
                comboBox2.Items.Add("Sernancelhe");
                comboBox2.Items.Add("Tabuaço");
                comboBox2.Items.Add("Tarouca");
                comboBox2.Items.Add("Tondela");
                comboBox2.Items.Add("Vila Nova de Paiva");
                comboBox2.Items.Add("Viseu");
                comboBox2.Items.Add("Vouzela");

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox2.SelectedItem == "Barcelos")
            {
               
                    comboBox3.Items.Add("IPCA - Instituto Politécnico Cavado Ave");
                    
                
            }

            label8.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 80;
            trackBar1.Maximum = 400;
            label8.Text = trackBar1.Value.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (comboBox1.Text == "Braga" || comboBox2.Text == ("Barcelos") || comboBox3.Text == ("IPCA - Instituto Politécnico Cavado Ave")){ pictureBox1.Show();
                pictureBox2.Show(); richTextBox1.Show(); richTextBox2.Show();  linkLabel1.Show();
                linkLabel2.Show();
               
            }
                
                    }
        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Habitação alun = new Habitação();
            alun.MdiParent = IGE.ActiveForm;
            alun.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
