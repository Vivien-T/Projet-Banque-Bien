using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    public class Operation
    {
        private int idoperation;
        private DateTime date;
        private double montant;
        private string libelle;

        public int IdOperation
        {
            get { return idoperation; }
            set { idoperation = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Montant
        {
            get { return montant; }
            set { montant = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public Operation(int idoperation, DateTime date, double montant, string libelle)
        {
            this.idoperation = idoperation;
            this.date = date;
            this.montant = montant;
            this.libelle = libelle;
        }
    }
}
