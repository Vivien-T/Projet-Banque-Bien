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
        private string typeoperation;
        public FormOperation(string type, CompteCourant compte, LivretA livret, Client cli)
        {
            InitializeComponent();
            compteclient = compte;
            livretclient = livret;
            client = cli;
            typeoperation = type;
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
                    }
                    else if (MessageBox.Show("Si vous validez cette opération, vous serez à découvert... Souhaitez-vous continuer ? ", "Attention !", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        this.Refresh();
                    }
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
