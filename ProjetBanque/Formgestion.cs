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
                listClients.Items.Add(clicli.getNom()+" "+clicli.getPrenom());
            }
        }
    }
}
