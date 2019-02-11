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
        private string libelle;
        private string type;
        private double solde;
        private double decouvert;

        public int IdCompte
        {
            get { return idcompte; }
            set { idcompte = value; }
        }

        public string Libelle
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

        public double Decouvert
        {
            get { return decouvert; }
            set { decouvert = value; }
        }

        public Compte(int idcompte, string libelle, string type, double solde, double decouvert)
        {
            this.idcompte = idcompte;
            this.libelle = libelle;
            this.type = type;
            this.solde = solde;
            this.decouvert = decouvert;
        }
    }
}
