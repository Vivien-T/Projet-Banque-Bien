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
        private char[] tabcarspeciaux = {'!',':','/',';',',','§','.','?','>','<','*','µ','%','$','£','¤','&','"','#','{','('
            ,'[','-','|','`','_','\\','@',')',']','=','}','+','°'};
        public int open;
        private char[] tabnumeros = {'1','2','3','4','5','6','7','8','9','0'};
        private char[] tabalphabet = {'a','z','e','r','t','y','u','i','o','p','q','s','d','f','g','h','j','k','l','m','w','x','c','v','b','n' };
        private FormAccueil mainform = new FormAccueil();
        public Client client = new Client();
        public FormConnexion()
        {
            InitializeComponent();
            open = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Client GetClient()
        {
            return client;
        }
        private void btnInscript_Click(object sender, EventArgs e)
        {
            Inscription();
        }
        
        private Client Inscription()
        {
            int id = 1;
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            DateTime dateNaissance = dateTimePicker1.Value;
            string adresse = Adresse.Text;
            string codePostal = CP.Text;
            string ville = Ville.Text;
            string telephone = TelInscript.Text;
            string mail = Mail.Text;
            int solde = 50;
            string mdp = MdpInscript.Text;

            Client clicli = new Client(id, nom, prenom, dateNaissance, adresse, codePostal, ville, telephone, mail, solde, mdp);
            client = clicli;
            return client;
        }

        public Client Connexion()
        {
            for (int i = 0; i <= mainform.tabClients.Length; i++)
            {
                Client clicli = mainform.tabClients[i];
                if (TelConnect.Text == clicli.getTelephone() && MdpConnect.Text == clicli.getMdp())
                {
                    client = clicli;
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
            Connexion();
        }
    }

}
