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
            FormClient formulaire = new FormClient(client.getId(), client.getNom(), client.getPrenom(), client.getDateNaissance(), client.getAdresse(), client.getCodePostal(), client.getVille(), client.getTelephone(), client.getMail());
            formulaire.ShowDialog();

        }
    }
}
