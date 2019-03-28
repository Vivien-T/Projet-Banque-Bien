using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    public class LivretA : Compte
    {
        private double montantDecouvert = 0;
        private string _libelle;

        public LivretA(int idcompte, bool adecouvert, string nomClient, string prenomClient) :base(idcompte, adecouvert)
        {
            solde = 0;
            _libelle = "Compte de: " + nomClient + " " + prenomClient + ".";
        }

        public LivretA()
        {

        }
    }
}
