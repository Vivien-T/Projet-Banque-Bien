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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            creerClient();
        }

        Client creerClient()
        {
            Client client = new Client();

            Console.Write("Saisir le nom de famille du client : ");
            client.nom = Console.ReadLine();

            Console.Write("Saisir le prénom du client : ");
            client.prenom = Console.ReadLine();

            Console.Write("Saisir la date de naissance du client : ");
            client.DateNaissance = Console.Readline();

            Console.WriteLine("ntm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
