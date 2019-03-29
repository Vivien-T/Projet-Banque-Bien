using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBanque
{
    public partial class FormAccueil : Form
    {

        public DateTime datetest;
        public LivretA test1livret;
        public Client test1;
        public CompteCourant test1compte;
        public List<Client> listeClients = new List<Client>();
        public List<LivretA> listeLivrets = new List<LivretA>();
        public List<CompteCourant> listeComptes = new List<CompteCourant>();
        public int open = 0;
        public Client clientactuel;
        public CompteCourant comptecourantactuel;
        public LivretA livretactuel;

        public FormAccueil()
        {
            datetest = new DateTime(2000, 04, 20);
            test1 = new Client(0, "test", "ostérone", datetest, "852 Avenue de test", "34000", "Montpellier", "0671973276", "test@google.fr", "abcd");
            test1livret = new LivretA(0, false, test1.getNom(), test1.getPrenom());
            test1compte = new CompteCourant(0, false, test1.getNom(), test1.getNom());
            listeClients.Add(test1);
            listeComptes.Add(test1compte);
            listeLivrets.Add(test1livret);
            InitializeComponent();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            FormConnexion formclient = new FormConnexion(listeClients, listeComptes, listeLivrets, this);
            switch (formclient.ShowDialog())
            {
                case DialogResult.OK:
                    clientactuel = formclient.GetClient();
                    if (clientactuel == null)
                    {
                        break;
                    }
                    foreach (CompteCourant compte in listeComptes)
                    {
                        if(compte.IdCompte == clientactuel.getId())
                        {
                            soldecompte_Write(compte.Solde);
                            comptecourantactuel = compte;
                        }
                    }
                    foreach(LivretA livret in listeLivrets)
                    {
                        if(livret.IdCompte == clientactuel.getId())
                        {
                            soldelivret_Write(livret.Solde);
                            livretactuel = livret;
                        }
                    }
                    message_accueil_Write(clientactuel.getNom(), clientactuel.getPrenom());
                    break;

                case DialogResult.Yes:
                    clientactuel = formclient.GetClient();
                    if (clientactuel == null)
                    {
                        break;
                    }
                    listeComptes = formclient.GetlisteCompteCourant();
                    listeLivrets = formclient.GetListeLivrets();
                    foreach (CompteCourant compte in listeComptes)
                    {
                        if (compte.IdCompte == clientactuel.getId())
                        {
                            soldecompte_Write(compte.Solde);
                            comptecourantactuel = compte;
                        }
                    }
                    foreach (LivretA livret in listeLivrets)
                    {
                        if (livret.IdCompte == clientactuel.getId())
                        {
                            soldelivret_Write(livret.Solde);
                            livretactuel = livret;
                        }
                    }
                    message_accueil_Write(clientactuel.getNom(), clientactuel.getPrenom());
                    break;
            }
            
        }

        public void soldecompte_Write(double solde)
        {
            string soldetext = solde.ToString();
            this.soldecompte.Text = soldetext;
        }

        public void message_accueil_Write(string nom, string prenom)
        {
            this.message_accueil.Text = ("Bonjour Mr. "+ nom +" "+ prenom + " !");
        }

        private void soldelivret_Write(double solde)
        {
            string soldetext = solde.ToString();
            this.soldelivret.Text = soldetext;
        }

        private void send_Click(object sender, EventArgs e)
        {
            FormOperation operation = new FormOperation("send",comptecourantactuel, livretactuel, clientactuel);
            operation.ShowDialog();
        }

        private void ask_Click(object sender, EventArgs e)
        {
            FormOperation operation = new FormOperation("ask", comptecourantactuel, livretactuel, clientactuel);
            operation.ShowDialog();
        }
    }
}
