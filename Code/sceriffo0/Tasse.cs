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



//https://www.youtube.com/watch?v=5Anto1N_FSs
namespace sceriffo0
{
    public partial class Tasse1 : Form
    {
        //Ho aggiunto 4 pannelli coi nomi adatti, lì fate tutto
        //ho aggiunto le classi
        //
        public Tasse1()
        {
            InitializeComponent();
            Utente User = new Utente();
        }

        //quando si clicca su "registrati" la password questo è il controllo:
        //va messo dentro il metodo "registrati_click" che creerete, questo qua sotto è temporaneo
        
        private void ClickSuRegistrati(object sender,EventArgs e)
        {
            //controllo se la cartella c'è già
            if (Directory.Exists(@"Login") == true)
            {
                //deserializzazione del file 
            }
            else
            {
                Directory.CreateDirectory(@"Login");
                //qui bisogna controllare che la password sia tra 8 e 16 caratteri
                /*
                if(*textbox*.Text<8 ||=.*textbox*.Text > 16)
                {
                 User.Password =.*textbox*.Text
                //se è inserita correttamente, si disattiva il pannello e si entra nel programma
                 pannelloLogIn.Visible=false;
                 //serializzazione
                }
                else
                {
                MessageBox.Show("La password deve contenere tra gli 8 e i 16 caratteri", "ERRORE:", MessageBoxButtons.OK);
                }
                */

            }
        }




        private void Tasse1_Load(object sender, EventArgs e)
        {

            //listPanel.Add(panelLogIn);
            panelLogIn.Visible = true;

        }

        private void bottoneAccedi_Click(object sender, EventArgs e)
        {
            panelLogIn.Visible = false;
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