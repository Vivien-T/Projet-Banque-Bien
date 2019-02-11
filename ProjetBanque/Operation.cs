using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    class Operation
    {
        private int idoperation;
        private DateTime date;
        private double montant;
        private int libelle;
        private bool debit;

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

        public int Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public bool Debit
        {
            get { return debit; }
            set { debit = value; }
        }
    }
}
