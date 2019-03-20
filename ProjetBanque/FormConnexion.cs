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
        public int open;
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
            Client client = niqueTino();
            return client;
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            niqueTino();
            open = 0;
            this.Hide();
        }
        
        private Client niqueTino()
        {
            int id = 1;
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            DateTime dateNaissance = dateTimePicker1.Value;
            string adresse = Adresse.Text;
            string codePostal = CP.Text;
            string ville = Ville.Text;
            string telephone = Tel.Text;
            string mail = Mail.Text;
            int solde = 50;

            Client client = new Client(id, nom, prenom, dateNaissance, adresse, codePostal, ville, telephone, mail, solde);
            return client;
        }
    }

}
