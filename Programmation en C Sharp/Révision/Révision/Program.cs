using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Révision
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }//Console.WriteLine("...........Exercice..............");
            /*int x=0;
            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(x += i);
                }
                
            } while (x < 10);
        */


            /*  int produit = 2;
              int i=0;
              int resultat;
              do
              {
                  //Console.Write("i = ");
                 // i= int.Parse(Console.ReadLine());
                  resultat= produit*i;

                  Console.Write(resultat);
                  Console.WriteLine();
                  i++;
              }
              while (i <= 10);

              */

            /* int nbr, a, b, c, d,res;
             int temp1, temp2;
             Console.WriteLine("Entrer un nombre: ");
             nbr = int.Parse(Console.ReadLine());
             do
             {
                 a = nbr / 1000;
                 temp1 = nbr % 1000;
                 b = temp1 / 100;
                 temp2 = temp1 % 100;
                 c = temp2/ 10;
                 d = temp2 % 10;
                 res = d * 1000 + c * 100 + b * 10 + a;
                 Console.WriteLine(res);
             }
             while (nbr != nbr);

             using System;

 namespace CalculStatistiques
     {
         class Program
         {
             static void Main(string[] args)
             {*/
            /*double somme = 0;
            double moyenne = 0;
            double noteMax = double.MinValue;
            double noteMin = double.MaxValue;
            int nombreDeNotes = 0;

            Console.WriteLine("Entrez les notes (entre 0 et 20). Entrez -1 pour terminer :");

            while (true)
            {
                double note = Convert.ToDouble(Console.ReadLine());

                if (note == -1)
                    break;

                if (note >= 0 && note <= 20)
                {
                    somme += note;
                    nombreDeNotes++;

                    if (note > noteMax)
                        noteMax = note;

                    if (note < noteMin)
                        noteMin = note;
                }
                else
                {
                    Console.WriteLine("Note invalide. Veuillez entrer une note entre 0 et 20.");
                }
            }

            if (nombreDeNotes > 0)
            {
                moyenne = somme / nombreDeNotes;
                Console.WriteLine($"Moyenne : {moyenne:F2}");
                Console.WriteLine($"Somme : {somme:F2}");
                Console.WriteLine($"Note maximale : {noteMax:F2}");
                Console.WriteLine($"Note minimale : {noteMin:F2}");
            }
            else
            {
                Console.WriteLine("Aucune note valide n'a été saisie.");
            }*/

            /*
        }

    }
}
    */

            /*   using System;

   class Program
           {
               static void Main()
               {
                   double somme = 0;
                   double noteMax = double.MinValue;
                   double noteMin = double.MaxValue;
                   int nombreDeNotes = 0;
                   double note;
                   string input;

                   do
                   {
                       Console.WriteLine("Entrez une note (ou 'stop' pour terminer) : ");
                       input = Console.ReadLine();

                       if (input.ToLower() != "stop" && double.TryParse(input, out note) && note >= 0 && note <= 20)
                       {
                           somme += note;
                           if (note > noteMax)
                           {
                               noteMax = note;
                           }
                           if (note < noteMin)
                           {
                               noteMin = note;
                           }
                           nombreDeNotes++;
                       }
                       else if (input.ToLower() != "stop")
                       {
                           Console.WriteLine("Note invalide. Veuillez entrer une note entre 0 et 20.");
                       }
                   } while (input.ToLower() != "stop");

                   if (nombreDeNotes == 0)
                   {
                       Console.WriteLine("Aucune note n'a été entrée.");
                       return;
                   }

                   int choix;
                   do
                   {
                       Console.WriteLine("Choisissez une opération :");
                       Console.WriteLine("1. Calculer la moyenne");
                       Console.WriteLine("2. Calculer la somme");
                       Console.WriteLine("3. Trouver la note maximale");
                       Console.WriteLine("4. Trouver la note minimale");
                       Console.WriteLine("5. Quitter");
                       choix = int.Parse(Console.ReadLine());

                       switch (choix)
                       {
                           case 1:
                               Console.WriteLine("La moyenne est : " + (somme / nombreDeNotes));
                               break;
                           case 2:
                               Console.WriteLine("La somme est : " + somme);
                               break;
                           case 3:
                               Console.WriteLine("La note maximale est : " + noteMax);
                               break;
                           case 4:
                               Console.WriteLine("La note minimale est : " + noteMin);
                               break;
                           case 5:
                               Console.WriteLine("Au revoir !");
                               break;
                           default:
                               Console.WriteLine("Choix invalide. Veuillez choisir une option valide.");
                               break;
                       }
                   } while (choix != 5);
               }*/




        






       

// Classe abstraite Véhicule
public abstract class Vehicule
    {
        // Attributs privés
        private static int matriculeCounter = 0;
        private int matricule;
        private int anneeModele;
        private decimal prix;

        // Constructeur
        public Vehicule(int anneeModele, decimal prix)
        {
            this.matricule = ++matriculeCounter;
            this.anneeModele = anneeModele;
            this.prix = prix;
        }

        // Accesseurs et mutateurs
        public int Matricule
        {
            get { return matricule; }
        }

        public int AnneeModele
        {
            get { return anneeModele; }
            set { anneeModele = value; }
        }

        public decimal Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        // Méthodes abstraites
        public abstract void Demarrer();
        public abstract void Accelerer();

        // Redéfinition de la méthode ToString()
        public override string ToString()
        {
            return $"Matricule: {matricule}, Année du modèle: {anneeModele}, Prix: {prix:C}";
        }
    }

    // Classe Voiture dérivée de Véhicule
    public class Voiture : Vehicule
    {
        public Voiture(int anneeModele, decimal prix) : base(anneeModele, prix) { }

        // Implémentation des méthodes abstraites
        public override void Demarrer()
        {
            Console.WriteLine("La voiture démarre.");
        }

        public override void Accelerer()
        {
            Console.WriteLine("La voiture accélère.");
        }
    }

    // Classe Camion dérivée de Véhicule
    public class Camion : Vehicule
    {
        public Camion(int anneeModele, decimal prix) : base(anneeModele, prix) { }

        // Implémentation des méthodes abstraites
        public override void Demarrer()
        {
            Console.WriteLine("Le camion démarre.");
        }

        public override void Accelerer()
        {
            Console.WriteLine("Le camion accélère.");
        }
    }

    // Classe de test
    public class Test
    {
        public static void Main(string[] args)
        {
            // Création des instances de Voiture et Camion
            Voiture voiture = new Voiture(2021, 25000m);
            Camion camion = new Camion(2019, 45000m);

            // Test des méthodes et affichage des informations
            Console.WriteLine(voiture.ToString());
            voiture.Demarrer();
            voiture.Accelerer();

            Console.WriteLine(camion.ToString());
            camion.Demarrer();
            camion.Accelerer();




        }
    }













}



    }
