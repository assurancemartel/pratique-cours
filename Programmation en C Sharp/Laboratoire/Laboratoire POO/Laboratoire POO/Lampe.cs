using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_POO
{
    public class Lampe
    {
        //  attributs
        private Boolean etat ; // true= allumée et false = éteint.
        private string couleur;

        // methodes set et get
        public Boolean Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        // constructeurs
        public Lampe(bool etat,string couleur)   // constructeur initialisant les attributs
        {
            this.etat = etat;
            this.couleur = couleur;
        }
        public Lampe() // constructeur sans argument
        {
            etat = false;
            couleur = "jaune";
        }
        public Lampe(bool Etat)  // constructeur initialisant l'etat
        {
            this.etat = etat;
            this.couleur = "jaune";
        }

        // methode Allumer
        public void AllumerLampe ()
        {
            etat = true;
        }

        // methode Eteindre
        public void EteindreLampe ()
        {
            etat = false;
        }

        // methode Etat 2 approches possibles.
          
        // avec l'approche if...else
        public string EtatLampe ()
        {
            if ( etat )
            {
                return "allumée";
            }
            else
            {
                return "éteint";
            }
        }
        
        // avec l'approche de l'operation ternaire en c#
        public string Etatlampe ()
        {
            return etat ? "allumée" : "éteint";

        }

        // methode Afficher 
        public void Afficher()
        {
            //  affichage de etat avec la methode etat if..else
            Console.WriteLine($"État de la lampe :{EtatLampe()}");  // les parentheses parce que c'est une methode pas une simple var 
           
            //  affichage de etat avec la 2eme appoche de sa methode 
            Console.WriteLine($"État de la lampe :{(etat ? "allumée" : "éteint")}");
           
            Console.WriteLine($"Couleur de la lampe :{couleur}");
        }
    }
}
