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
    public partial class FormConnexion : Form
    {
        public List<Client> listeClients;
        public List<CompteCourant> listeComptes;
        public List<LivretA> listeLivrets;
        private string[] tabcarspeciaux = {"!",":","/",";",",","§",".","?",">","<","*","µ","%","$","£","¤","&","\"","#","{","("
            ,"[","-","|","`","_","\\","@",")","]","=","}","+","°"};
        public int open;
        private string[] tabnumeros = {"1","2","3","4","5","6","7","8","9","0"};
        private string[] tabalphabet = {"a","z","e","r","t","y","u","i","o","p","q","s","d","f","g","h","j","k","l","m","w","x","c","v","b","n","é","è","à","ç","ù","ï","ê","î","â","û","ô","ä","ë","ü","ö"};
        private FormAccueil mainform;
        public Client client = new Client();
        public LivretA livret = new LivretA();
        public CompteCourant compte = new CompteCourant();
        public FormConnexion(List<Client> listeClients, List<CompteCourant> listecomptes, List<LivretA> listelivrets, FormAccueil formprec)
        {
            InitializeComponent();
            this.listeClients = listeClients;
            this.listeComptes = listecomptes;
            this.listeLivrets = listelivrets;
            mainform = formprec;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Client GetClient()
        {
            return client;
        }

        public List<LivretA> GetListeLivrets()
        {
            return listeLivrets;
        }

        public List<CompteCourant> GetlisteCompteCourant()
        {
            return listeComptes;
        }

        private void btnInscript_Click(object sender, EventArgs e)
        {
            if (VerifInscription())
            {
                Client c = Inscription();
                livret = new LivretA(c.getId(), false, c.getNom(), c.getPrenom());
                listeLivrets.Add(livret);
                compte = new CompteCourant(c.getId(), false, c.getNom(), c.getPrenom());
                listeComptes.Add(compte);
                if (c != null)
                {
                    client = c;
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            else
            {
                ErrorMsg_Write();
            }
        }

        private bool VerifInscription()
        {
            foreach(string carspecial in tabcarspeciaux)
            {
                if (Nom.Text.Contains(carspecial))
                {
                    return false;
                }
                if (Prenom.Text.Contains(carspecial))
                {
                    return false;
                }
                if (Adresse.Text.Contains(carspecial))
                {
                    return false;
                }
                if (CP.Text.Contains(carspecial))
                {
                    return false;
                }
                if (Ville.Text.Contains(carspecial))
                {
                    return false;
                }
                if (TelInscript.Text.Contains(carspecial))
                {
                    return false;
                }
            }
            foreach(string numero in tabnumeros)
            {
                if (Nom.Text.Contains(numero))
                {
                    return false;
                }
                if (Prenom.Text.Contains(numero))
                {
                    return false;
                }
                if (Ville.Text.Contains(numero))
                {
                    return false;
                }
            }
            foreach (string lettre in tabalphabet)
            {
                if (CP.Text.Contains(lettre))
                {
                    return false;
                }
                if (TelInscript.Text.Contains(lettre))
                {
                    return false;
                }
            }
            if (Nom.Text.Length > 30 || Nom.Text.Length < 3 || Prenom.Text.Length > 20 || Prenom.Text.Length < 3 || Adresse.Text.Length < 15 || CP.Text.Length != 5 || Ville.Text.Length < 3 || 
                TelInscript.Text.Length != 10)
            {
                return false;
            }
            return true;
        }
        private Client Inscription()
        {
            int compteur = 0;
            foreach(Client client in listeClients)
            {
                compteur += 1;
            }
            int id = compteur;
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            DateTime dateNaissance = dateTimePicker1.Value;
            string adresse = Adresse.Text;
            string codePostal = CP.Text;
            string ville = Ville.Text;
            string telephone = TelInscript.Text;
            string mail = Mail.Text;
            string mdp = MdpInscript.Text;

            Client clicli = new Client(id, nom, prenom, dateNaissance, adresse, codePostal, ville, telephone, mail, mdp);
            client = clicli;
            return client;
        }

        public Client Connexion()
        {
            foreach (Client client in listeClients)
            {
                if (TelConnect.Text == client.getTelephone() && MdpConnect.Text == client.getMdp())
                {
                    return client;
                }
            }
            return null;
        }

        private bool VerifNom(string nom)
        {
            if (nom.Length <= 1)
            {
                return false;
            }
            else if (nom.Length >= 20)
            {
                return false;
            }
            else
            {
                for (int i = 0; i <= tabcarspeciaux.Length; i++)
                {
                    if (nom.Contains(tabcarspeciaux[i]))
                    {
                        return false;
                    }
                }
                for (int i = 0; i <= tabnumeros.Length; i++)
                {
                    if (nom.Contains(tabnumeros[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private bool VerifNum(string nb)
        {
            for(int i = 0; i <= tabalphabet.Length; i++)
            {
                if (nb.Contains(tabalphabet[i]))
                {
                    return false;
                }
            }
            for(int i = 0; i <= tabcarspeciaux.Length; i++)
            {
                if (nb.Contains(tabcarspeciaux[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Client c = Connexion();
            if (c != null)
            {
                client = c;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ErrorMsg_Write()
        {
            this.ErrorMsg.Text = "Erreur Veuillez remplir tous les champs correctement !";
        }
    }

}
