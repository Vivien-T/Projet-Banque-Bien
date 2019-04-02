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
    public partial class FormGestionDuClient : Form
    {
        private List<CompteCourant> listecomptes;
        private List<LivretA> listelivrets;
        private List<Client> listeclients;
        private Client clientactuel;
        private CompteCourant comptecli;
        private LivretA livretcli;
        private double argcomptedepart;
        private double arglivretdepart;
        private string[] tabcarspeciaux = {"!",":","/",";",",","§",".","?",">","<","*","µ","%","$","£","¤","&","\"","#","{","("
            ,"[","-","|","`","_","\\","@",")","]","=","}","+","°"};
        public int open;
        private string[] tabnumeros = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private string[] tabalphabet = { "a", "z", "e", "r", "t", "y", "u", "i", "o", "p", "q", "s", "d", "f", "g", "h", "j", "k", "l", "m", "w", "x", "c", "v", "b", "n", "é", "è",
            "à", "ç", "ù", "ï", "ê", "î", "â", "û", "ô", "ä", "ë", "ü", "ö" };

        public FormGestionDuClient(List<CompteCourant> comptes, List<LivretA>livrets,List<Client> clients, Client clicli)
        {
            InitializeComponent();
            listecomptes = comptes;
            listelivrets = livrets;
            clientactuel = clicli;
            listeclients = clients;
        }

        private void FormGestionDuClient_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Gestion du client: " + clientactuel.getNom() + " " + clientactuel.getPrenom();
            foreach(CompteCourant damn in listecomptes)
            {
                if(damn.IdCompte == clientactuel.getId())
                {
                    comptecli = damn;
                    this.argcompte.Text = comptecli.Solde.ToString();
                }
            }

            foreach (LivretA damn in listelivrets)
            {
                if (damn.IdCompte == clientactuel.getId())
                {
                    livretcli = damn;
                    this.arglivret.Text = livretcli.Solde.ToString();
                }
            }

            argcomptedepart = comptecli.Solde;
            arglivretdepart = livretcli.Solde;
        }

        private void valide_Click(object sender, EventArgs e)
        {
            int ok = 0;
            double soldeco = 0;
            double soldeli = 0;

            foreach (string str in tabalphabet)
            {
                foreach (string stri in tabcarspeciaux)
                {
                    if (this.argcompte.Text.Contains(str) || this.arglivret.Text.Contains(stri))
                    {
                        ok = 1;
                    }
                    else
                    {
                        if(ok == 1)
                        {

                        }
                        else
                        {
                            ok = 0;
                        }
                    }
                }
            }
            if(ok == 0)
            {
                soldeco = Convert.ToDouble(this.argcompte.Text);
                soldeli = Convert.ToDouble(this.arglivret.Text);
            }

            double diffco = soldeco - argcomptedepart;
            double diffli = soldeli - arglivretdepart;

            if (MessageBox.Show("La différence avec l'ancien montant du compte est de :" + diffco + " et la différence avec l'ancien montant du livret est de :" + diffli, "Attention !",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                comptecli.Solde = soldeco;
                livretcli.Solde = soldeli;

                foreach (CompteCourant compte in listecomptes)
                {
                    if(compte.IdCompte == comptecli.IdCompte)
                    {
                        listecomptes.Remove(compte);
                    }
                }
                listecomptes.Add(comptecli);

                foreach(LivretA livret in listelivrets)
                {
                    if(livret.IdCompte == livretcli.IdCompte)
                    {
                        listelivrets.Remove(livret);
                    }
                }
                listelivrets.Add(livretcli);
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
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

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes-vous sûr de couloir supprimer le client ? Cette action est irréversible !", "Attention !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach(CompteCourant compte in listecomptes)
                {
                    if(clientactuel.getId() == compte.IdCompte)
                    {
                        listecomptes.Remove(compte);
                    }
                }
                
                foreach(LivretA livret in listelivrets)
                {
                    if (clientactuel.getId() == livret.IdCompte)
                    {
                        listelivrets.Remove(livret);
                    }
                }
                
                foreach(Client clicli in listeclients)
                {
                    if(clicli == clientactuel)
                    {
                        listeclients.Remove(clicli);
                    }
                }
            }
            this.DialogResult = DialogResult.None;
            this.Close();
        }
    }
}
