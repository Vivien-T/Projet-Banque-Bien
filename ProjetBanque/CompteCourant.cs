using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    public class CompteCourant :Compte
    {
        private double _montantDecouvert = 50;
        private string _libelle;

        public CompteCourant(int idcompte, bool adecouvert, string nomClient, string prenomClient) : base(idcompte, adecouvert)
        {
            solde = 50;
            _libelle = "Compte de: " + nomClient + " " + prenomClient+".";
        }

        public CompteCourant()
        {

        }
    }
}
