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

            #region Conselhos

            // BRAGA 

            #region Braga

            Distrito braga = new Distrito("Braga");

            Concelho bragC = new Concelho("Braga");
            bragC.Universidades.Add(new Universidade("Universidade do Minho(UM)"));
            bragC.Universidades.Add(new Universidade("Universidade Católica Portuguesa (UCP) - Centro Regional de Braga"));
            bragC.Universidades.Add(new Universidade("Instituto Politécnico de Saúde do Norte"));
            bragC.Universidades.Add(new Universidade("Instituto Superior de Saúde do Alto Ave"));
            bragC.Universidades.Add(new Universidade("Instituto Politécnico do Cávado e do Ave(IPCA)"));

            braga.Concelhos.Add(bragC);

            Concelho famalicao = new Concelho("Vila Nova de Famalicão");
            famalicao.Universidades.Add(new Universidade("Universidade Lusíada de Vila Nova de Famalicão"));


            braga.Concelhos.Add(famalicao);

            Concelho barcelos = new Concelho("Barcelos");
            barcelos.Universidades.Add(new Universidade("Instituto Politécnico do Cávado e do Ave(IPCA)"));


            braga.Concelhos.Add(barcelos);

            Concelho guimaraes = new Concelho("Guimarães");
            guimaraes.Universidades.Add(new Universidade("Instituto Politécnico do Cávado e do Ave(IPCA)"));
            guimaraes.Universidades.Add(new Universidade("Escola Superior Artística do Porto(ESAP) - Guimarães"));

            braga.Concelhos.Add(guimaraes);

            Concelho fafe = new Concelho("Fafe");
            fafe.Universidades.Add(new Universidade("Instituto de Estudos Superiores de Fafe(IESF)"));


            braga.Concelhos.Add(fafe);

            braga.Concelhos.Add(new Concelho("Amares"));
            //braga.Concelhos.Add(new Concelho("Barcelos"));
            //braga.Concelhos.Add(new Concelho("Braga"));
            braga.Concelhos.Add(new Concelho("Cabeceuras de Basto"));
            braga.Concelhos.Add(new Concelho("Celorico de Basto"));
            braga.Concelhos.Add(new Concelho("Esposende"));
            // braga.Concelhos.Add(new Concelho("Fafe"));
            // braga.Concelhos.Add(new Concelho("Guimarães"));
            braga.Concelhos.Add(new Concelho("Póvoa de Lanhoso"));
            braga.Concelhos.Add(new Concelho("Terras de Bouro"));
            braga.Concelhos.Add(new Concelho("Vieira do Minho"));
            // braga.Concelhos.Add(new Concelho("Vila Nova de Famalicão"));
            braga.Concelhos.Add(new Concelho("Vila Verde"));
            braga.Concelhos.Add(new Concelho("Vizela"));


            Portugal.Distritos.Add(braga);

            #endregion

            //CASTELO BRANCO 

            #region castelo branco

            Distrito casteloBranco = new Distrito("Castelo Branco");
            Concelho castC = new Concelho("Castelo Branco");
            castC.Universidades.Add(new Universidade("Universidade da Beira Interior (UBI)"));
            castC.Universidades.Add(new Universidade("Instituto Politécnico de Castelo Branco(IPCB)"));


            casteloBranco.Concelhos.Add(castC);


            casteloBranco.Concelhos.Add(new Concelho("Belmonte"));
            // casteloBranco.Concelhos.Add(new Concelho("Castelo Branco"));
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

            #endregion

            //AVEIRO 

            #region Aveiro

            Distrito aveiro = new Distrito("Aveiro");

            Concelho aveiroC = new Concelho("Aveiro");
            aveiroC.Universidades.Add(new Universidade("Universidade de Aveiro"));
            aveiroC.Universidades.Add(new Universidade("Instituto Superior de Entre Douro e Vouga(ISVOUGA)"));
            aveiroC.Universidades.Add(
                new Universidade("Instituto Superior de Ciências da Informação e da Administração(ISCIA)"));
            aveiroC.Universidades.Add(
                new Universidade("Instituto Português de Administração de Marketing de Matosinhos(IPAM) - Aveiro"));

            Concelho espinho = new Concelho("Espinho");
            espinho.Universidades.Add(new Universidade("Instituto Superior de Espinho (ISESP)"));
            aveiro.Concelhos.Add(espinho);

            Concelho oliveiraAz = new Concelho("Oliveira de Azemeis");
            oliveiraAz.Universidades.Add(
                new Universidade("Escola Superior de Enfermagem da Cruz Vermelha Portuguesa de Oliveira de Azeméis"));
            aveiro.Concelhos.Add(oliveiraAz);

            aveiro.Concelhos.Add(aveiroC);
            aveiro.Concelhos.Add(new Concelho("Agueda"));
            aveiro.Concelhos.Add(new Concelho("Albergaria a Velha"));
            aveiro.Concelhos.Add(new Concelho("Anadia"));
            aveiro.Concelhos.Add(new Concelho("Arouca"));
            // aveiro.Concelhos.Add(new Concelho("Aveiro"));
            aveiro.Concelhos.Add(new Concelho("Castelo de Paiva"));
            //aveiro.Concelhos.Add(new Concelho("Espinho"));


            aveiro.Concelhos.Add(new Concelho("Estarreja "));
            aveiro.Concelhos.Add(new Concelho("Ilhavo"));
            aveiro.Concelhos.Add(new Concelho("Mealhada"));
            aveiro.Concelhos.Add(new Concelho("Murtosa"));
            //aveiro.Concelhos.Add(new Concelho("Oliveira de Azemeis"));


            aveiro.Concelhos.Add(new Concelho("Oliveira do Bairro"));
            aveiro.Concelhos.Add(new Concelho("Ovar"));
            aveiro.Concelhos.Add(new Concelho("Santa Maria da Feira"));
            aveiro.Concelhos.Add(new Concelho("São João da Madeira"));
            aveiro.Concelhos.Add(new Concelho("Sever do Vouga"));
            aveiro.Concelhos.Add(new Concelho("Vagos"));
            aveiro.Concelhos.Add(new Concelho("Vale de Cambra"));

            Portugal.Distritos.Add(aveiro);

            #endregion

            //BEJA

            #region Beja

            Distrito beja = new Distrito("Beja");

            Concelho bejC = new Concelho("Beja");
            bejC.Universidades.Add(new Universidade("Instituto Politécnico de Beja (IPBeja)"));
            beja.Concelhos.Add(bejC);

            beja.Concelhos.Add(new Concelho("Aljustrel"));
            beja.Concelhos.Add(new Concelho("Almodovar"));
            beja.Concelhos.Add(new Concelho("Alvito"));
            beja.Concelhos.Add(new Concelho("Barrancos"));
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

            #endregion

            //BRAGANÇA

            #region Braganca

            Distrito braganca = new Distrito("Bragança");

            Concelho braganC = new Concelho("Bragança");
            bragC.Universidades.Add(
                new Universidade("Instituto Superior de Estudos Interculturais e Transdisciplinares - Mirandela"));

            bragC.Universidades.Add(new Universidade("Instituto Politécnico de Bragança (IPB)"));
            bragC.Universidades.Add(new Universidade("Instituto Superior de Línguas e Administração de Bragança"));
            bragC.Universidades.Add(new Universidade("Instituto Jean Piaget"));


            braganca.Concelhos.Add(braganC);


            braganca.Concelhos.Add(new Concelho("Alfândega da Fé"));
            // braganca.Concelhos.Add(new Concelho("Bragança"));
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

            #endregion

            //COIMBRA

            #region Coimbra 

            Distrito coimbra = new Distrito("Coimbra");

            Concelho coimbC = new Concelho("Coimbra");
            coimbC.Universidades.Add(new Universidade("Universidade de Coimbra(UC)"));

            coimbC.Universidades.Add(new Universidade("Escola Superior de Enfermagem de Coimbra(ESEnfC)"));
            coimbC.Universidades.Add(new Universidade("Instituto Politécnico de Coimbra (IPC)"));
            coimbC.Universidades.Add(new Universidade("Instituto Superior Bissaya Barreto(ISBB)"));
            coimbC.Universidades.Add(new Universidade("Instituto Superior Miguel Torga(ISMT))"));
            coimbC.Universidades.Add(new Universidade("Escola Universitária das Artes de Coimbra(EUAC)"));
            coimbC.Universidades.Add(new Universidade("Escola Universitária Vasco da Gama(EUVG)"));


            coimbra.Concelhos.Add(coimbC);


            coimbra.Concelhos.Add(new Concelho("Arganil"));
            coimbra.Concelhos.Add(new Concelho("Cantanhede"));
            //coimbra.Concelhos.Add(new Concelho("Coimbra"));
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

            #endregion

            //EVORA

            #region evora

            Distrito evora = new Distrito("Évora");

            Concelho evorC = new Concelho("Évora");
            evorC.Universidades.Add(new Universidade("Universidade de Évora (UEv)"));


            evora.Concelhos.Add(evorC);

            evora.Concelhos.Add(new Concelho("Alandroal"));
            evora.Concelhos.Add(new Concelho("Arraiolos"));
            evora.Concelhos.Add(new Concelho("Borba"));
            evora.Concelhos.Add(new Concelho("Estremoz"));
            //evora.Concelhos.Add(new Concelho("Évora"));
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

            #endregion

            //FARO

            #region faro

            Distrito faro = new Distrito("Faro");


            Concelho farC = new Concelho("Faro");
            farC.Universidades.Add(new Universidade("Universidade do Algarve(UAlg)"));
            farC.Universidades.Add(new Universidade("Instituto Superior D. Afonso III (INUAF)"));
            farC.Universidades.Add(new Universidade("Instituto Superior Manuel Teixeira Gomes(ISMAT)"));
            farC.Universidades.Add(new Universidade("Escola Superior de Saúde Jean Piaget - Algarve"));


            faro.Concelhos.Add(farC);

            faro.Concelhos.Add(new Concelho("Albufeira"));
            faro.Concelhos.Add(new Concelho("Alcoutim"));
            faro.Concelhos.Add(new Concelho("Aljezur"));
            faro.Concelhos.Add(new Concelho("Castro Marim"));
            // faro.Concelhos.Add(new Concelho("Faro"));
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

            #endregion

            //GUARDA

            #region Guarda

            Distrito guarda = new Distrito("Guarda");

            Concelho guarC = new Concelho("Guarda");
            guarC.Universidades.Add(new Universidade("Instituto Politécnico da Guarda (IPG)"));


            guarda.Concelhos.Add(guarC);


            guarda.Concelhos.Add(new Concelho("Aguiar da Beira"));
            guarda.Concelhos.Add(new Concelho("Almeida"));
            guarda.Concelhos.Add(new Concelho("Celorico da Beira"));
            guarda.Concelhos.Add(new Concelho("Figueira de Castelo Rodrigo"));
            guarda.Concelhos.Add(new Concelho("Fornos de Algodres"));
            guarda.Concelhos.Add(new Concelho("Gouveia"));
            // guarda.Concelhos.Add(new Concelho("Guarda"));
            guarda.Concelhos.Add(new Concelho("Manteigas"));
            guarda.Concelhos.Add(new Concelho("Mêda"));
            guarda.Concelhos.Add(new Concelho("Pinhel"));
            guarda.Concelhos.Add(new Concelho("Sabugal"));
            guarda.Concelhos.Add(new Concelho("Seia"));
            guarda.Concelhos.Add(new Concelho("Trancoso"));
            guarda.Concelhos.Add(new Concelho("Vila Nova de Foz Côa"));

            Portugal.Distritos.Add(guarda);

            #endregion

            //LEIRIA

            #region leiria

            Distrito leiria = new Distrito("Leiria");

            Concelho leirC = new Concelho("Leiria");
            leirC.Universidades.Add(new Universidade("Instituto Politécnico de Leiria (IPL)"));
            leirC.Universidades.Add(new Universidade("Universidade Católica Portuguesa(UCP) - Caldas da Rainha"));
            leirC.Universidades.Add(new Universidade("Instituto Superior de Línguas e Administração de Leiria"));
            leirC.Universidades.Add(new Universidade("Instituto Superior D.Dinis"));


            leiria.Concelhos.Add(leirC);
            Concelho caldas = new Concelho("Caldas da Rainha");
            caldas.Universidades.Add(new Universidade("Universidade Católica Portuguesa(UCP) - Caldas da Rainha"));

            leiria.Concelhos.Add(caldas);


            leiria.Concelhos.Add(new Concelho("Alcobaça"));
            leiria.Concelhos.Add(new Concelho("Alvaiázere"));
            leiria.Concelhos.Add(new Concelho("Ansião"));
            leiria.Concelhos.Add(new Concelho("Batalha"));
            leiria.Concelhos.Add(new Concelho("Bombarral"));
            // leiria.Concelhos.Add(new Concelho("Caldas da Rainha"));
            leiria.Concelhos.Add(new Concelho("Castanheira de Pera"));
            leiria.Concelhos.Add(new Concelho("Figueiró dos Vinhos"));
            // leiria.Concelhos.Add(new Concelho("Leiria"));
            leiria.Concelhos.Add(new Concelho("Marinha Grande"));
            leiria.Concelhos.Add(new Concelho("Nazaré"));
            leiria.Concelhos.Add(new Concelho("Óbidos"));
            leiria.Concelhos.Add(new Concelho("Pedrógão Grande"));
            leiria.Concelhos.Add(new Concelho("Peniche"));
            leiria.Concelhos.Add(new Concelho("Pombal"));
            leiria.Concelhos.Add(new Concelho("Porto de Mós"));

            Portugal.Distritos.Add(leiria);

            #endregion

            //LISBOA

            #region Lisboa

            Distrito lisboa = new Distrito("Lisboa");

            Concelho lisbC = new Concelho("Lisboa");
            lisbC.Universidades.Add(new Universidade("Academia da Força Aérea (AFA)"));
            lisbC.Universidades.Add(new Universidade("Academia Militar"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Artes Decorativas (ESAD)"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Design(ESD)"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Educação de Almeida Garrett"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Educação de João de Deus"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Educadores de Infância Maria Ulrich"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Enfermagem de Lisboa"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Enfermagem S.Francisco das Misericórdias"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Hotelaria e Turismo do Estoril"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Marketing e Publicidade"));
            lisbC.Universidades.Add(new Universidade("Escola Superior Náutica Infante D.Henrique"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Saúde do Alcoitão"));

            lisbC.Universidades.Add(new Universidade("Escola Superior de Saúde da Cruz Vermelha Portuguesa"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Saúde Ribeiro Sanches"));
            lisbC.Universidades.Add(new Universidade("Escola Superior de Tecnologias e Artes de Lisboa (ESTAL)"));
            lisbC.Universidades.Add(new Universidade("Instituto Politécnico de Lisboa(IPL)"));
            lisbC.Universidades.Add(new Universidade("Instituto Português de Administração de Marketing de Lisboa(IPAM)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior Autónomo de Estudos Politécnicos(IPA)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Ciências da Administração(ISCA)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Ciências Educativas"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Ciências Policiais e Segurança Interna"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Comunicação Empresarial(ISCEM)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Educação e Ciências(ISEC)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Gestão"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Gestão Bancária"));

            lisbC.Universidades.Add(new Universidade("Instituto Superior de Línguas e Administração de Lisboa(ISLA)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Novas Profissões(ISNP)"));
            lisbC.Universidades.Add(new Universidade("ISPA - Instituto Universitário de Psicologia Aplicada(ISPA - IU)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Tecnologias Avançadas de Lisboa(ISTEC)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior Politécnico do Oeste(ISPO)"));
            lisbC.Universidades.Add(new Universidade("ISCTE - Instituto Universitário de Lisboa(ISCTE)"));
            lisbC.Universidades.Add(new Universidade("Instituto Superior de Ciências da Administração(ISCA)"));
            lisbC.Universidades.Add(new Universidade("Universidade Aberta (UAb)"));
            lisbC.Universidades.Add(new Universidade("Universidade Atlântica(EIA)"));
            lisbC.Universidades.Add(new Universidade("Universidade Católica Portuguesa(UCP)"));
            lisbC.Universidades.Add(new Universidade("Universidade Nova de Lisboa(UNL)"));
            lisbC.Universidades.Add(new Universidade("Universidade Europeia(UE)"));
            lisbC.Universidades.Add(new Universidade("Universidade de Lisboa(UL)"));
            lisbC.Universidades.Add(new Universidade("Universidade Lusófona de Humanidades e Tecnologias(ULHT)"));


            lisboa.Concelhos.Add(lisbC);


            lisboa.Concelhos.Add(new Concelho("Alenquer"));
            lisboa.Concelhos.Add(new Concelho("Amadora"));
            lisboa.Concelhos.Add(new Concelho("Arruda dos Vinhos"));
            lisboa.Concelhos.Add(new Concelho("Azambuja"));
            lisboa.Concelhos.Add(new Concelho("Cadaval"));
            lisboa.Concelhos.Add(new Concelho("Cascais"));
            //lisboa.Concelhos.Add(new Concelho("Lisboa"));
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

            #endregion

            //PORTALEGRE 

            #region portalegre

            Distrito portalegre = new Distrito("Portalegre");

            Concelho portC = new Concelho("Portalegre");
            portC.Universidades.Add(new Universidade("Instituto Politécnico de Portalegre"));


            portalegre.Concelhos.Add(portC);


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
            // portalegre.Concelhos.Add(new Concelho("Portalegre"));
            portalegre.Concelhos.Add(new Concelho("Sousel"));

            Portugal.Distritos.Add(portalegre);

            #endregion

            //PORTO

            #region porto

            Distrito porto = new Distrito("Porto");

            Concelho portoC = new Concelho("Porto");
            portC.Universidades.Add(new Universidade("Universidade do Porto(UP)"));

            portoC.Universidades.Add(new Universidade("Instituto Politécnico do Porto(IPP)"));

            portoC.Universidades.Add(new Universidade("Universidade Fernando Pessoa(UFP"));
            portoC.Universidades.Add(
                new Universidade("Universidade Católica Portuguesa (UCP) - Centro Regional do Porto"));
            portoC.Universidades.Add(new Universidade("Universidade Lusófona do Porto"));
            portoC.Universidades.Add(new Universidade("Instituto Superior Politécnico Gaya (ISPGaya)"));
            portoC.Universidades.Add(new Universidade("Instituto Universitário da Maia - ISMAI"));

            portoC.Universidades.Add(new Universidade("Instituto Politécnico da Maia - IPMAIA"));
            portoC.Universidades.Add(new Universidade("Escola Superior Artística do Porto(ESAP)"));
            portoC.Universidades.Add(new Universidade("Universidade Portucalense Infante D.Henrique(UPT)"));
            portoC.Universidades.Add(new Universidade("Escola Superior de Enfermagem do Porto"));
            portoC.Universidades.Add(new Universidade("Instituto Superior de Ciências da Saúde -Norte"));
            portoC.Universidades.Add(new Universidade("Instituto Superior de Educação e Trabalho"));
            portoC.Universidades.Add(
                new Universidade("Instituto Superior de Línguas e Administração de Vila Nova de Gaia"));
            portoC.Universidades.Add(new Universidade("Instituto Superior de Serviço Social do Porto"));
            portoC.Universidades.Add(new Universidade("Conservatório Superior de Música de Gaia"));
            portoC.Universidades.Add(new Universidade("Escola Superior de Artes e Design"));
            portoC.Universidades.Add(new Universidade("Escola Superior de Educação Jean Piaget de Arcozelo"));
            portoC.Universidades.Add(new Universidade("Escola Superior de Educação de Paula Frassinetti"));
            portoC.Universidades.Add(new Universidade("Escola Superior de Educação de Santa Maria"));
            portoC.Universidades.Add(new Universidade("Escola Superior de Enfermagem de Santa Maria"));
            portoC.Universidades.Add(new Universidade("Escola Superior de Saúde Jean Piaget de Vila Nova de Gaia"));
            portoC.Universidades.Add(new Universidade("Instituto de Estudos Superiores Financeiros e Fiscais - Porto"));
            portoC.Universidades.Add(
                new Universidade("Instituto Politécnico de Saúde do Norte - Escola Superior de Saúde do Vale do Sousa"));
            portoC.Universidades.Add(new Universidade("Instituto Português de Administração de Marketing de Matosinhos"));
            portoC.Universidades.Add(new Universidade("Instituto Superior de Administração e Gestão"));
            portoC.Universidades.Add(new Universidade("Instituto Superior de Ciências Educativas de Felgueiras"));
            portoC.Universidades.Add(new Universidade("Instituto Superior de Ciências Empresariais e do Turismo"));
            portoC.Universidades.Add(new Universidade("Instituto Superior de Tecnologias Avançadas de Lisboa - Porto"));

            porto.Concelhos.Add(portoC);

            Concelho maia = new Concelho("Maia");
            maia.Universidades.Add(new Universidade("Instituto Politécnico da Maia - IPMAIA"));

            maia.Universidades.Add(new Universidade("Instituto Universitário da Maia - ISMAI"));

            porto.Concelhos.Add(maia);

            Concelho gaia = new Concelho("Vila Nova de Gaia");
            gaia.Universidades.Add(new Universidade("Conservatório Superior de Música de Gaia"));
            gaia.Universidades.Add(new Universidade("Instituto Superior de Línguas e Administração de Vila Nova de Gaia"));
            gaia.Universidades.Add(new Universidade("Escola Superior de Saúde Jean Piaget de Vila Nova de Gaia"));


            porto.Concelhos.Add(gaia);


            Concelho matosinhos = new Concelho("Matosinhos");
            matosinhos.Universidades.Add(
                new Universidade("Instituto Português de Administração de Marketing de Matosinhos"));

            porto.Concelhos.Add(matosinhos);


            Concelho felgueiras = new Concelho("Felgueiras");
            felgueiras.Universidades.Add(new Universidade("Instituto Superior de Ciências Educativas de Felgueiras"));

            porto.Concelhos.Add(felgueiras);


            porto.Concelhos.Add(new Concelho("Amarante"));
            porto.Concelhos.Add(new Concelho("Baião"));
            // porto.Concelhos.Add(new Concelho("Felgueiras"));
            porto.Concelhos.Add(new Concelho("Gondomar"));
            porto.Concelhos.Add(new Concelho("Lousada"));
            // porto.Concelhos.Add(new Concelho("Maia"));
            porto.Concelhos.Add(new Concelho("Marco de Canaveses"));
            // porto.Concelhos.Add(new Concelho("Matosinhos"));
            porto.Concelhos.Add(new Concelho("Paços de Ferreira"));
            porto.Concelhos.Add(new Concelho("Paredes"));
            porto.Concelhos.Add(new Concelho("Penafiel"));
            // porto.Concelhos.Add(new Concelho("Porto"));
            porto.Concelhos.Add(new Concelho("Póvoa de Varzim"));
            porto.Concelhos.Add(new Concelho("Santo Tirso"));
            porto.Concelhos.Add(new Concelho("Trofa"));
            porto.Concelhos.Add(new Concelho("Valongo"));
            porto.Concelhos.Add(new Concelho("Vila do Conde"));
            //  porto.Concelhos.Add(new Concelho("Vila Nova de Gaia"));

            Portugal.Distritos.Add(porto);

            #endregion

            //SANTAREM

            #region Santarem

            Distrito santarem = new Distrito("Santarém");

            Concelho santarC = new Concelho("Santarém");
            santarC.Universidades.Add(new Universidade("Instituto Politécnico de Santarém (IPS)"));
            santarC.Universidades.Add(new Universidade("Instituto Politécnico de Tomar(IPT)"));
            santarC.Universidades.Add(new Universidade("Instituto Superior de Línguas e Administração de Santarém(ISLA)"));
            santarC.Universidades.Add(new Universidade("Escola Superior de Educação de Torres Novas"));
            santarem.Concelhos.Add(santarC);

            Concelho tomar = new Concelho("Tomar");
            tomar.Universidades.Add(new Universidade("Instituto Politécnico de Tomar(IPT)"));


            santarem.Concelhos.Add(tomar);

            Concelho torres = new Concelho("Torres Novas");
            torres.Universidades.Add(new Universidade("Escola Superior de Educação de Torres Novas"));


            santarem.Concelhos.Add(torres);

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
            //santarem.Concelhos.Add(new Concelho("Santarém"));
            santarem.Concelhos.Add(new Concelho("Sardoal"));
            // santarem.Concelhos.Add(new Concelho("Tomar"));
            //santarem.Concelhos.Add(new Concelho("Torres Novas"));
            santarem.Concelhos.Add(new Concelho("Vila Nova da Barquinha"));

            Portugal.Distritos.Add(santarem);

            #endregion

            //SETUBAL

            #region setubal

            Distrito setubal = new Distrito("Setubal");

            Concelho setC = new Concelho("Setubal");
            setC.Universidades.Add(new Universidade("Instituto Politécnico de Setúbal"));
            setC.Universidades.Add(new Universidade("Universidade Nova de Lisboa (UNL) -Escola Naval"));
            setC.Universidades.Add(new Universidade("Instituto Superior de Ciências da Saúde Egas Moniz"));
            setC.Universidades.Add(
                new Universidade("Instituto Superior de Estudos Interculturais e Transdisciplinares - Almada"));
            setC.Universidades.Add(
                new Universidade("Instituto Superior de Estudos Interculturais e Transdisciplinares - Santo André"));
            setC.Universidades.Add(new Universidade("Escola Superior de Educação Jean Piaget de Almada"));

            setubal.Concelhos.Add(setC);

            Concelho almada = new Concelho("Almada");
            almada.Universidades.Add(
                new Universidade("Instituto Superior de Estudos Interculturais e Transdisciplinares - Almada"));
            almada.Universidades.Add(new Universidade("Escola Superior de Educação Jean Piaget de Almada"));

            setubal.Concelhos.Add(almada);

            setubal.Concelhos.Add(new Concelho("Alcácer do Sal"));
            setubal.Concelhos.Add(new Concelho("Alcochete"));
            // setubal.Concelhos.Add(new Concelho("Almada"));
            setubal.Concelhos.Add(new Concelho("Barreiro"));
            setubal.Concelhos.Add(new Concelho("Grândola"));
            setubal.Concelhos.Add(new Concelho("Moita"));
            setubal.Concelhos.Add(new Concelho("Montijo"));
            setubal.Concelhos.Add(new Concelho("Palmela"));
            setubal.Concelhos.Add(new Concelho("Santiago do Cacém"));
            setubal.Concelhos.Add(new Concelho("Seixal"));
            setubal.Concelhos.Add(new Concelho("Sesimbra"));
            //setubal.Concelhos.Add(new Concelho("Setúbal"));
            setubal.Concelhos.Add(new Concelho("Sines"));

            Portugal.Distritos.Add(setubal);

            #endregion

            //VIANA DO CASTELO

            #region Viana do Castelo

            Distrito vianaDoCastelo = new Distrito("Viana do Castelo");

            Concelho vianC = new Concelho("Viana do Castelo");
            vianC.Universidades.Add(new Universidade("Instituto Politécnico de Viana do Castelo"));
            vianC.Universidades.Add(new Universidade("Escola Superior Gallaecia"));
            vianC.Universidades.Add(new Universidade("Universidade Fernando Pessoa (UFP) - Ponte de Lima"));

            vianaDoCastelo.Concelhos.Add(vianC);

            Concelho ponteDeLima = new Concelho("Ponte de Lima");

            ponteDeLima.Universidades.Add(new Universidade("Universidade Fernando Pessoa (UFP) - Ponte de Lima"));

            vianaDoCastelo.Concelhos.Add(ponteDeLima);

            vianaDoCastelo.Concelhos.Add(new Concelho("Arcos de Valdevez"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Caminha"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Melgaço"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Monção"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Paredes de Coura"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Ponte da Barca"));
            //vianaDoCastelo.Concelhos.Add(new Concelho("Ponte de Lima"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Valença"));
            //vianaDoCastelo.Concelhos.Add(new Concelho("Viana do Castelo"));
            vianaDoCastelo.Concelhos.Add(new Concelho("Vila Nova de Cerveira"));

            Portugal.Distritos.Add(vianaDoCastelo);

            #endregion

            //VILA REAL

            #region Vila Real

            Distrito vilaReal = new Distrito("Vila Real");

            Concelho vilaC = new Concelho("Vila Real");

            vilaC.Universidades.Add(new Universidade("Universidade de Trás - os - Montes e Alto Douro(UTAD)"));
            vilaC.Universidades.Add(new Universidade("Escola Superior de Enfermagem Dr.José Timóteo Montalvão Machado"));


            vilaReal.Concelhos.Add(vilaC);

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
            //vilaReal.Concelhos.Add(new Concelho("Vila Real"));

            Portugal.Distritos.Add(vilaReal);

            #endregion

            //VISEU

            #region viseu

            Distrito viseu = new Distrito("Viseu");

            Concelho viseC = new Concelho("Viseu");

            viseC.Universidades.Add(
                new Universidade("Universidade Católica Portuguesa(UCP) - Centro Regional das Beiras"));
            viseC.Universidades.Add(new Universidade("Instituto Politécnico de Viseu(IPV)"));

            viseC.Universidades.Add(
                new Universidade("Instituto Superior de Estudos Interculturais e Transdisciplinares - Viseu"));
            viseC.Universidades.Add(new Universidade("Escola Superior de Educação Jean Piaget de Arcozelo -Viseu"));
            viseC.Universidades.Add(new Universidade("Escola Superior de Saúde Jean Piaget"));


            viseu.Concelhos.Add(viseC);

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

            #endregion

            cbxDistritos.Items.Clear();
            foreach (Distrito distrito in Portugal.Distritos)
            {
                cbxDistritos.Items.Add(distrito.nome);
            }

            #endregion
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
            public List<Universidade> Universidades;

            public Concelho(string name)
            {
                nome = name;
                Universidades = new List<Universidade>();
            }
        }

        public class Universidade
        {
            public string nome;

            public Universidade(string name)
            {
                nome = name;
            }
        }

        private Distrito selectedDistrict;
        private Concelho selectedConselho;
        private Universidade selectedUniversidade;

        private void cbxDistritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxConcelhos.Items.Clear();
            cbxUniversidades.Items.Clear();

            selectedDistrict = Portugal.Distritos.Find(x => x.nome == (string) cbxDistritos.SelectedItem);

            foreach (Concelho concelho in selectedDistrict.Concelhos)
            {
                cbxConcelhos.Items.Add(concelho.nome);
            }
        }

        private void cbxConcelhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxUniversidades.Items.Clear();

            selectedConselho = selectedDistrict.Concelhos.Find(x => x.nome == (string) cbxConcelhos.SelectedItem);

            foreach (Universidade universidade in selectedConselho.Universidades)
            {
                cbxUniversidades.Items.Add(universidade.nome);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 80;
            trackBar1.Maximum = 400;
            label8.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxDistritos.Text == "Braga" || cbxConcelhos.Text == "Barcelos" ||
                cbxUniversidades.Text == "IPCA - Instituto Politécnico Cavado Ave")
            {
                pictureBox1.Show();
                pictureBox2.Show();
                richTextBox1.Show();
                richTextBox2.Show();
                linkLabel1.Show();
                linkLabel2.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Habitação alun = new Habitação();
            alun.MdiParent = IGE.ActiveForm;
            alun.Show();
        }
    }
}