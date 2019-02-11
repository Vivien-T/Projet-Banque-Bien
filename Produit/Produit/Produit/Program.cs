using System;

namespace Produit
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p1 = new Produit
            {
                Id = 1,
                Libelle = "produit 1"
            };
            Produit p2 = new Produit()
            {
                IDisposable = 2,
                Libelle = "Produit 2"
            };

            magasin = new Magasin();
            Magasin.AjouterProduit(p1);
            Magasin.AjouterProduit(p2);
            Magasin.AjouterProduit(new Produit()
            {
                Id = 3,
                Libelle = "Produit 3"
            });

            Magasin.AfficherProduits();
            if (p1 != null)
            {
                p1.Libelle = "qsdfmlkj";
            }
        }
    }
}
