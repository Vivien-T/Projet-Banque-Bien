using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
    public class Client
    {
        private int _id;
        public void setId(int value)
        {
            _id = value;
        }

        public int getId()
        {
            return _id;
        }




        private string _nom;
        public string getNom()
        {
            return _nom;
        }

        public void setNom(string value)
        {
            _nom = value;
        }




        private string _prenom;
        public string getPrenom()
        {
            return _prenom;
        }

        public void setPrenom(string value)
        {
            _prenom = value;
        }





        private DateTime _dateNaissance;
        public DateTime getDateNaissance()
        {
            return _dateNaissance; 
        }

        public void setDateNaissance(DateTime value)
        {
            _dateNaissance = value;
        }





        private string _adresse;
        public string getAdresse()
        {
            return _adresse;
        }

        public void setAdresse(string value)
        {
            _adresse = value;
        }





        private string _codePostal;
        public string getCodePostal()
        {
            return _codePostal;
        }

        public void setCodePostal(string value)
        {
            _codePostal = value;
        }





        private string _ville;
        public string getVille()
        {
            return _ville;
        }

        public void setVille(string value)
        {
            _ville = value;
        }





        private string _telephone;
        public string getTelephone()
        {
            return _telephone;
        }

        public void setTelephone(string value)
        {
            _telephone = value;
        }





        private string _mail;
        public string getMail()
        {
            return _mail;
        }

        public void setMail(string value)
        {
            _mail = value;
        }






        private string _mdp;
        public string getMdp()
        {
            return _mdp;
        }
        public void setMdp(string value)
        {
            _mdp = value;
        }





        public Client(int id, string nom, string prenom, DateTime dateNaissance, string adresse, string codePostal, string ville, string telephone, string mail, string mdp)
        {
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
            _adresse = adresse;
            _codePostal = codePostal;
            _ville = ville;
            _telephone = telephone;
            _mail = mail;
            _mdp = mdp;
            _id = id;
        }

        public Client()
        {

        }
    }
}
