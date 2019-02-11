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
                Id = 2,
                Libelle = "Produit 2"
            };

            Magasin magasin = new Magasin();
            magasin.AjouterProduit(p1);
            magasin.AjouterProduit(p2);
            magasin.AjouterProduit(new Produit()
            {
                Id = 3,
                Libelle = "Produit 3"
            });

            magasin.AfficherProduit();
            if (p1 != null)
            {
                p1.Libelle = "qsdfmlkj";
            }
        }
    }
}
