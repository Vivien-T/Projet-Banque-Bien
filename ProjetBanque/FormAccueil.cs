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
        Client client = new Client();
        public FormAccueil(Client cli)
        {
            InitializeComponent();
            client = cli;
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {

        }
        public void solde_Write(int solde)
        {
            string soldetext = solde.ToString();
            this.solde.Text = soldetext;
        }

        public void message_accueil_Write(string nom, string prenom)
        {
            nom = client.getNom();
            prenom = client.getPrenom();
            this.message_accueil.Text = ("Bonjour Mr. "+ nom + prenom + " !");
        }
    }
}
