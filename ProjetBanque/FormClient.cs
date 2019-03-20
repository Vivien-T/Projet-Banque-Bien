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
    public partial class FormClient : Form
    {
        public int open = 0;
        public FormClient(Client client)
        {
            InitializeComponent();
            open = 1;
            RemplirClient(client.getId(), client.getNom(), client.getPrenom(), client.getDateNaissance(), client.getAdresse(), client.getCodePostal(), client.getVille(), client.getTelephone(), client.getMail());
        }

        public void RemplirClient(int id, string nom, string prenom, DateTime dateNaissance, string adresse, string codePostal, string ville, string telephone, string mail)
        {
            NomClient_Write(nom);
            PrenomClient_Write(prenom);
            VilleClient_Write(ville);
            MailClient_Write(mail);
            TelClient_Write(telephone);
            DateNaissClient_Write(dateNaissance);
            CPClient_Write(codePostal);
            AdresseClient_Write(adresse);
        }


        private void FormClient_Load(string text)
        {
            
        }

        public void NomClient_Write(string text)
        {
            NomClient.Text = text;
        }

        public void PrenomClient_Write(string text)
        {
            PrenomClient.Text = text;
        }

        public void VilleClient_Write(string text)
        {
            VilleClient.Text = text;
        }

        public void TelClient_Write(string text)
        {
            TelClient.Text = text;
        }

        public void MailClient_Write(string text)
        {
            MailClient.Text = text;
        }

        public void DateNaissClient_Write(DateTime text)
        {
            string value = text.ToString();
            DateNaissClient.Text = value;
        }

        public void AdresseClient_Write(string text)
        {
            AdresseClient.Text = text;
        }

        public void CPClient_Write(string text)
        {
            CPClient.Text = text;
        }

        public void Valider_Click(object sender, EventArgs e)
        {
            open = 2;
            this.Close();
            this.Hide();
        }

        public bool estOuvert()
        {
            if(open == 0)
            {
                return true;
            }
            else if(open == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Retour_Click(object sender, EventArgs e)
        {
            open = 0;
            this.Close();
            this.Hide();
        }
    }
}
