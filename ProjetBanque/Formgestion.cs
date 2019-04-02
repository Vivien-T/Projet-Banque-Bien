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
    public partial class Formgestion : Form
    {
        List<CompteCourant> listecomptes;
        List<LivretA> listelivrets;
        List<Client> listeclients;
        public Formgestion(List<Client> clients, List<CompteCourant> comptes, List<LivretA> livrets)
        {
            InitializeComponent();
            listecomptes = comptes;
            listelivrets = livrets;
            listeclients = clients;
        }

        private void Formgestion_Load(object sender, EventArgs e)
        {
            foreach(Client clicli in listeclients)
            {
                if(clicli.getTelephone() != "admin")
                {
                    listboxclients.Items.Add(clicli.getNom() + " " + clicli.getPrenom());
                }
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (listboxclients.CheckedItems.Count != 1)
            {
                MessageBox.Show("Veuillez sélectionner un seul client à la fois", "Attention !");
            }
            else
            {
                string chaine = listboxclients.CheckedItems[0].ToString();
                int counter = 0;
                int setter = 0;
                foreach (char car in chaine)
                {
                    if( car == ' ')
                    {
                        setter = 1;
                    }
                    else
                    {
                        if(setter == 0)
                        {
                            counter = counter + 1;
                        }
                    }
                }

                string nom = chaine.Substring(0, counter);
                string prenom = chaine.Substring(counter + 1, chaine.Length - (counter + 1) );
                Client damnboy = null;
                foreach(Client clicli in listeclients)
                {
                    if(clicli.getNom() == nom && clicli.getPrenom() == prenom)
                    {
                        damnboy = clicli;
                    }
                }

                FormGestionDuClient ongereleclicli = new FormGestionDuClient(listecomptes, listelivrets, listeclients, damnboy);
                ongereleclicli.ShowDialog();

                listeclients = ongereleclicli.GetListeClients();
                listecomptes = ongereleclicli.GetListeComptes();
                listelivrets = ongereleclicli.GetListelivrets();
            }
        }

        public List<CompteCourant> GetListeComptes()
        {
            return listecomptes;
        }

        public List<LivretA> GetListelivrets()
        {
            return listelivrets;
        }

        public List<Client> GetListeClients()
        {
            return listeclients;
        }

        private void Formgestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
