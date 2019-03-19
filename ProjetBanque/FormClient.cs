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
        public FormClient(int id, string nom, string prenom, DateTime datenaiss, string adresse, string cp, string ville, string telephone, string mail)
        {
            RemplirClient(id, nom, prenom, datenaiss, adresse, cp, ville, telephone, mail);
            InitializeComponent();
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

        }

        public void Retour_Click(object sender, EventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            if (formConnexion.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
