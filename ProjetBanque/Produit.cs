﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
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
    }
}
