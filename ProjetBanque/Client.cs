using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    class Client
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private DateTime dateNaissance;
        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private int codePostal;
        public int CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public Client(int id, string nom, string prenom, DateTime dateNaissance, string adresse, int codePostal, string ville, string telephone, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.telephone = telephone;
            this.mail = mail;
        }

        public Client()
        {

        }
    }
}
