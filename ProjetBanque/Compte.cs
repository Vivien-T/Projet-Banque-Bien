using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    class Compte
    {
        private int idcompte;
        private int libelle;
        private string type;
        private double solde;
        private int decouvert;

        public int IdCompte
        {
            get { return idcompte; }
            set { idcompte = value; }
        }

        public int Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public int Decouvert
        {
            get { return decouvert; }
            set { decouvert = value; }
        }
    }
}
