using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PesquisarHabitacao : Form
    {
        Pais Portugal = new Pais("Portugal");

        public PesquisarHabitacao()
        {
            InitializeComponent();
            
            // BRAGA 
            Distrito braga = new Distrito("Braga");
            braga.Concelhos.Add(new Concelho("Amares"));
            braga.Concelhos.Add(new Concelho("Barcelos"));
            braga.Concelhos.Add(new Concelho("Braga"));
            braga.Concelhos.Add(new Concelho("Cabeceuras de Basto"));
            braga.Concelhos.Add(new Concelho("Celorico de Basto"));
            braga.Concelhos.Add(new Concelho("Esposende"));
            braga.Concelhos.Add(new Concelho("Fafe"));
            braga.Concelhos.Add(new Concelho("Guimarães"));
            braga.Concelhos.Add(new Concelho("Póvoa de Lanhoso"));
            braga.Concelhos.Add(new Concelho("Terras de Bouro"));
            braga.Concelhos.Add(new Concelho("Vieira do Minho"));
            braga.Concelhos.Add(new Concelho("Vila Nova de Famalicão"));
            braga.Concelhos.Add(new Concelho("Vila Verde"));
            braga.Concelhos.Add(new Concelho("Vizela"));

            Portugal.Distritos.Add(braga);

            //CASTELO BRANCO 
            Distrito casteloBranco = new Distrito("Castelo Branco");
            casteloBranco.Concelhos.Add(new Concelho("Belmonte"));
            casteloBranco.Concelhos.Add(new Concelho("Castelo Branco"));
            casteloBranco.Concelhos.Add(new Concelho("Covilhã"));
            casteloBranco.Concelhos.Add(new Concelho("Fundão"));
            casteloBranco.Concelhos.Add(new Concelho("Idanha a Nova"));
            casteloBranco.Concelhos.Add(new Concelho("Oleiros"));
            casteloBranco.Concelhos.Add(new Concelho("Penamacor"));
            casteloBranco.Concelhos.Add(new Concelho("Proença a Nova"));
            casteloBranco.Concelhos.Add(new Concelho("Sertã"));
            casteloBranco.Concelhos.Add(new Concelho("Vila de Rei"));
            casteloBranco.Concelhos.Add(new Concelho("Vila Velha de Ródão"));

            Portugal.Distritos.Add(casteloBranco);

            //AVEIRO 
            Distrito aveiro = new Distrito("Aveiro");
            aveiro.Concelhos.Add(new Concelho("Agueda"));
            aveiro.Concelhos.Add(new Concelho("Albergaria a Velha"));
            aveiro.Concelhos.Add(new Concelho("Anadia"));
            aveiro.Concelhos.Add(new Concelho("Arouca"));
            aveiro.Concelhos.Add(new Concelho("Aveiro"));
            aveiro.Concelhos.Add(new Concelho("Castelo de Paiva"));
            aveiro.Concelhos.Add(new Concelho("Espinho"));
            aveiro.Concelhos.Add(new Concelho("Estarreja "));
            aveiro.Concelhos.Add(new Concelho("Ilhavo"));
            aveiro.Concelhos.Add(new Concelho("Mealhada"));
            aveiro.Concelhos.Add(new Concelho("Murtosa"));

            aveiro.Concelhos.Add(new Concelho("Oliveira de Azemeis"));
            aveiro.Concelhos.Add(new Concelho("Oliveira do Bairro"));
            aveiro.Concelhos.Add(new Concelho("Ovar"));
            aveiro.Concelhos.Add(new Concelho("Santa Maria da Feira"));
            aveiro.Concelhos.Add(new Concelho("São João da Madeira"));
            aveiro.Concelhos.Add(new Concelho("Sever do Vouga"));
            aveiro.Concelhos.Add(new Concelho("Vagos"));
            aveiro.Concelhos.Add(new Concelho("Vale de Cambra"));

            Portugal.Distritos.Add(aveiro);

            //BEJA
            Distrito beja = new Distrito("Beja");
            beja.Concelhos.Add(new Concelho("Aljustrel"));
            beja.Concelhos.Add(new Concelho("Almodovar"));
            beja.Concelhos.Add(new Concelho("Alvito"));
            beja.Concelhos.Add(new Concelho("Barrancos"));
            beja.Concelhos.Add(new Concelho("Beja"));
            beja.Concelhos.Add(new Concelho("Castro Verde"));
            beja.Concelhos.Add(new Concelho("Cuba"));
            beja.Concelhos.Add(new Concelho("Ferreira do Alentejo"));
            beja.Concelhos.Add(new Concelho("Mertola"));
            beja.Concelhos.Add(new Concelho("Moura"));
            beja.Concelhos.Add(new Concelho("Odemira"));

            beja.Concelhos.Add(new Concelho("Ourique"));
            beja.Concelhos.Add(new Concelho("Serpa"));
            beja.Concelhos.Add(new Concelho("Vidigueira"));

            Portugal.Distritos.Add(beja);


            //BRAGANÇA
            Distrito braganca = new Distrito("Bragança");
           braganca.Concelhos.Add(new Concelho("Alfândega da Fé"));
           braganca.Concelhos.Add(new Concelho("Bragança"));
           braganca.Concelhos.Add(new Concelho("Carrazeda de Ansiães"));
           braganca.Concelhos.Add(new Concelho("Freixo de Espada à Cinta"));
           braganca.Concelhos.Add(new Concelho("Macedo de Cavaleiros"));
           braganca.Concelhos.Add(new Concelho("Miranda do Douro"));
           braganca.Concelhos.Add(new Concelho("Mirandela"));
           braganca.Concelhos.Add(new Concelho("Mogadouro"));
           braganca.Concelhos.Add(new Concelho("Torre de Moncorvo"));
           braganca.Concelhos.Add(new Concelho("Vila Flor"));
           braganca.Concelhos.Add(new Concelho("Vimioso"));

            Portugal.Distritos.Add(braganca);


            //COIMBRA
            Distrito coimbra = new Distrito("Coimbra");
            coimbra.Concelhos.Add(new Concelho("Arganil"));
            coimbra.Concelhos.Add(new Concelho("Cantanhede"));
            coimbra.Concelhos.Add(new Concelho("Coimbra"));
            coimbra.Concelhos.Add(new Concelho("Condeixa-a-Nova"));
            coimbra.Concelhos.Add(new Concelho("Figueira da Foz"));
            coimbra.Concelhos.Add(new Concelho("Góis"));
            coimbra.Concelhos.Add(new Concelho("Lousã"));
            coimbra.Concelhos.Add(new Concelho("Mira"));
            coimbra.Concelhos.Add(new Concelho("Miranda do Corvo"));
            coimbra.Concelhos.Add(new Concelho("Montemor-o-Velho"));
            coimbra.Concelhos.Add(new Concelho("Oliveira do Hospital"));
            coimbra.Concelhos.Add(new Concelho("Pampilhosa da Serra"));
            coimbra.Concelhos.Add(new Concelho("Penacova"));
            coimbra.Concelhos.Add(new Concelho("Penela"));
            coimbra.Concelhos.Add(new Concelho("Soure"));
            coimbra.Concelhos.Add(new Concelho("Tábua"));
            coimbra.Concelhos.Add(new Concelho("Vila Nova de Poiares"));

            Portugal.Distritos.Add(coimbra);

            //EVORA
            Distrito evora = new Distrito("Évora");
            evora.Concelhos.Add(new Concelho("Alandroal"));
            evora.Concelhos.Add(new Concelho("Arraiolos"));
            evora.Concelhos.Add(new Concelho("Borba"));
            evora.Concelhos.Add(new Concelho("Estremoz"));
            evora.Concelhos.Add(new Concelho("Évora"));
            evora.Concelhos.Add(new Concelho("Montemor-o-Novo"));
            evora.Concelhos.Add(new Concelho("Mora"));
            evora.Concelhos.Add(new Concelho("Mourão"));
            evora.Concelhos.Add(new Concelho("Olivença"));
            evora.Concelhos.Add(new Concelho("Portel"));
            evora.Concelhos.Add(new Concelho("Redondo"));
            evora.Concelhos.Add(new Concelho("Reguengos de Monsaraz"));
            evora.Concelhos.Add(new Concelho("Vendas Novas"));
            evora.Concelhos.Add(new Concelho("Viana do Alentejo"));
            evora.Concelhos.Add(new Concelho("Vila Viçosa"));

            Portugal.Distritos.Add(evora);

            //FARO
            Distrito faro = new Distrito("Faro");
            faro.Concelhos.Add(new Concelho("Albufeira"));
            faro.Concelhos.Add(new Concelho("Alcoutim"));
            faro.Concelhos.Add(new Concelho("Aljezur"));
            faro.Concelhos.Add(new Concelho("Castro Marim"));
            faro.Concelhos.Add(new Concelho("Faro"));
            faro.Concelhos.Add(new Concelho("Lagoa"));
            faro.Concelhos.Add(new Concelho("Lagos"));
            faro.Concelhos.Add(new Concelho("Loulé"));
            faro.Concelhos.Add(new Concelho("Monchique"));
            faro.Concelhos.Add(new Concelho("Olhão"));
            faro.Concelhos.Add(new Concelho("Portimão"));
            faro.Concelhos.Add(new Concelho("São Brás de Alportel"));
            faro.Concelhos.Add(new Concelho("Silves"));
            faro.Concelhos.Add(new Concelho("Tavira"));
            faro.Concelhos.Add(new Concelho("Vila do Bispo"));
            faro.Concelhos.Add(new Concelho("Vila Real de Santo António"));

            Portugal.Distritos.Add(faro);


            //GUARDA
            Distrito guarda = new Distrito("Guarda");
            guarda.Concelhos.Add(new Concelho("Aguiar da Beira"));
            guarda.Concelhos.Add(new Concelho("Almeida"));
            guarda.Concelhos.Add(new Concelho("Celorico da Beira"));
            guarda.Concelhos.Add(new Concelho("Figueira de Castelo Rodrigo"));
            guarda.Concelhos.Add(new Concelho("Fornos de Algodres"));
            guarda.Concelhos.Add(new Concelho("Gouveia"));
            guarda.Concelhos.Add(new Concelho("Guarda"));
            guarda.Concelhos.Add(new Concelho("Manteigas"));
            guarda.Concelhos.Add(new Concelho("Mêda"));
            guarda.Concelhos.Add(new Concelho("Pinhel"));
            guarda.Concelhos.Add(new Concelho("Sabugal"));
            guarda.Concelhos.Add(new Concelho("Seia"));
            guarda.Concelhos.Add(new Concelho("Trancoso"));
            guarda.Concelhos.Add(new Concelho("Vila Nova de Foz Côa"));

            Portugal.Distritos.Add(guarda);

            //LEIRIA
            Distrito leiria = new Distrito("Leiria");

            leiria.Concelhos.Add(new Concelho("Alcobaça"));
            leiria.Concelhos.Add(new Concelho("Alvaiázere"));
            leiria.Concelhos.Add(new Concelho("Ansião"));
            leiria.Concelhos.Add(new Concelho("Batalha"));
            leiria.Concelhos.Add(new Concelho("Bombarral"));
            leiria.Concelhos.Add(new Concelho("Caldas da Rainha"));
            leiria.Concelhos.Add(new Concelho("Castanheira de Pera"));
            leiria.Concelhos.Add(new Concelho("Figueiró dos Vinhos"));
            leiria.Concelhos.Add(new Concelho("Leiria"));
            leiria.Concelhos.Add(new Concelho("Marinha Grande"));
            leiria.Concelhos.Add(new Concelho("Nazaré"));
            leiria.Concelhos.Add(new Concelho("Óbidos"));
            leiria.Concelhos.Add(new Concelho("Pedrógão Grande"));
            leiria.Concelhos.Add(new Concelho("Peniche"));
            leiria.Concelhos.Add(new Concelho("Pombal"));
            leiria.Concelhos.Add(new Concelho("Porto de Mós"));

            Portugal.Distritos.Add(leiria);


            //LISBOA
            Distrito lisboa = new Distrito("Lisboa");

            lisboa.Concelhos.Add(new Concelho("Alenquer"));
            lisboa.Concelhos.Add(new Concelho("Amadora"));
            lisboa.Concelhos.Add(new Concelho("Arruda dos Vinhos"));
            lisboa.Concelhos.Add(new Concelho("Azambuja"));
            lisboa.Concelhos.Add(new Concelho("Cadaval"));
            lisboa.Concelhos.Add(new Concelho("Cascais"));
            lisboa.Concelhos.Add(new Concelho("Lisboa"));
            lisboa.Concelhos.Add(new Concelho("Loures"));
            lisboa.Concelhos.Add(new Concelho("Lourinhã"));
            lisboa.Concelhos.Add(new Concelho("Mafra"));
            lisboa.Concelhos.Add(new Concelho("Odivelas"));
            lisboa.Concelhos.Add(new Concelho("Oeiras"));
            lisboa.Concelhos.Add(new Concelho("Sintra"));
            lisboa.Concelhos.Add(new Concelho("Sobral de Monte Agraço"));
            lisboa.Concelhos.Add(new Concelho("Torres Vedras"));
            lisboa.Concelhos.Add(new Concelho("Vila Franca de Xira"));

            Portugal.Distritos.Add(lisboa);

            //PORTALEGRE
            Distrito portalegre = new Distrito("Portalegre");

            portalegre.Concelhos.Add(new Concelho("Alter do Chão"));
            portalegre.Concelhos.Add(new Concelho("Arronches"));
            portalegre.Concelhos.Add(new Concelho("Avis"));
            portalegre.Concelhos.Add(new Concelho("Campo Maior"));
            portalegre.Concelhos.Add(new Concelho("Castelo de Vide"));
            portalegre.Concelhos.Add(new Concelho("Crato"));
            portalegre.Concelhos.Add(new Concelho("Elvas"));
            portalegre.Concelhos.Add(new Concelho("Fronteira"));
            portalegre.Concelhos.Add(new Concelho("Gavião"));
            portalegre.Concelhos.Add(new Concelho("Marvão"));
            portalegre.Concelhos.Add(new Concelho("Monforte"));
            portalegre.Concelhos.Add(new Concelho("Nisa"));
            portalegre.Concelhos.Add(new Concelho("Ponte de Sor"));
            portalegre.Concelhos.Add(new Concelho("Portalegre"));
            portalegre.Concelhos.Add(new Concelho("Sousel"));

            Portugal.Distritos.Add(portalegre);

            //PORTO
            Distrito porto = new Distrito("Porto");

            porto.Concelhos.Add(new Concelho("Amarante"));
            porto.Concelhos.Add(new Concelho("Baião"));
            porto.Concelhos.Add(new Concelho("Felgueiras"));
            porto.Concelhos.Add(new Concelho("Gondomar"));
            porto.Concelhos.Add(new Concelho("Lousada"));
            porto.Concelhos.Add(new Concelho("Maia"));
            porto.Concelhos.Add(new Concelho("Marco de Canaveses"));
            porto.Concelhos.Add(new Concelho("Matosinhos"));
            porto.Concelhos.Add(new Concelho("Paços de Ferreira"));
            porto.Concelhos.Add(new Concelho("Paredes"));
            porto.Concelhos.Add(new Concelho("Penafiel"));
            porto.Concelhos.Add(new Concelho("Porto"));
            porto.Concelhos.Add(new Concelho("Póvoa de Varzim"));
            porto.Concelhos.Add(new Concelho("Santo Tirso"));
            porto.Concelhos.Add(new Concelho("Trofa"));
            porto.Concelhos.Add(new Concelho("Valongo"));
            porto.Concelhos.Add(new Concelho("Vila do Conde"));
            porto.Concelhos.Add(new Concelho("Vila Nova de Gaia"));

            Portugal.Distritos.Add(porto);

            //SANTAREM
            Distrito santarem = new Distrito("Santarém");

            santarem.Concelhos.Add(new Concelho("Abrantes"));
            santarem.Concelhos.Add(new Concelho("Alcanena"));
            santarem.Concelhos.Add(new Concelho("Almeirim"));
            santarem.Concelhos.Add(new Concelho("Alpiarça"));
            santarem.Concelhos.Add(new Concelho("Benavente"));
            santarem.Concelhos.Add(new Concelho("Cartaxo"));
            santarem.Concelhos.Add(new Concelho("Chamusca"));
            santarem.Concelhos.Add(new Concelho("Constância"));
            santarem.Concelhos.Add(new Concelho("Coruche"));
            santarem.Concelhos.Add(new Concelho("Entroncamento"));
            santarem.Concelhos.Add(new Concelho("Ferreira do Zêzere"));
            santarem.Concelhos.Add(new Concelho("Golegã"));
            santarem.Concelhos.Add(new Concelho("Mação"));
            santarem.Concelhos.Add(new Concelho("Ourém"));
            santarem.Concelhos.Add(new Concelho("Rio Maior"));
            santarem.Concelhos.Add(new Concelho("Salvaterra de Magos"));
            santarem.Concelhos.Add(new Concelho("Santarém"));
            santarem.Concelhos.Add(new Concelho("Sardoal"));
            santarem.Concelhos.Add(new Concelho("Tomar"));
            santarem.Concelhos.Add(new Concelho("Torres Novas"));
            santarem.Concelhos.Add(new Concelho("Vila Nova da Barquinha"));

            Portugal.Distritos.Add(santarem);

            //SETUBAL
            Distrito setubal = new Distrito("Setubal");

            setubal.Concelhos.Add(new Concelho("Alcácer do Sal"));
            setubal.Concelhos.Add(new Concelho("Alcochete"));
            setubal.Concelhos.Add(new Concelho("Almada"));
            setubal.Concelhos.Add(new Concelho("Barreiro"));
            setubal.Concelhos.Add(new Concelho("Grândola"));
            setubal.Concelhos.Add(new Concelho("Moita"));
            setubal.Concelhos.Add(new Concelho("Montijo"));
            setubal.Concelhos.Add(new Concelho("Palmela"));
            setubal.Concelhos.Add(new Concelho("Santiago do Cacém"));
            setubal.Concelhos.Add(new Concelho("Seixal"));
            setubal.Concelhos.Add(new Concelho("Sesimbra"));
            setubal.Concelhos.Add(new Concelho("Setúbal"));
            setubal.Concelhos.Add(new Concelho("Sines"));

            Portugal.Distritos.Add(setubal);

            //VIANA DO CASTELO
            Distrito vianaDoCastelo = new Distrito("Viana do Castelo");

            vianaDoCastelo.Concelhos.Add(new Concelho("Arcos de Valdevez"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Caminha"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Melgaço"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Monção"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Paredes de Coura"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Ponte da Barca"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Ponte de Lima"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Valença"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Viana do Castelo"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Vila Nova de Cerveira"));

            Portugal.Distritos.Add(vianaDoCastelo);

            //VILA REAL
            Distrito vilaReal = new Distrito("Vila Real");

            vilaReal.Concelhos.Add(new Concelho("Alijó"));
            vilaReal.Concelhos.Add(new Concelho("Boticas"));
            vilaReal.Concelhos.Add(new Concelho("Chaves"));
            vilaReal.Concelhos.Add(new Concelho("Mesão Frio"));
            vilaReal.Concelhos.Add(new Concelho("Mondim de Basto"));
            vilaReal.Concelhos.Add(new Concelho("Montalegre"));
            vilaReal.Concelhos.Add(new Concelho("Murça"));
            vilaReal.Concelhos.Add(new Concelho("Peso da Régua"));
            vilaReal.Concelhos.Add(new Concelho("Ribeira de Pena"));
            vilaReal.Concelhos.Add(new Concelho("Sabrosa"));
            vilaReal.Concelhos.Add(new Concelho("Santa Marta de Penaguião"));
            vilaReal.Concelhos.Add(new Concelho("Valpaços"));
            vilaReal.Concelhos.Add(new Concelho("Vila Pouca de Aguiar"));
            vilaReal.Concelhos.Add(new Concelho("Vila Real"));

            Portugal.Distritos.Add(vilaReal);


            //VISEU
            Distrito viseu = new Distrito("Viseu");

            viseu.Concelhos.Add(new Concelho("Armamar"));
            viseu.Concelhos.Add(new Concelho("Carregal do Sal"));
            viseu.Concelhos.Add(new Concelho("Castro Daire"));
            viseu.Concelhos.Add(new Concelho("Cinfães"));
            viseu.Concelhos.Add(new Concelho("Lamego"));
            viseu.Concelhos.Add(new Concelho("Mangualde"));
            viseu.Concelhos.Add(new Concelho("Moimenta da Beira"));
            viseu.Concelhos.Add(new Concelho("Mortágua"));
            viseu.Concelhos.Add(new Concelho("Nelas"));
            viseu.Concelhos.Add(new Concelho("Oliveira de Frades"));
            viseu.Concelhos.Add(new Concelho("Penalva do Castelo"));
            viseu.Concelhos.Add(new Concelho("Penedono"));
            viseu.Concelhos.Add(new Concelho("Resende"));
            viseu.Concelhos.Add(new Concelho("Santa Comba Dão"));
            viseu.Concelhos.Add(new Concelho("São João da Pesqueira"));
            viseu.Concelhos.Add(new Concelho("São Pedro do Sul"));
            viseu.Concelhos.Add(new Concelho("Sátão"));
            viseu.Concelhos.Add(new Concelho("Sernancelhe"));
            viseu.Concelhos.Add(new Concelho("Tabuaço"));
            viseu.Concelhos.Add(new Concelho("Tarouca"));
            viseu.Concelhos.Add(new Concelho("Tondela"));
            viseu.Concelhos.Add(new Concelho("Vila Nova de Paiva"));
            viseu.Concelhos.Add(new Concelho("Viseu"));
            viseu.Concelhos.Add(new Concelho("Vouzela"));

            Portugal.Distritos.Add(viseu);




            cbxDistritos.Items.Clear();
            foreach (Distrito distrito in Portugal.Distritos)
            {
                cbxDistritos.Items.Add(distrito.nome);
            }
        }

        public class Pais
        {
            public string nome;
            public List<Distrito> Distritos;

            public Pais(string name)
            {
                nome = name;
                Distritos = new List<Distrito>();
            }
        }

        public class Distrito
        {
            public string nome;
            public List<Concelho> Concelhos;

            public Distrito(string name)
            {
                nome = name;
                Concelhos = new List<Concelho>();
            }
        }
        public class Concelho
        {
            public string nome;

            public Concelho(string name)
            {
                nome = name;
            }


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            foreach (Concelho concelho in Portugal.Distritos.Find(x => x.nome == (string)cbxDistritos.SelectedItem).Concelhos)
            {
                comboBox2.Items.Add(concelho.nome);
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
            if (cbxDistritos.Text == "Braga" || comboBox2.Text == ("Barcelos") || comboBox3.Text == ("IPCA - Instituto Politécnico Cavado Ave")){ pictureBox1.Show();
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

        private void cbxDistritos_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (cbxDistritos.SelectedValue == null)
            {
                return;
            }

            foreach (Concelho concelho in Portugal.Distritos.Find(x => x.nome == (string)cbxDistritos.SelectedValue).Concelhos)
            {
                comboBox2.Items.Add(concelho.nome);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
