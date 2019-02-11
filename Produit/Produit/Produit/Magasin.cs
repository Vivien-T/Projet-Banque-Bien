using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    class Magasin
    {
        #region Attributs
        private List<Produit> produits = new List<Produit>();
        #endregion

        public void AjouterProduit(Produit produit)
        {
            produits.Add(produit);
        }

        public Produit RechercherProduit(int id)
        {

        }
    }
}
