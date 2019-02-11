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

        public void AfficherProduit()
        {
            foreach(Produit produit in produits)
            {
                Console.WriteLine(produit.Description);
            }
        }

        public Produit RechercherProduit(int id)
        {
            foreach (Produit produit in produits)
            {
                if (produit.Id == id)
                    return produit;
            }
            return null;
        }

        public void SupprimerProduit(int id)
        {
            Produit produit = RechercherProduit(id);
            if (produit != null)
            {
                produits.Remove(produit);
            }
        }
    }
}
