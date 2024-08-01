using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_POO
{
    public class Employe
    {
        private string nom;
        private string prenom;
        private string adresse;
        private int anneeEmbauche;
        private double salaire;

        // methodes set et get
        public string Nom
        {
            get { return nom;}
            set { nom = value.ToUpper(); }  // ToUpper = majuscules
        }
        public string Prenom
        {
            get { return prenom;}
            set { prenom = value.ToLower();}   // ToLower = miniscules
        }
        public string Adresse
        {
            get { return adresse;}
            set { adresse = value;}
        }
        public int AnneeEmbauche
        {
            get { return anneeEmbauche;}
            set
            {
                if (value >=1995 && value <= 2021)
                {
                    anneeEmbauche = value;
                }
                else
                    value = 1995;
            }
            //  autre approche 
            /*
            set { anneeEmbauche = (value >= 1995 && value <= 2021) ? value : 1995; }
            */ 
        }
        public double Salaire
        {
            get { return salaire;}
            set
            {
                if (value > 2000)
                {
                    salaire = value;
                }
                else
                    value = 2000;
            }
        }

        // constructeurs

        public Employe (string nom,string prenom,double salaire, int  anneeEmbauche)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeEmbauche=anneeEmbauche;
            this.salaire = salaire;
        }

        public Employe(string nom, string prenom, double salaire, int anneeEmbauche,string adresse ) : this (nom,prenom,salaire,anneeEmbauche)
        {
            this.adresse = adresse;
        }

        // methode SalaireAnnuel
        public double SalaireAnnuel()
        {
             return salaire * 12;  
        }

        public int  Anciennete ()
        {
             return 2021 - anneeEmbauche;
        }

        public double  Prime()
        {
            int anciennete = Anciennete();

            double prime = 0;

            if (anciennete < 5)
            {
                prime = (10 / 100) * SalaireAnnuel();
            }
            else if (anciennete >= 5 && anciennete < 10)
            {
                prime = (15 / 100) * SalaireAnnuel();
            }
            else if (anciennete >= 10 && anciennete < 15)
            {
                prime = (20 / 100) * SalaireAnnuel();
            }
            else
            {
                prime = (25 / 100) * SalaireAnnuel();
            }
            return prime;
        }


        public void Afficher() 
        {
            Console.WriteLine("####..........Employe.....###");
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"Prénom:{prenom}");
            Console.WriteLine($"Salaire : {salaire}$CAD");
            Console.WriteLine($"Adresse:{adresse}");
            Console.WriteLine($"l'employé {nom} a exactement {Anciennete()} années d'ancienneté.");
        }

        public bool Egalite (Employe EmployeCourant)
        {
            return  this.Nom == EmployeCourant.Nom &&
                    this.Prenom == EmployeCourant.Prenom &&
                    this.Salaire == EmployeCourant.Salaire&&
                    this.AnneeEmbauche == EmployeCourant.AnneeEmbauche&&
                    this.Adresse == EmployeCourant.Adresse;
        }





    }
}
