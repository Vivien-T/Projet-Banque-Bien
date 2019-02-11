using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produit
{
    class Produit
    {
        #region Attributs
        private int id;
        #endregion

        #region Propiétés
        public int ID
        {
            get { return ID; }
            set { id = value; }
        }

        public string Libelle { get; set; }
        #endregion

        public string Description
        {
            get { return string.Format("N°{0} - {1}", id, Libelle); }
        }
    }
}