using System;

namespace Produit
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p1 = new Produit();
            p1.Id = 1;
            p1.Libelle = "produit 1";
            Produit p2 = new Produit()
            {
                IDisposable = 2,
                Libelle = "Produit 2"
            };

            magasin magasin = new Magasin();
            magasin.AjouterProduit(p1);
            magasin.AjouterProduit(p2);
            magasin.AjouterProduit(new Produit()
            {
                Id = 3,
                Libelle = "Produit 3"
            });

            magasin.AfficherProduits();
        }
    }
}
