using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace sceriffo0
{
    public partial class Tasse1 : Form
    {
        Utente User = new Utente(); //utente con password
        Liste Lista = new Liste(); //creazione oggetto lista
        Stato Contea = new Stato(); //creazione oggetto stato
        Tempo Orologio = new Tempo();

        //inizializzazione array nomi Maschili & femminili
        string[] NomiMaschili = new string[70];
        string[] NomiFemminili = new string[70];
        string[] Cognomi = new string[57];



        public Tasse1()
        {
            InitializeComponent();

        }

        private void Tasse1_Load(object sender, EventArgs e)
        {

            pannelRegistrazione.Visible = false;
            panelLogIn.Visible = false;
            PannelloAltoDX.Visible = false;
            PannelloAltoSX.Visible = false;
            PannelloBassoSX.Visible = false;
            PannelloBassoDX.Visible = false;
            AvantiMeseBtn.Visible = false;
            if (Directory.Exists(@"Login") == true)
            {
                //deserializzazione del file 
                panelLogIn.Visible = true;
                User = JsonConvert.DeserializeObject<Utente>(File.ReadAllText(String.Format(@"Login\\datilogin.json")));
                //la password viene decrittata secondo lo stesso hash con cui è stata crittata
                string hashDecritt = "cr1tt0gr4f1@";

                byte[] datiPasswordDec = Convert.FromBase64String(User.Password);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] chiavi = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashDecritt));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = chiavi, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform convertitoreDecritto = tripDes.CreateDecryptor();
                        byte[] convertitoDecritto = convertitoreDecritto.TransformFinalBlock(datiPasswordDec, 0, datiPasswordDec.Length);
                        //prima si deserializza, poi si decodifica

                        User.Password = UTF8Encoding.UTF8.GetString(convertitoDecritto);

                    }

                }
            }
            else
            {
                Directory.CreateDirectory(@"Login");
                pannelRegistrazione.Visible = true;
            }
            //creazione array nomi maschili

            NomiMaschili[0] = "Hugh";
            NomiMaschili[1] = "Baudwin";
            NomiMaschili[2] = "Everard";
            NomiMaschili[3] = "Nicholas";
            NomiMaschili[4] = "Joseph";
            NomiMaschili[5] = "Leofwin";
            NomiMaschili[6] = "Amis";
            NomiMaschili[7] = "Ranulf";
            NomiMaschili[8] = "Fulke";
            NomiMaschili[9] = "Theobald";
            NomiMaschili[10] = "Rowan";
            NomiMaschili[11] = "Geoffrey";
            NomiMaschili[12] = "Gervase";
            NomiMaschili[13] = "Gerard";
            NomiMaschili[14] = "Godwyn";
            NomiMaschili[15] = "Philip";
            NomiMaschili[16] = "Warin";
            NomiMaschili[17] = "Warner";
            NomiMaschili[18] = "Thomas";
            NomiMaschili[19] = "Brom";
            NomiMaschili[20] = "Hamon";
            NomiMaschili[21] = "Thurstan";
            NomiMaschili[22] = "Robert";
            NomiMaschili[23] = "Roland";
            NomiMaschili[24] = "Rolf";
            NomiMaschili[25] = "Walter";
            NomiMaschili[26] = "Laurence";
            NomiMaschili[27] = "Reginald";
            NomiMaschili[28] = "Aglovale";
            NomiMaschili[29] = "Sayer";
            NomiMaschili[30] = "Timm";
            NomiMaschili[31] = "Piers";
            NomiMaschili[32] = "Cerdic";
            NomiMaschili[33] = "Randel";
            NomiMaschili[34] = "Daniel";
            NomiMaschili[35] = "Denis";
            NomiMaschili[36] = "Elias";
            NomiMaschili[37] = "Gabriel";
            NomiMaschili[38] = "Hector";
            NomiMaschili[39] = "Humphrey";
            NomiMaschili[40] = "Gamel";
            NomiMaschili[41] = "Gregory";
            NomiMaschili[42] = "James";
            NomiMaschili[43] = "Jasper";
            NomiMaschili[44] = "Jeremy";
            NomiMaschili[45] = "Isaac";
            NomiMaschili[46] = "Ingram";
            NomiMaschili[47] = "Isembard";
            NomiMaschili[48] = "Manfred";
            NomiMaschili[49] = "Ives";
            NomiMaschili[50] = "William";
            NomiMaschili[51] = "Lucius";
            NomiMaschili[52] = "Wymond";
            NomiMaschili[53] = "Lambert";
            NomiMaschili[54] = "Blaise";
            NomiMaschili[55] = "Griffith";
            NomiMaschili[56] = "Mabon";
            NomiMaschili[57] = "Hubert";
            NomiMaschili[58] = "Gerald";
            NomiMaschili[59] = "Eustace";
            NomiMaschili[60] = "Adam";
            NomiMaschili[61] = "Adelard";
            NomiMaschili[62] = "Alphonse";
            NomiMaschili[63] = "Turstin";
            NomiMaschili[64] = "Guy";
            NomiMaschili[65] = "Peter";
            NomiMaschili[66] = "Osric";
            NomiMaschili[67] = "Ogier";
            NomiMaschili[68] = "Gareth";
            NomiMaschili[69] = "Maynard";

            NomiFemminili[0] = "Elaine";
            NomiFemminili[1] = "Sarah";
            NomiFemminili[2] = "Sela";
            NomiFemminili[3] = "Sigga";
            NomiFemminili[4] = "Susanna";
            NomiFemminili[5] = "Althea";
            NomiFemminili[6] = "Alma";
            NomiFemminili[7] = "Artemisia";
            NomiFemminili[8] = "Anne";
            NomiFemminili[9] = "Anais";
            NomiFemminili[10] = "Acelina";
            NomiFemminili[11] = "Aelina";
            NomiFemminili[12] = "Aldita";
            NomiFemminili[13] = "Audry";
            NomiFemminili[14] = "Augusta";
            NomiFemminili[15] = "Brangwine";
            NomiFemminili[16] = "Bridget";
            NomiFemminili[17] = "Genevieve";
            NomiFemminili[18] = "Guinevere";
            NomiFemminili[19] = "Catelin";
            NomiFemminili[20] = "Caterina";
            NomiFemminili[21] = "Dionisia";
            NomiFemminili[22] = "Mary";
            NomiFemminili[23] = "Martha";
            NomiFemminili[24] = "Elizabeth";
            NomiFemminili[25] = "Elysande";
            NomiFemminili[26] = "Christina";
            NomiFemminili[27] = "Giselle";
            NomiFemminili[28] = "Regina";
            NomiFemminili[29] = "Richolda";
            NomiFemminili[30] = "Roana";
            NomiFemminili[31] = "Barbetta";
            NomiFemminili[32] = "Bertha";
            NomiFemminili[33] = "Clare";
            NomiFemminili[34] = "Amelina";
            NomiFemminili[35] = "Cecily";
            NomiFemminili[36] = "Edith";
            NomiFemminili[37] = "Ella";
            NomiFemminili[38] = "Juliana";
            NomiFemminili[39] = "Ivette";
            NomiFemminili[40] = "Adelina";
            NomiFemminili[41] = "Agnes";
            NomiFemminili[42] = "Alice";
            NomiFemminili[43] = "Alyson";
            NomiFemminili[44] = "Dameta";
            NomiFemminili[45] = "Paulina";
            NomiFemminili[46] = "Petronilla";
            NomiFemminili[47] = "ElaEdevaine";
            NomiFemminili[48] = "Eglenti";
            NomiFemminili[49] = "Evelune";
            NomiFemminili[50] = "Emily";
            NomiFemminili[51] = "Emma";
            NomiFemminili[52] = "Joan";
            NomiFemminili[53] = "Johanna";
            NomiFemminili[54] = "Lavina";
            NomiFemminili[55] = "Lena";
            NomiFemminili[56] = "Lovota";
            NomiFemminili[57] = "Lillian";
            NomiFemminili[58] = "Maude";
            NomiFemminili[59] = "Milicent";
            NomiFemminili[60] = "Magdalen";
            NomiFemminili[61] = "Isabeau";
            NomiFemminili[62] = "Caesaria";
            NomiFemminili[63] = "Tephania";
            NomiFemminili[64] = "Sapphira";
            NomiFemminili[65] = "Ida";
            NomiFemminili[66] = "Rosamund";
            NomiFemminili[67] = "Leticia";
            NomiFemminili[68] = "Gwendolen";
            NomiFemminili[69] = "Legarda";

            Cognomi[0] = "Achard";
            Cognomi[1] = "Ashdown";
            Cognomi[2] = "Baker";
            Cognomi[3] = "Baxter";
            Cognomi[4] = "Burrel";
            Cognomi[5] = "Burrel";
            Cognomi[6] = "Carter";
            Cognomi[7] = "Bouchard";
            Cognomi[8] = "Ballard";
            Cognomi[9] = "Draper";
            Cognomi[10] = "Bigge";
            Cognomi[11] = "de Bethencourt";
            Cognomi[12] = "de Logris";
            Cognomi[13] = "de Maris";
            Cognomi[14] = "Challenge";
            Cognomi[15] = "Clarke";
            Cognomi[16] = "Cook";
            Cognomi[17] = "Fletcher";
            Cognomi[18] = "Bosc";
            Cognomi[19] = "Brooker";
            Cognomi[20] = "Browne";
            Cognomi[21] = "Brickenden";
            Cognomi[22] = "Cecil";
            Cognomi[23] = "Capron";
            Cognomi[24] = "Challener";
            Cognomi[25] = "Griffen";
            Cognomi[26] = "Canouville";
            Cognomi[27] = "Beringar";
            Cognomi[28] = "Bellecote";
            Cognomi[29] = "Bertran";
            Cognomi[30] = "Hachet";
            Cognomi[31] = "Carpenter";
            Cognomi[32] = "Cooper";
            Cognomi[33] = "Foreman";
            Cognomi[34] = "Hughes";
            Cognomi[35] = "Duval";
            Cognomi[36] = "Durville";
            Cognomi[37] = "de La Reue";
            Cognomi[38] = "Bauldry";
            Cognomi[39] = "Godart";
            Cognomi[40] = "Webber";
            Cognomi[41] = "Weaver";
            Cognomi[42] = "Faintrer";
            Cognomi[43] = "Renold";
            Cognomi[44] = "Hauville";
            Cognomi[45] = "Medley";
            Cognomi[46] = "Lucy";
            Cognomi[47] = "Lamb";
            Cognomi[48] = "Burroughs";
            Cognomi[49] = "Nesdin";
            Cognomi[50] = "Giffard";
            Cognomi[51] = "Becker";
            Cognomi[52] = "Paschal";
            Cognomi[53] = "Perroy";
            Cognomi[54] = "Lee";
            Cognomi[55] = "Brewer";
            Cognomi[56] = "Sawyer";
        }

        private void bottoneAccedi_Click(object sender, EventArgs e)
        {
            User = JsonConvert.DeserializeObject<Utente>(File.ReadAllText(String.Format(@"Login\\datilogin.json")));
            string hashDecritt = "cr1tt0gr4f1@";

            byte[] datiPasswordDec = Convert.FromBase64String(User.Password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] chiavi = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashDecritt));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = chiavi, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform convertitoreDecritto = tripDes.CreateDecryptor();
                    byte[] convertitoDecritto = convertitoreDecritto.TransformFinalBlock(datiPasswordDec, 0, datiPasswordDec.Length);
                    //prima si deserializza, poi si decodifica

                    User.Password = UTF8Encoding.UTF8.GetString(convertitoDecritto);
                }
            }
            if (contenitorePasswordLogin.Text == User.Password)
            {
                //si ricaricano i dati del programma
                //caricamento lista sudditi
                Lista.ListaSudditi = JsonConvert.DeserializeObject<List<Suddito>>(File.ReadAllText(String.Format(@"Saves\\ListSave.json")));

                //caricamento dati economici
                Contea = JsonConvert.DeserializeObject<Stato>(File.ReadAllText(String.Format(@"Saves\\EconomySave.json")));

                //caricamento dati clock
                Orologio= JsonConvert.DeserializeObject<Tempo>(File.ReadAllText(String.Format(@"Saves\\ClockSave.json")));

                MessageBox.Show("Il caricamento dei dati è avvenuto con successo!", "SUCCESSO", MessageBoxButtons.OK);

                //la password è corretta e corrisponde con quella salvata nella registrazione
                panelLogIn.Visible = false;
                pannelRegistrazione.Visible = false;
                PannelloAltoDX.Visible = true;
                PannelloAltoSX.Visible = true;
                PannelloBassoSX.Visible = true;
                PannelloBassoDX.Visible = true;
                AvantiMeseBtn.Visible = true;
                BtnSave.Visible = true;

            }
            else
            {
                MessageBox.Show("La password inserita non è corretta", "ERRORE DI AUTENTICAZIONE", MessageBoxButtons.OK);
            }
        }

        private void BottoneInvioRegistrazione_Click(object sender, EventArgs e)
        {
            //tempo registrazione
            Orologio.Mese = 1;
            Orologio.Anno = 0;

            bool passwordAccettata = false;
            char lettpass;
            int lettCAPS = 0;
            int lettNum = 0;
            if (string.IsNullOrWhiteSpace(contenitorePasswordInserita.Text) == false)
            {
                //facciamo che la password deve contenere almeno 1 numero e 1 lettera maiuscola
                for (int i = 0; i < contenitorePasswordInserita.TextLength; i++)
                {
                    //si preleva ogni singolo carattere dalla password
                    lettpass = Convert.ToChar(contenitorePasswordInserita.Text.Substring(i, 1));
                    if (Char.IsUpper(lettpass) == true)
                    {
                        lettCAPS++;
                    }
                    if (Char.IsDigit(lettpass) == true)
                    {
                        lettNum++;
                    }
                }
                if (lettCAPS >= 1 && lettNum >= 1)
                {
                    if (contenitorePasswordInserita.TextLength >= 8 & contenitorePasswordInserita.TextLength <= 16)
                    {
                        //allora la password va bene e viene salvata
                        User.Password = contenitorePasswordInserita.Text;
                        //la password va crittata, serializzata e messa in datilogin.json
                        string hashCritt = "cr1tt0gr4f1@";
                        byte[] datiPasswordEnc = UTF8Encoding.UTF8.GetBytes(User.Password);
                        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                        {
                            byte[] chiavi = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashCritt));
                            using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider() { Key = chiavi, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                            {
                                ICryptoTransform convertitoreCritto = tripDES.CreateEncryptor();
                                byte[] ConvertitoCritto = convertitoreCritto.TransformFinalBlock(datiPasswordEnc, 0, datiPasswordEnc.Length);
                                User.Password = Convert.ToBase64String(ConvertitoCritto, 0, ConvertitoCritto.Length);
                            }
                        }
                        //la password crittata viene serializzata
                        File.Create(@"Login\\datilogin.json").Close();
                        File.WriteAllText(@"Login\\datilogin.json", JsonConvert.SerializeObject(User, Formatting.Indented));
                        passwordAccettata = true;

                        pannelRegistrazione.Visible = false;
                        panelLogIn.Visible = false;
                        PannelloAltoDX.Visible = true;
                        PannelloAltoSX.Visible = true;
                        PannelloBassoSX.Visible = true;
                        PannelloBassoDX.Visible = true;
                        AvantiMeseBtn.Visible = true;
                        BtnSave.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("La password deve contenere tra gli 8 e i 16 caratteri", "ERRORE:", MessageBoxButtons.OK);
                        contenitorePasswordInserita.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("La password deve contenere almeno una lettera maiuscola e un numero", "ERRORE", MessageBoxButtons.OK);
                    contenitorePasswordInserita.Clear();
                }
            }
            else
            {
                MessageBox.Show("La password non può contenere spazi vuoti", "ERRORE", MessageBoxButtons.OK);

            }

            if (passwordAccettata == true)
            {

                //generazione degli abitanti alla prima registrazione
                Suddito NuovoSuddito;
                Random SceltaMestiere = new Random();
                Random SceltaNome = new Random();
                Random SceltaCognome = new Random();
                Random SceltaSesso = new Random();
                Random SceltaEtaLav = new Random();

                for (int i = 0; i < 3000; i++)
                {
                    NuovoSuddito = new Suddito();
                    if (SceltaSesso.Next(0, 1) == 1)
                    {
                        //scelta nome casuale maschile
                        int sceltanomeintM = SceltaNome.Next(0, 69);
                        NuovoSuddito.Nome = NomiMaschili[sceltanomeintM];
                    }
                    else
                    {
                        //scelta nome casuale femminile
                        int sceltanomeintF = SceltaNome.Next(0, 69);
                        NuovoSuddito.Nome = NomiFemminili[sceltanomeintF];

                    }
                    //scelta cognome casuale
                    int sceltacognomeint = SceltaCognome.Next(0, 55);
                    NuovoSuddito.Cognome = Cognomi[sceltacognomeint];

                    //età lavorativa?

                    int sceltaEtaLavint = SceltaEtaLav.Next(0, 100);
                    if (sceltaEtaLavint < 70)
                    {
                        //nuova nascita
                        NuovoSuddito.Etàlavorativa = false;
                    }
                    else
                    {
                        //immigrato
                        NuovoSuddito.Etàlavorativa = true;
                    }

                    int sceltamestiereint = SceltaMestiere.Next(0, 3);
                    //saldo basato sul mestiere
                    if (sceltamestiereint == 0)
                    {
                        NuovoSuddito.Mestiere = "Agricoltore";
                        NuovoSuddito.Saldo = 50;
                    }
                    else
                    {
                        if (sceltamestiereint == 1)
                        {
                            NuovoSuddito.Mestiere = "Fabbro";
                            NuovoSuddito.Saldo = 80;
                        }
                        else
                        {
                            if (sceltamestiereint == 2)
                            {
                                NuovoSuddito.Mestiere = "Guerriero";
                                NuovoSuddito.Saldo = 100;
                            }
                            else
                            {

                                NuovoSuddito.Mestiere = "Altro";
                                NuovoSuddito.Saldo = 50;
                            }
                        }
                    }
                    //inserimento abitante nella lista
                    Lista.ListaSudditi.Add(NuovoSuddito);


                }
                //serializzare listasudditi
                //quando si fa la registrazione si parte dall'anno 0
                Directory.CreateDirectory(@"Data\\0");
                Directory.CreateDirectory(@"Saves");
                File.Create(@"Data\\0\\1.json").Close();
                File.WriteAllText(String.Format(@"Data\\0\\1.json", Orologio.Anno, Orologio.Mese), JsonConvert.SerializeObject(Lista, Formatting.Indented));
            }
        }

        private void AvantiMeseBtn_Click(object sender, EventArgs e)
        {
            //si avanza di un mese, così i file sono salvati come mese Y nella cartella anno X
            Orologio.Mese++;
            if (Orologio.Mese == 12)
            {
                Orologio.Anno = Orologio.Anno + 1;
                Orologio.Mese = 1;
                //si resettano i 500 denari non tassabili
                for (int i = 0; i < Lista.ListaSudditi.Count(); i++)
                {
                    Lista.ListaSudditi[i].DenariSuddTassabile = 0;
                    Lista.ListaSudditi[i].Tassabile = false;
                }
            }

            //GESTIONE NASCITE
            //basta refresharli alla fine
            int SudditiTotali = Lista.ListaSudditi.Count();
            int SudditiLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == true).Count();
            int SudditiNonLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == false).Count();
            int SudditiInsolventi = 0; //si aggiungono dopo il conto dele tasse
            int SudditiNuovi = 0;
            int SudditiMorti = 0;
            //nascite
            SudditiNuovi = (int)Math.Round(SudditiTotali * 0.08, 0);
            //morti
            SudditiMorti = (int)Math.Round(SudditiTotali * 0.05, 0);

            //VARIABILI TASSAZIONE
            float TassazioneTotale = 0;
            float IntroitiPrevisti = 0;
            float IntroitiPersi = 0;

            Suddito NuovoSuddito;

            //GENERARE I NATI & IMMIGRATI
            for (int i = 0; i < SudditiNuovi; i++)
            {
                Random CaratteristicheNati = new Random();
                NuovoSuddito = new Suddito();
                if (CaratteristicheNati.Next(0, 1) == 1)
                {
                    //scelta nome casuale maschile
                    int sceltanomeintM = CaratteristicheNati.Next(0, 69);
                    NuovoSuddito.Nome = NomiMaschili[sceltanomeintM];
                }
                else
                {
                    //scelta nome casuale femminile
                    int sceltanomeintF = CaratteristicheNati.Next(0, 69);
                    NuovoSuddito.Nome = NomiFemminili[sceltanomeintF];

                }
                //scelta cognome casuale
                int sceltacognomeint = CaratteristicheNati.Next(0, 55);
                NuovoSuddito.Cognome = Cognomi[sceltacognomeint];

                //età lavorativa?

                int sceltaEtaLavint = CaratteristicheNati.Next(0, 100);
                if (sceltaEtaLavint < 70)
                {
                    //nuova nascita
                    NuovoSuddito.Etàlavorativa = false;
                }
                else
                {
                    //immigrato
                    NuovoSuddito.Etàlavorativa = true;
                }

                int sceltamestiereint = CaratteristicheNati.Next(0, 3);
                //saldo basato sul mestiere
                if (sceltamestiereint == 0)
                {
                    NuovoSuddito.Mestiere = "Agricoltore";
                    NuovoSuddito.Saldo = 50;
                }
                else
                {
                    if (sceltamestiereint == 1)
                    {
                        NuovoSuddito.Mestiere = "Fabbro";
                        NuovoSuddito.Saldo = 80;
                    }
                    else
                    {
                        if (sceltamestiereint == 2)
                        {
                            NuovoSuddito.Mestiere = "Guerriero";
                            NuovoSuddito.Saldo = 100;
                        }
                        else
                        {

                            NuovoSuddito.Mestiere = "Altro";
                            NuovoSuddito.Saldo = 50;
                        }
                    }
                }
                //inserimento abitante nella lista
                Lista.ListaSudditi.Add(NuovoSuddito);


            }
            //MORTE
            Random SudditoMorto;
            //viene creato un random che prende a caso un indice della listasudditi 
            //(viene ripetuto tante volte quanti sono i morti) e tale persona con indice X viene tolta dalla lista
            for (int i = 0; i < SudditiMorti; i++)
            {
                SudditoMorto = new Random();
                int IndiceListaMorto = SudditoMorto.Next(0, Lista.ListaSudditi.Count());
                Lista.ListaSudditi.RemoveAt(IndiceListaMorto);
            }
            //si serializza alla fine
            //il 20% di coloro che non lavorano diventano lavoratori ogni anno (stima)
            //bisogna cambiare lo stato delle persone nella lista
            int Apprendisti;

            int NumeroNonLav = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == false).Count();
            Apprendisti = (int)Math.Round(NumeroNonLav * 0.2, 0);

            List<int> ListaNonLav = new List<int>();
            //mettere indici di persone non lav in nuova lista con stessi indici
            for (int i = 0; i < Lista.ListaSudditi.Count(); i++)
            {
                if (Lista.ListaSudditi[i].Etàlavorativa == false)
                 {
                    ListaNonLav.Add(i);
                 }
            }
            Random SceltaApprendista = new Random();
            for (int i = 0; i < Apprendisti; i++)
            {
                //scelgo a caso un tizio nella lista dei non lavoratori
                int IndiceSceltaApp = SceltaApprendista.Next(0, ListaNonLav.Count()-1);

                //della lista dei sudditi, prendo il valore di indice IndicesceltaApp nella lista di quelli non lavoratori
                Lista.ListaSudditi[ListaNonLav[IndiceSceltaApp]].Etàlavorativa = true;

                ListaNonLav.RemoveAt(IndiceSceltaApp);
            }



            SudditiNonLavoratori = SudditiNonLavoratori - Apprendisti;
            SudditiLavoratori = SudditiLavoratori + Apprendisti;

            //i sudditi non lavoratori non sono tassabili

            //STIPENDI & TASSE
            for (int i = 0; i < Lista.ListaSudditi.Count(); i++)
            {
                //controllo se tassabile, i mestieri li hanno dalla nascita, la differenza sta nel fatto
                //gli stipendi vanno dati se sono lavoratori
                if (Lista.ListaSudditi[i].Etàlavorativa == true)
                {
                    //in base al mestiere si assegna lo stipendio
                    switch (Lista.ListaSudditi[i].Mestiere)
                    {
                        case "Agricoltore":
                            //stipendio
                            Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo + 300;
                            //controllo se sono i prmi 500 denari dell'anno non tassabili
                            if (Lista.ListaSudditi[i].DenariSuddTassabile < 500)
                            {
                                Lista.ListaSudditi[i].DenariSuddTassabile = Lista.ListaSudditi[i].DenariSuddTassabile + 300;
                            }
                            else
                                Lista.ListaSudditi[i].Tassabile = true;

                            break;

                        case "Fabbro":
                            Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo + 400;
                            if (Lista.ListaSudditi[i].DenariSuddTassabile < 500)
                            {
                                Lista.ListaSudditi[i].DenariSuddTassabile = Lista.ListaSudditi[i].DenariSuddTassabile + 300;
                            }
                            else
                                Lista.ListaSudditi[i].Tassabile = true;
                            break;
                        case "Guerriero":
                            Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo + 450;
                            if (Lista.ListaSudditi[i].DenariSuddTassabile < 500)
                            {
                                Lista.ListaSudditi[i].DenariSuddTassabile = Lista.ListaSudditi[i].DenariSuddTassabile + 300;
                            }
                            else
                                Lista.ListaSudditi[i].Tassabile = true;
                            break;

                        case "Altro":
                            Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo + 300;
                            if (Lista.ListaSudditi[i].DenariSuddTassabile < 500)
                            {
                                Lista.ListaSudditi[i].DenariSuddTassabile = Lista.ListaSudditi[i].DenariSuddTassabile + 300;
                            }
                            else
                                Lista.ListaSudditi[i].Tassabile = true;
                            break;
                    }
                    //TASSAZIONE
                    //tassabile significa che ha già ricevuto i 500 denari non tassabili annui
                    if (Lista.ListaSudditi[i].Tassabile == true)
                    {
                        //Si assegnano le tasse da pagare come "tasseNonPagate"
                        Lista.ListaSudditi[i].TasseNonPagate = Lista.ListaSudditi[i].TasseNonPagate + Lista.ListaSudditi[i].Saldo * (float)0.15;
                        //spese random del suddito per variati motivi( cibo, alloggio, ecc)
                        Random SpeseAbitante = new Random();
                        int SpeseAbitanteint = SpeseAbitante.Next(0, 3);
                        //le spese esterne non rientrano nelle tasse non pagate, e vengono sottratte subito
                        switch (SpeseAbitanteint)
                        {
                            case 0:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 20;
                                break;
                            case 1:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 50;
                                break;
                            case 2:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 60;
                                break;
                            case 3:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 80;
                                break;
                            case 4:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 90;
                                break;
                            case 5:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 120;
                                break;
                            case 6:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 150;
                                break;
                            case 7:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 250;
                                break;
                            case 8:
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - 400;
                                break;

                        }
                        //si controlla se il suddito ha abbastanza denaro per pagare TASSE
                        if (Lista.ListaSudditi[i].Saldo - Lista.ListaSudditi[i].TasseNonPagate < 0)
                        {
                            //non ha abbastanza soldi, le tasse non pagate rimangono
                            //gli si da la possibilità di pagare il 30% del debito ogni emse
                            if (Lista.ListaSudditi[i].Saldo - Lista.ListaSudditi[i].TasseNonPagate * (float)0.3 < 0)
                            {
                                // se non riesce a pagare nemmeno il 30% aumentano i mesi in cui non ha pagato  e le tasse non pagate rimangono
                                Lista.ListaSudditi[i].MesiNonPagati++;
                            }
                            else
                            {
                                float tassazioneParzialePagata;
                                //può pagarne il 30%
                                Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - Lista.ListaSudditi[i].TasseNonPagate * (float)0.3;
                                //viene calcolato il profitto della contea
                                tassazioneParzialePagata = Lista.ListaSudditi[i].TasseNonPagate * (float)0.3;
                                //viene tolto il 30% del debito
                                Lista.ListaSudditi[i].TasseNonPagate = Lista.ListaSudditi[i].TasseNonPagate - tassazioneParzialePagata;
                                //i mesi in cui non viene pagato TUTTO il debito continuano
                                Lista.ListaSudditi[i].MesiNonPagati++;
                                //incasso della contea
                                TassazioneTotale = TassazioneTotale + tassazioneParzialePagata;
                            }

                        }
                        else
                        {
                            //è riuscito a pagare tutto in un colpo e non ha debiti
                            float tassazioneCompletaPagata = Lista.ListaSudditi[i].TasseNonPagate;

                            Lista.ListaSudditi[i].Saldo = Lista.ListaSudditi[i].Saldo - Lista.ListaSudditi[i].TasseNonPagate;
                            Lista.ListaSudditi[i].TasseNonPagate = 0;
                            //il numero di mesi non pagati si resetta, dato che ha estinto tutti i debiti
                            Lista.ListaSudditi[i].MesiNonPagati = 0;
                            //la contea incassa le tasse
                            TassazioneTotale = TassazioneTotale + tassazioneCompletaPagata;

                        }
                        //si aggiunge un interesse del 30% nel caso che non abbia pagato le tasse per 12 o 24 mesi
                        if (Lista.ListaSudditi[i].MesiNonPagati == 12 || Lista.ListaSudditi[i].MesiNonPagati == 24)
                        {
                            Lista.ListaSudditi[i].TasseNonPagate = Lista.ListaSudditi[i].TasseNonPagate + (int)Math.Round(Lista.ListaSudditi[i].TasseNonPagate * 0.3, 0);
                        }
                        // se non è riuscito a pagare i debiti entro 36 mesi
                        else
                        {
                            if (Lista.ListaSudditi[i].MesiNonPagati == 36)
                            {
                                //il suddito viene ucciso
                                SudditiInsolventi++;
                                SudditiMorti++;
                                //viene tolto dalla lista degli abitanti
                                Lista.ListaSudditi.Remove(Lista.ListaSudditi[i]);

                            }
                        }
                    }

                }
            }
            // CALCOLO INTROITI DELLO STATO
            //alla fine del ciclo che assegna stipendi e fa pagare i tributi, si calcola il resoconto della contea
            //il 95% delle tasse prelevate vanno usate per pagare l'amministrazione dello stato, se ne prendono il 5%
            TassazioneTotale = TassazioneTotale * (float)0.05;
            //40% al re, 60% allo stato
            Contea.SaldoRe = Contea.SaldoRe+TassazioneTotale * (float)0.4;
            Contea.TesoroStato = Contea.TesoroStato+TassazioneTotale * (float)0.6;


            //calcolo della tassazione ideale
            //gli introiti statali previsti sarebbero il 15% del saldo di ognuno, dato che le tasse sono uguali per tutti
            for (int i = 0; i < Lista.ListaSudditi.Count(); i++)
            {
                //per evitare divisioni con zeri, si contano solo gli introiti da chi ha qualcosa
                if (Lista.ListaSudditi[i].Saldo != 0)
                {
                    IntroitiPrevisti = IntroitiPrevisti + Lista.ListaSudditi[i].Saldo * (float)0.15;
                }
            }

            IntroitiPersi = IntroitiPrevisti - TassazioneTotale;

            //refresh di alcune variabili di conteggio
            SudditiTotali = Lista.ListaSudditi.Count();
            SudditiLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == true).Count();
            SudditiNonLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == false).Count();
           

            //refresh dei dati in output nell' UI

            labelNumeroSudditi.Text = SudditiTotali.ToString();
            labelNumeroLavoratori.Text = SudditiLavoratori.ToString();
            labelNumeroSudditiNonLavoratori.Text = SudditiNonLavoratori.ToString();
            labelNumeroInsolventi.Text = SudditiInsolventi.ToString();
            labelNumeroNati.Text = SudditiNuovi.ToString();
            labelNumeroMorti.Text = SudditiMorti.ToString();

            //arrotondamento al centesimo delle monete
            LabelNumeroSoldiCorona.Text = Contea.SaldoRe.ToString("0.00") + "£";
            LabelNumeroSoldiStato.Text = Contea.TesoroStato.ToString("0.00") + "£";

            LabelNumeroIntroitiMensili.Text = TassazioneTotale.ToString("0.00") + "£";
            LabelNumeroIntroitiIdeali.Text = IntroitiPrevisti.ToString("0.00") + "£";
            LabelNumeroIntroitiPersi.Text = IntroitiPersi.ToString("0.00") + "£";

            //CATASTROFI
            Random RdmCatastrofe = new Random();
            int ChanceCat = RdmCatastrofe.Next(0, 50);
            switch (ChanceCat)
            {
                //pestilenza
                case 1:
                    MessageBox.Show("E'sopraggiunta un'epidemia!", "!", MessageBoxButtons.OK);
                    //95% tesoro stato usato, rimane il 5%
                    Contea.TesoroStato = Contea.TesoroStato * (float)0.05;
                    //il saldo del re viene portato a 0 per spese di incastellamento
                    Contea.SaldoRe = 0;
                    //il 50% della popolazione muore
                    int mortiPestilenza = (int)Math.Round(Lista.ListaSudditi.Count() * 0.5, 0);
                    for (int i = 0; i < mortiPestilenza; i++)
                    {
                        Lista.ListaSudditi.RemoveAt(0);
                    }
                    //refresh di alcune variabili di conteggio
                    SudditiTotali = Lista.ListaSudditi.Count();
                    SudditiLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == true).Count();
                    SudditiNonLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == false).Count();


                    //refresh dei dati in output nell' UI

                    labelNumeroSudditi.Text = SudditiTotali.ToString();
                    labelNumeroLavoratori.Text = SudditiLavoratori.ToString();
                    labelNumeroSudditiNonLavoratori.Text = SudditiNonLavoratori.ToString();
                    labelNumeroInsolventi.Text = SudditiInsolventi.ToString();
                    labelNumeroNati.Text = SudditiNuovi.ToString();
                    labelNumeroMorti.Text = SudditiMorti.ToString();
                    break;

                case 2 | 3 | 4 | 5:
                    //incursione nemica
                    MessageBox.Show("E'avvenuta un'incursione nemica!", "!", MessageBoxButtons.OK);
                    //80% del tesoro delo stato viene usato, rimane 20%
                    Contea.TesoroStato = Contea.TesoroStato * (float)0.2;
                    //70% del tesoro del re  viene usato
                    Contea.SaldoRe = Contea.SaldoRe * (float)0.3;
                    //il 30% della popolazione muore
                    int mortiAssalto = (int)Math.Round(Lista.ListaSudditi.Count() * 0.3, 0);
                    for (int i = 0; i < mortiAssalto; i++)
                    {
                        Lista.ListaSudditi.RemoveAt(0);
                    }
                    //refresh di alcune variabili di conteggio
                    SudditiTotali = Lista.ListaSudditi.Count();
                    SudditiLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == true).Count();
                    SudditiNonLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == false).Count();


                    //refresh dei dati in output nell' UI

                    labelNumeroSudditi.Text = SudditiTotali.ToString();
                    labelNumeroLavoratori.Text = SudditiLavoratori.ToString();
                    labelNumeroSudditiNonLavoratori.Text = SudditiNonLavoratori.ToString();
                    labelNumeroInsolventi.Text = SudditiInsolventi.ToString();
                    labelNumeroNati.Text = SudditiNuovi.ToString();
                    labelNumeroMorti.Text = SudditiMorti.ToString();
                    break;

                case 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13:
                    //inondazione
                    MessageBox.Show("La contea è stata inondata dal fiume esondato!", "!", MessageBoxButtons.OK);
                    //50% del tesoro delo stato viene usato
                    Contea.TesoroStato = Contea.TesoroStato * (float)0.5;
                    //il 15% della popolazione muore
                    int mortiIndondazione = (int)Math.Round(Lista.ListaSudditi.Count()* 0.15, 0);
                    for (int i = 0; i < mortiIndondazione; i++)
                    {
                        Lista.ListaSudditi.RemoveAt(0);
                    }
                    //refresh di alcune variabili di conteggio
                    SudditiTotali = Lista.ListaSudditi.Count();
                    SudditiLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == true).Count();
                    SudditiNonLavoratori = Lista.ListaSudditi.FindAll(X => X.Etàlavorativa == false).Count();


                    //refresh dei dati in output nell' UI

                    labelNumeroSudditi.Text = SudditiTotali.ToString();
                    labelNumeroLavoratori.Text = SudditiLavoratori.ToString();
                    labelNumeroSudditiNonLavoratori.Text = SudditiNonLavoratori.ToString();
                    labelNumeroInsolventi.Text = SudditiInsolventi.ToString();
                    labelNumeroNati.Text = SudditiNuovi.ToString();
                    labelNumeroMorti.Text = SudditiMorti.ToString();
                    break;
            }



            //Serializzazione dati nuovi
            //i dati vengono serializzati e salvati in base al mese e all'anno
            //se anno=0 non serve ricreare la cartella, è quella generata dalla registrazione
            if (Orologio.Anno != 0)
            {
                Directory.CreateDirectory(String.Format(@"Data\\{0}", Orologio.Anno));
            }
            File.Create(String.Format(@"Data\\{0}\\{1}.json", Orologio.Anno, Orologio.Mese)).Close();
            File.WriteAllText(String.Format(@"Data\\{0}\\{1}.json", Orologio.Anno, Orologio.Mese), JsonConvert.SerializeObject(Lista, Formatting.Indented));


            //dopo la serializzaizone le var si resettano
            IntroitiPersi = 0;
            IntroitiPrevisti = 0;
            TassazioneTotale = 0;
            SudditiMorti = 0;
            SudditiNuovi = 0;
            SudditiInsolventi = 0;
            SudditiTotali = 0;
            SudditiLavoratori = 0;
            SudditiNonLavoratori = 0;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //tutti i dati vengono salvati in 3 json
            //si disattiva il pulsante + mese così che non ci siano problemi durante il salvataggio
            AvantiMeseBtn.Enabled = false;
            File.Create(@"Saves\\ListSave.json").Close();
            //serializzazione lista abitanti
            File.WriteAllText(String.Format(@"Saves\\ListSave.json"), JsonConvert.SerializeObject(Lista.ListaSudditi, Formatting.Indented));
            //salvataggio dei dati economici
            File.Create(@"Saves\\EconomySave.json").Close();
            File.WriteAllText(String.Format(@"Saves\\EconomySave.json"), JsonConvert.SerializeObject(Contea, Formatting.Indented));
            //salvataggio del tempo
            File.Create(@"Saves\\ClockSave.json").Close();
            File.WriteAllText(String.Format(@"Saves\\ClockSave.json"), JsonConvert.SerializeObject(Orologio, Formatting.Indented));

            MessageBox.Show("Il salvataggio è avvenuto con successo!", "SUCCESSO", MessageBoxButtons.OK);

            //una volta finite le operazioni, il pulsante avanti mese ritorna attivo
            AvantiMeseBtn.Enabled = true;
        }
    }
}

public class Liste
{
    public List<Suddito> ListaSudditi = new List<Suddito>();
}
//creazione classi
public class Suddito
{
    protected string nome;
    protected string cognome;
    protected bool etàlavorativa; //si o no
    protected float saldo; //float al posto di double perché occupa 32 bit e non 64
    protected string mestiere;  //anche se non in età lavorativa, nella casta medievale il figlio sapeva già che avrebbe svolto il mestiere del padre
    protected int mesiNonPagati;
    protected float tasseNonPagate;
    protected int denariSuddTassabile;
    protected bool tassabile;

    public string Nome
    {
        set { nome = value; }
        get { return nome; }
    }
    public string Cognome
    {
        set { cognome = value; }
        get { return cognome; }
    }
    public bool Etàlavorativa
    {
        set { etàlavorativa = value; }
        get { return etàlavorativa; }
    }
    public float Saldo
    {
        set { saldo = value; }
        get { return saldo; }
    }
    public string Mestiere
    {
        set { mestiere = value; }
        get { return mestiere; }
    }
    public int MesiNonPagati
    {
        set { mesiNonPagati = value; }
        get { return mesiNonPagati; }
    }
    public float TasseNonPagate
    {
        set { tasseNonPagate = value; }
        get { return tasseNonPagate; }
    }
    public int DenariSuddTassabile
    {
        set { denariSuddTassabile = value; }
        get { return denariSuddTassabile; }
    }
    public bool Tassabile
    {
        set { tassabile = value; }
        get { return tassabile; }
    }
}
public class Tempo
{
    protected int mese;
    protected int anno;

    public int Mese
    {
        set { mese = value; }
        get { return mese; }
    }
    public int Anno
    {
        set { anno = value; }
        get { return anno; }
    }
}
public class Stato
{
    protected float saldoRE;
    protected float tesoroStato;

    public float SaldoRe
    {
        set { saldoRE = value; }
        get { return saldoRE; }
    }
    public float TesoroStato
    {
        set { tesoroStato = value; }
        get { return tesoroStato; }
    }
}
public class Utente
{
    protected string password;
    public string Password
    {
        set { password = value; }
        get { return password; }
    }
}