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
    public partial class FormOperation : Form
    {
        private CompteCourant compteclient;
        private LivretA livretclient;
        private Client client;
        private int montant;
        private Operation operation;
        private string typeoperation;
        public FormOperation(string type, CompteCourant compte, LivretA livret, Client cli)
        {
            InitializeComponent();
            compteclient = compte;
            livretclient = livret;
            client = cli;
            typeoperation = type;
        }
        public int GetMontant()
        {
            return montant;
        }

        public CompteCourant GetCompte()
        {
            return compteclient;
        } 

        public LivretA GetLivret()
        {
            return livretclient;
        }

        public Operation Getoperation()
        {

            return operation;
        }


        private void ValidOperation_Click(object sender, EventArgs e)
        {
            montant = int.Parse(montantoperation.Text);
            if(typeoperation == "send")
            {
                montant = montant * (-1);
            }
            else if(typeoperation == "ask")
            {
                montant = montant * 1;
            }
            else
            {
                Console.WriteLine("Erreur how the fuck t'es arrivé là ?!");
            }

            if (comptecourant.Checked)
            {
                if (compteclient.Solde + montant < 0)
                {
                    if (MessageBox.Show( "Si vous validez cette opération, vous serez à découvert... Souhaitez-vous continuer ? ", "Attention !", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        compteclient.Solde = compteclient.Solde + montant;
                        int id = 0;
                        foreach (Operation op in compteclient.ListeOperations)
                        {
                            id += 1;
                        }
                        DateTime auj = DateTime.Today;
                        operation = new Operation(id, auj, montant, "Operation du: " + auj + " et de: " + montant + "€ depuis le Compte courant de: "+ client.getNom() + " " + client.getPrenom());
                        compteclient.ListeOperations.Add(operation);
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else if (MessageBox.Show("Si vous validez cette opération, vous serez à découvert... Souhaitez-vous continuer ? ", "Attention !", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        this.Refresh();
                    }
                }
                else
                {
                    compteclient.Solde = compteclient.Solde + montant;
                    int id = 0;
                    foreach (Operation op in compteclient.ListeOperations)
                    {
                        id += 1;
                    }
                    DateTime auj = DateTime.Today;
                    operation = new Operation(id, auj, montant, "Operation du: " + auj + " et de: " + montant + "€ depuis le Compte courant de: " + client.getNom() + " " + client.getPrenom());
                    compteclient.ListeOperations.Add(operation);
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            else if (livret.Checked)
            {
                if(livretclient.Solde + montant < 0)
                {
                    MessageBox.Show("Impossible d'être à découvert sur un livret, l'opération a été avortée !", "Attention", MessageBoxButtons.OK);
                    this.Refresh();
                }
                else
                {
                    livretclient.Solde = livretclient.Solde + montant;
                    int id = 0;
                    foreach (Operation op in livretclient.ListeOperations)
                    {
                        id += 1;
                    }
                    DateTime auj = DateTime.Today;
                    operation = new Operation(id, auj, montant, "Operation du: " + auj + " et de: " + montant + "€ depuis le Livret A de: " + client.getNom() + " " + client.getPrenom());
                    livretclient.ListeOperations.Add(operation);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner depuis quel compte vous souhaitez effectuer l'opération !", "Attention", MessageBoxButtons.OK);
                this.Refresh();
            }
        }
    }
}
