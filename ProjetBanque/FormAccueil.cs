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
        public Client test1;
        public Client[] tabClients = { };
        public int open = 0;
        public Client clientactuel = new Client();
        public FormAccueil()
        {
            datetest = new DateTime(2000, 04, 20);
            test1 = new Client(1, "test", "ostérone", datetest, "852 Avenue de test", "34000", "Montpellier", "0671973276", "test@google.fr", 50, "abcd");
            InitializeComponent();
            tabClients[0] = test1;
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            FormConnexion formclient = new FormConnexion();
            formclient.ShowDialog();
            clientactuel = formclient.GetClient();
            message_accueil_Write(clientactuel.getNom(), clientactuel.getPrenom());
            solde_Write(clientactuel.getSolde());
        }

        public void solde_Write(int solde)
        {
            string soldetext = solde.ToString();
            this.solde.Text = soldetext;
        }

        public void message_accueil_Write(string nom, string prenom)
        {
            this.message_accueil.Text = ("Bonjour Mr. "+ nom + prenom + " !");
        }
    }
}
