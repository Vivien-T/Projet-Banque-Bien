using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    public abstract class Compte
    {
        protected int idcompte;
        protected double solde;
        protected bool adecouvert;

        public int IdCompte
        {
            get { return idcompte; }
            set { idcompte = value; }
        }

        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public bool ADecouvert
        {
            get { return adecouvert; }
            set { adecouvert = value; }
        }

        public Compte(int idcompte, bool adecouvert)
        {
            this.idcompte = idcompte;
            this.adecouvert = adecouvert;
        }

        public Compte()
        {

        }
    }
}
