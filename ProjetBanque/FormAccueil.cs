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
        public Client admin;
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
            admin = new Client(0, "admin", "admin");
            listeClients.Add(admin);
            test1 = new Client(1, "test", "ostérone", datetest, "852 Avenue de test", "34000", "Montpellier", "0671973276", "test@google.fr", "abcd");
            test1livret = new LivretA(1, false, test1.getNom(), test1.getPrenom());
            test1compte = new CompteCourant(1, false, test1.getNom(), test1.getNom());
            listeClients.Add(test1);

            Client test2 = new Client(2, "amphé", "tamine", datetest, "48 rue de l'essai", "34000", "Montpellier", "0659086850", "damn@boy.fr", "password");
            LivretA test2livret = new LivretA(1, false, test2.getNom(), test2.getPrenom());
            CompteCourant test2compte = new CompteCourant(1, false, test2.getNom(), test2.getNom());

            Client test3 = new Client(3, "damn", "boy", datetest, "73 boulevard des tests", "34000", "Montpellier", "0649634829", "lucasPD@vivienBG.fr", "password");
            LivretA test3livret = new LivretA(1, false, test3.getNom(), test3.getPrenom());
            CompteCourant test3compte = new CompteCourant(1, false, test3.getNom(), test3.getNom());

            Client test4 = new Client(2, "whatthefuck", "bro", datetest, "95 Impasse des Cons", "34000", "Montpellier", "0659364852", "tinoPD@vivienBG.fr", "password");
            LivretA test4livret = new LivretA(1, false, test4.getNom(), test4.getPrenom());
            CompteCourant test4compte = new CompteCourant(1, false, test4.getNom(), test4.getNom());

            listeClients.Add(test2);
            listeClients.Add(test3);
            listeClients.Add(test4);

            listeComptes.Add(test1compte);
            listeLivrets.Add(test1livret);

            listeComptes.Add(test2compte);
            listeLivrets.Add(test2livret);

            listeComptes.Add(test3compte);
            listeLivrets.Add(test3livret);

            listeComptes.Add(test4compte);
            listeLivrets.Add(test4livret);

            InitializeComponent();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            FormConnexion formclient = new FormConnexion(listeClients, listeComptes, listeLivrets, this);
            switch (formclient.ShowDialog())
            {
                case DialogResult.OK:
                    clientactuel = formclient.GetClient();
                    if (clientactuel.getTelephone() == "admin")
                    {
                        Formgestion formgest = new Formgestion(listeClients, listeComptes, listeLivrets);
                        formgest.ShowDialog();
                        message_accueil_Write("admin","admin");
                        double soldetotal = 0;
                        foreach(CompteCourant compte in listeComptes)
                        {
                            soldetotal = soldetotal + compte.Solde;
                        }
                        soldecompte_Write(soldetotal);
                        soldetotal = 0;
                        foreach(LivretA livret in listeLivrets)
                        {
                            soldetotal = soldetotal + livret.Solde;
                        }
                        soldelivret_Write(soldetotal);
                        this.soldecomptemsg.Text = "Voici la somme présente sur tous \n les comptes en euros";
                        this.soldelivretmsg.Text = "Voici la somme présente sur tous \n les livrets en euros";
                        this.send.Hide();
                        this.ask.Hide();
                        this.gestion.Show();
                        break;
                    }
                    else if (clientactuel == null)
                    {
                        break;
                    }
                    else
                    {
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
                        this.gestion.Hide();
                        this.ask.Show();
                        this.send.Show();
                        break;
                    }
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
                    this.gestion.Hide();
                    this.send.Show();
                    this.ask.Show();
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
            if(nom == "admin" && prenom == "admin")
            {
                this.message_accueil.Text = ("Bienvenue sur la page de gestion Administrateur");
            }
            else
            {
                this.message_accueil.Text = ("Bonjour Mr. " + nom + " " + prenom + " !");
            }
        }

        private void soldelivret_Write(double solde)
        {
            string soldetext = solde.ToString();
            this.soldelivret.Text = soldetext;
        }

        private void send_Click(object sender, EventArgs e)
        {
            FormOperation operation = new FormOperation("send",comptecourantactuel, livretactuel, clientactuel);
            switch (operation.ShowDialog())
            {
                case DialogResult.Yes:
                    comptecourantactuel = operation.GetCompte();
                    soldecompte_Write(comptecourantactuel.Solde);
                    break;

                case DialogResult.OK:
                    livretactuel = operation.GetLivret();
                    soldelivret_Write(livretactuel.Solde);
                    break;
            }
        }

        private void ask_Click(object sender, EventArgs e)
        {
            FormOperation operation = new FormOperation("ask", comptecourantactuel, livretactuel, clientactuel);
            switch (operation.ShowDialog())
            {
                case DialogResult.Yes:
                    comptecourantactuel = operation.GetCompte();
                    soldecompte_Write(comptecourantactuel.Solde);
                    break;

                case DialogResult.OK:
                    livretactuel = operation.GetLivret();
                    soldelivret_Write(livretactuel.Solde);
                    break;
            }
        }

        private void gestion_Click(object sender, EventArgs e)
        {
            Formgestion gestion = new Formgestion(listeClients, listeComptes, listeLivrets);
            switch (gestion.ShowDialog())
            {
                case DialogResult.Abort:
                    listeClients = gestion.GetListeClients();
                    listeComptes = gestion.GetListeComptes();
                    listeLivrets = gestion.GetListelivrets();
                    break;
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes-vous sûr de vouloir vous déconnecter ?","Attention",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                FormConnexion formclient = new FormConnexion(listeClients, listeComptes, listeLivrets, this);
                switch (formclient.ShowDialog())
                {
                    case DialogResult.OK:
                        clientactuel = formclient.GetClient();
                        if (clientactuel.getTelephone() == "admin")
                        {
                            Formgestion formgest = new Formgestion(listeClients, listeComptes, listeLivrets);
                            formgest.ShowDialog();
                            message_accueil_Write("admin", "admin");
                            double soldetotal = 0;
                            foreach (CompteCourant compte in listeComptes)
                            {
                                soldetotal = soldetotal + compte.Solde;
                            }
                            soldecompte_Write(soldetotal);
                            soldetotal = 0;
                            foreach (LivretA livret in listeLivrets)
                            {
                                soldetotal = soldetotal + livret.Solde;
                            }
                            soldelivret_Write(soldetotal);
                            this.soldecomptemsg.Text = "Voici la somme présente sur tous \n les comptes en euros";
                            this.soldelivretmsg.Text = "Voici la somme présente sur tous \n les livrets en euros";
                            this.send.Hide();
                            this.ask.Hide();
                            break;
                        }
                        else if (clientactuel == null)
                        {
                            break;
                        }
                        else
                        {
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
                            this.gestion.Hide();
                            break;
                        }
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
                        this.gestion.Hide();
                        break;
                }
            }
        }
    }
}
