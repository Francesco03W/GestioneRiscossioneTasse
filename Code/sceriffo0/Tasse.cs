//INFORMAZIONI IMPORTANTI DA NON TOCCARE:
/*
 if you use the hash (outdated md5) of a secret string (too short to be secure) to encrypt the password there is no point in hashing the secret here I think
 tripleDES is also deprecated
 storing secrets in code is security issue, but I think it's a practice program so it's no big deal (?))
*/

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

//https://www.youtube.com/watch?v=5Anto1N_FSs
namespace sceriffo0
{
    public partial class Tasse1 : Form
    {
        // DA FINIRE *non toccare*:
        // mettere l'inserimento della password con il pulsante "accedi" e controllare che sia uguale a quella già impostata nell'User.Password

        Utente User = new Utente(); // - ok
        Utente Userload = new Utente(); //test, non badateci

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
            if (Directory.Exists(@"Login") == true)
            {
                //deserializzazione del file 
                panelLogIn.Visible = true;
                User = JsonConvert.DeserializeObject<Utente>(File.ReadAllText(String.Format(@"Login\\datilogin.json")));
                //la password viene decrittata secondo lo stesso hash con cui è stata crittata
                string hashDecritt = "cr1tt0gr4f1@";

                byte[] datiPasswordDec = Convert.FromBase64String(User.Password);
                using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
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

        }

        private void bottoneAccedi_Click(object sender, EventArgs e)
        {
            panelLogIn.Visible = false;
            

        }

        private void BottoneInvioRegistrazione_Click(object sender, EventArgs e)
        {
            char lettpass;
            int lettCAPS=0;
            int lettNum=0;
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
                        File.WriteAllText(@"Login\\datilogin.json", JsonConvert.SerializeObject(User,Formatting.Indented));


                        pannelRegistrazione.Visible = false;
                        PannelloAltoDX.Visible = true;
                        PannelloAltoSX.Visible = true;
                        PannelloBassoSX.Visible = true;
                        PannelloBassoDX.Visible = true;

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
        }
    }
}
//creazione classi
public class Suddito
{
    protected string nome;
    protected string cognome;
    protected string etàlavorativa; //si o no
    protected float saldo; //float al posto di double perché occupa 32 bit e non 64
    protected string mestiere;  //anche se non in età lavorativa, nella casta medievale il figlio sapeva già che avrebbe svolto il mestiere del padre
    protected int mesiNonPagati;
    protected float tasseNonPagate;
    protected int denariSuddTassabile;

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
    public string Etàlavorativa
    {
        set { etàlavorativa =value; }
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
    protected string condizioneStato;

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
    public string CondizioneStato
    {
        set { condizioneStato = value; }
        get { return condizioneStato; }
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