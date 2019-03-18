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
        public FormClient(int id, string nom, string prenom, DateTime dateNaissance, string adresse, int codePostal, string ville, string telephone, string mail)
        {
            InitializeComponent();
            Client client = new Client(id, nom, prenom, dateNaissance, adresse, codePostal, ville, telephone, mail);
            NomClient_Write(nom);
            PrenomClient_Write(prenom);
            VilleClient_Write(ville);
            MailClient_Write(mail);
            TelClient_Write(telephone);
            DataNaissClient_Write(dateNaissance);
            CPClient_Write(codePostal);
            AdresseClient_Write(adresse);
        }


        private void FormClient_Load(string text)
        {
            
        }

        private void NomClient_Write(string text)
        {
            this.NomClient.Text = text;
        }

        private void PrenomClient_Write(string text)
        {
            this.PrenomClient.Text = text;
        }

        private void VilleClient_Write(string text)
        {
            this.VilleClient.Text = text;
        }

        private void TelClient_Write(string text)
        {
            this.TelClient.Text = text;
        }

        private void MailClient_Write(string text)
        {
            this.MailClient.Text = text;
        }

        private void DataNaissClient_Write(DateTime text)
        {
            string value = text.ToString();
            this.DataNaissClient.Text = value;
        }

        private void AdresseClient_Write(string text)
        {
            this.AdresseClient.Text = text;
        }

        private void CPClient_Write(int text)
        {
            string wow = text.ToString();
            this.CPClient.Text = wow;
        }

        private void Valider_Click(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            if (formConnexion.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

        public 
    }
}
