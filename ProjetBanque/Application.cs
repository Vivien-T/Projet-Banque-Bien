using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetBanque
{
    public class Application
    {
        public void fonctionPrincipale()
        {
            FormConnexion formcrea = new FormConnexion();
            formcrea.ShowDialog();
            while(formcrea.open == 1)
            {
                
            }
            Client client = formcrea.GetClient();
            FormClient formulaire = new FormClient(client);
            formulaire.ShowDialog();
            while(formulaire.open == 1)
            {
                if (formulaire.estOuvert())
                {
                    if(formulaire.open == 0)
                    {
                        formulaire.Close();
                        formulaire = null;
                        formcrea = new FormConnexion();
                        formcrea.ShowDialog();
                    }
                    if (formulaire.open == 2)
                    {
                        formulaire.Close();
                        formulaire = null;
                        FormAccueil accueil = new FormAccueil(client);
                        accueil.ShowDialog();
                    }
                }
            }

        }
    }
}
