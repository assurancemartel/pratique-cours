using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative_1_2718241
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbElement, occ = 5;
            int s = Somme(out nbElement, ref occ, 1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine($"Somme={s},NbElement= {nbElement} ,NbOccurence = {occ}");
        }

        public static int Somme(out int n, ref int m, params int[] T)
        // n == par le parametre donc variable de sortie
        // m==

        {
            int s = 0;
            int nbval = 0;
            n = T.length;
            foreach (int i in T)
            {
                s += i;
                if (i == m)
                    nbval++;
            }
            m = nbval;
            return s;
        }




        /*  public double Trouver_Maximum(double x, double y, double z) /// double Trouver_maximum == la fonction  à chercher  avec son type.
          {
             double max = x; /// double max== declaration de la variable

              if ((x >= y && y >= z)||(x >= z && z >= x))
              {
                  return max;
              }
              else if ((y >= x && x >= z)||(y >= z && z >= x))
              {
                  return y = max;
              }
              else
              {
                  return z = max;
              }
          }

          */



        /* static void Main(string[] args)
         {
               double Notes=0;  int NbrNotes = 0;
             double Somme = 0;
               double Moyenne = 0;
             double NotesMax = double.MinValue;
               double NotesMin = double.MaxValue;
             String input;



             do
             {
                 Console.Write("Entrer des Notes: ");
                 input = Console.ReadLine();
                 if (input.ToLower() != "Stop" && double.TryParse(input, out Notes) && Notes >= 0 && Notes <= 20)
                 {
                     Somme += Notes;
                     NbrNotes++;

                     if (Notes > NotesMax)
                     {
                         NotesMax = Notes;
                     }

                     if (Notes > NotesMin)
                     {
                         NotesMin = Notes;
                     }

                 }
                 else
                 {
                     Console.WriteLine("Mauvaise Saisie . veuillez entrer des note comprises entre 0 et 20");
                 }

             } while (input.ToLower() != "Stop");

               if  (NbrNotes > 0)
               {
                       Moyenne = Notes / NbrNotes;

               }
               else
               { 
                 Console.WriteLine("Aucune note trouvée");
               }
             String operateur = "S,M,Max,Min,Q";
             do
             {
                 Console.WriteLine("Choisir une option de la liste suivante: ");
                 Console.WriteLine("        S - Somme " + "\n" + "        M - Moyenne" + "\n" + "        Max - Maximum" + "\n " + "       Min - Min"+ "\n " + "       Q - Quitter" );
                 Console.Write("Votre option ? ");
                 if (operateur == "Somme")
                 {
                     Console.WriteLine($"La somme des notes est :{Somme}");
                 }
                 if (operateur == "Moyenne")
                 {
                     Console.WriteLine($"la Moyenne des notes est : {Moyenne}");
                 }
                 if (operateur == "Max")
                 {
                     Console.WriteLine($"Le Maximum des notes sont : {NotesMax}");
                 }
                 if (operateur == "Min")
                 {
                     Console.WriteLine($"Le Minimum des notesw sont: {NotesMin}");
                 }
                 else
                 {
                     Console.WriteLine("Quitter l' Application");
                 }

             }
             while (operateur != "Quitter");


             Console.ReadKey();


















         }
     */
    }
}
