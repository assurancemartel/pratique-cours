using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_POO
{
    //
    //internal class Program  // le mot internal ici est un modificateur d'accès , on a private, public, internal et protected.
    public class Produit
    {
       

        private int code;
        private string nom;
        private int quantite;
        private double PrixVente;

        public Produit() { }

        public Produit (int code, string nom, int quantite,double PrixVente)
        {
            this.code = code;
            this.nom = nom;
            this.quantite = quantite;
            this.PrixVente = PrixVente;
        }

        public Produit(string nom, int quantite, double PrixVente)
        {
            this.nom = nom;
            this.quantite = quantite;
            this.PrixVente = PrixVente;
        }

        // methode de destructeur
        ~Produit ( )  // ca serAa toujours de cette forme ~+nom de la classe +()
        {
            Console.WriteLine("Fermeture/Suppresion  d'un objet");
        }

        /*......les methodes get et set ...*/
        public int CODE
        {
            get { return code; }
            set { code = value; }
        }
        
        public string NOM
        {
            get { return  nom; }
            set { nom = value; }
        }

        public int QUANTITE
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public double PRIXVENTE
        {
            get { return PrixVente; }
            set { PrixVente = value; }
        }

        public void Afficher()
        {
            Console.WriteLine("################");

            Console.WriteLine($"Le nom du produit est : {nom}" ); 
            Console.WriteLine($"le code du produit est:{code}");
            Console.WriteLine($"la quantite est :{quantite}");
            Console.WriteLine($"et le prix est: {PrixVente}");

            if (quantite < 5)
            {
                Console.Write("Alert! Seuil de sécurité atteint....");
            }
            Console.WriteLine(); 

        }
        static void Main(string[] args)
        {
            Produit P1 = new Produit();
            Produit P2 = new Produit(158889,"HP",3545,1259.99);
            Produit P3 = new Produit("ASUS", 485, 4851.99);

            // Affichage des informations avant modifictions.
            P1.Afficher();
            Console.WriteLine();  // pour sauter la ligne 

            P2.Afficher();
            Console.WriteLine();

            P3.Afficher();
            Console.WriteLine();


            // Mettre à jour les informations des produits P1 : utilisation de set ie utiliser les expressions utilisé lors de la declaration de la methode 

            P1.CODE = 157898458;
            P1.NOM = "Samsung";
            P1.QUANTITE = 984;
            P1.PRIXVENTE = 1478.99;
            Console.WriteLine("Afficher les mises à jour des produits");
            P1.Afficher();

            // Utilisation de la methode get 
            double valeurTotal = P1.quantite * P1.PrixVente;
            Console.WriteLine(valeurTotal);


            /////  Test de la classe Rectangle


            Rectangle rect1 = new Rectangle(5.0, 2.0);
            Rectangle rect2 = new Rectangle(5.0);

            rect1.Afficher();
            rect2.Afficher();

            if (rect1.Egalite(rect2))
            {
                Console.WriteLine("Les deux rectangles sont égaux.");
            }
            else
            {
                Console.WriteLine("Les deux rectangles ne sont pas égaux.");
            }


            /// Test de la classe Lampe

            Lampe L1 = new Lampe(true);
            Lampe L2 = new Lampe();
            Lampe L3 = new Lampe(true,"rouge");


            Console.Write("####.....Lampe1....####");
            Console.WriteLine();
            L1.Afficher();
            Console.WriteLine();


            Console.Write("####.....Lampe2....####");
            Console.WriteLine();
            L2.Afficher();
            Console.WriteLine();


            Console.Write("####.....Lampe3....####");
            Console.WriteLine();
            L3.Afficher();
            Console.WriteLine();
            L2.EtatLampe();


            Console.WriteLine();
            L1.EteindreLampe();
            Console.WriteLine();

            Console.WriteLine();
            L3.AllumerLampe();
            Console.WriteLine();

            Console.WriteLine();
            L2.EtatLampe();


            // Test de la classe employée

            Employe emp1 = new Employe("Mohamed Salah", "Bouhlel", 45000, 2005, "123 Rue Charlemagne,Gatineau,A1B2C3,Canada");

            Employe emp2 = new Employe("Duval","Eric",25000,2015);


            Console.WriteLine("Informations de l'employé 1 ");
            emp1.Afficher();
            Console.WriteLine();



            Console.WriteLine("Informations de l'employé 2 ");
            emp2.Afficher();
            Console.WriteLine();


            Console.WriteLine("Le salaire annuel de l'employe 1" + emp1.SalaireAnnuel() + "$CAD");
            Console.WriteLine();

            Console.WriteLine("Le salaire annuel de l'employe 2" + emp2.SalaireAnnuel() + "$CAD");
            Console.WriteLine();

            Console.WriteLine("L'anciennete  de l'employe 1" + emp1.Anciennete()+" ans");
            Console.WriteLine();

            Console.WriteLine("La prime de l'employe 2" + emp2.Prime() + "$CAD");
            Console.WriteLine();
             
            // affichage de comparaison.
            /*
            Console.WriteLine("Comparaison entre l'employe1 et employe 2 " + emp1.Egalite(emp2));
            Console.WriteLine();
            */

        // autre approche de comparaison d,affichage 
            Console.WriteLine("Comparaisons entre les 2 employés") ;
            if (emp1 == emp2)
            {
                Console.WriteLine("les informations des 2 employes  sont  égales");
            }
            else
            {
                Console.WriteLine("Les informations des 2 employés ne sont pas égales ");
            }
























        }


    }



    











}
