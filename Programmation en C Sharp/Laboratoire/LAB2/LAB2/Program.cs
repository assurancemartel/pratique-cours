using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ///  

            /*  Console.WriteLine("EXERCICE 1  : MAX && MIN");
             int A, B, C;
              Console.Write("Entrer un nombre entier de A: ");
              A = int.Parse(Console.ReadLine());
              Console.Write("Enter un nombre entier de B: ");
              B = int.Parse(Console.ReadLine());
              Console.Write("Entrer un nombre entier de c:");
              C = int.Parse(Console.ReadLine());
              int max ;
              if (A > B && A > C)
              {
                  Console.WriteLine($"Le maximum de {A},{B},{C} est : " + A);
              }
              else if (B > A && B > C) 
              {
                  Console.WriteLine($"Le maximum de {A}, {B},{C} est : " + B);
              }
              else if (C > A && C > B)
              {
                  Console.WriteLine($"Le maximum de {A}, {B},{C} est : " + C);
              }
              else
              {


                  Console.WriteLine("Nombre éroné");
              }*/




            //// 
            /* Console.WriteLine("Exercice2 : Pair et Impair");
             int X;
             Console.WriteLine("Entrer un nombre entier");
             X = int.Parse(Console.ReadLine());
             if (X % 2 == 0)
             {
                 Console.WriteLine("le nombre est Pair");
             }
             else
             {
                 Console.WriteLine("Le nombre est impair");
             }*/



            //// 
            /*  Console.WriteLine("Exercice3 : ");
              double a,b,x;
              do
              {
                  Console.Write("Entrer le réel a: ");
                  a = double.Parse(Console.ReadLine());
              } while (a == 0);
              Console.Write("Entrer le réel b: ");
              b = double.Parse(Console.ReadLine());
              x = -(b / a);
              Console.WriteLine($"La resolution de l'equation {a}x+{b} = 0 est : x = " + x);

             */



            ///




            /* Console.WriteLine("Exercice4: ");
             double a, b, c, x, x1, x2; Console.Write("Entrer le réel a: ");
             a = double.Parse(Console.ReadLine());
             Console.Write("Entrer le réel b: ");
             b = double.Parse(Console.ReadLine());
             Console.Write("Entrer le réel c: ");
             c = double.Parse(Console.ReadLine());
             Console.WriteLine($"Soit l'equation : {a}x²+{b}x+{c}=0 ");
             if (a == 0)
             {
                 Console.WriteLine($" On obtient l'equation : {b}x+{c}=0");
                 if (b == 0)
                 {
                     Console.WriteLine("Pas de solution");

                 }
                 else
                 {
                     Console.WriteLine("La solution est : x = " + -(c / b));
                 }
             }


             else
             {
                 double Disc = b * b - 4 * a * c;
                 if (Disc > 0)
                 {
                     Console.WriteLine("On a 2 solutions réelles ");
                     x1 = (-b + Math.Sqrt(Disc)) / 2 * a;  /// la racine carré c'est Math.Sqrt
                     x2 = (-b - Math.Sqrt(Disc)) / (2 * a);
                     Console.WriteLine($"Les solutions sont : {x1} et {x2}");
                 }
                 else if (Disc == 0)
                 {
                     Console.WriteLine("On a une solution unique ");
                     x = -b / 2 * a;
                     Console.WriteLine($"La solution est : {x}");
                 }
                 else 
                 {
                     Console.WriteLine("On a aucune solution");
                 }



             }
            */




            //// 
            /* Console.WriteLine("Exercice5");
             int annee;
             Console.WriteLine("Saisir une année: ");
             annee = int.Parse(Console.ReadLine());
             if( (annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0 ))
             {
                 Console.WriteLine()

             }
            */


            /* Console.WriteLine("Exercice7");
            double Moyenne;
            Console.WriteLine("Entrer la Moyene: ");
            Moyenne = Convert.ToDouble(Console.ReadLine());
            string Mention;
            switch(Moyenne)
            {
                case (10<= Moyenne < 12):
                    Console.WriteLine("Mention: Passable");
                        break;
            }

            */






            /* Console.WriteLine("Exercice du cours:");

             int a,b,temp,reste;

             do
             {

                 Console.Write("Entrer la valeur de a: ");
                 a = int.Parse(Console.ReadLine());
                 Console.WriteLine("Entrer la valeur de b: ");
                 b = int.Parse(Console.ReadLine());

             } while (a < b);
             int i = 0;
             while (a>=b)
             {
                 a = a - b;
                 i++;
             }
             
             Console.WriteLine($"Reste = {a}-{b}");
             Console.WriteLine($"Quotient = "+i);
             */



            ///
            /*Console.WriteLine("Exercice2");
            int a;
            Console.WriteLine("Entrer le 1er entier a : ");
            a = int.Parse(Console.ReadLine());
           // Console.WriteLine("Entrer le 2eme entier b: ");
           // b = int.Parse(Console.ReadLine());
            int i = 0;
           

            */


            ///  
            /*  Console.WriteLine("Exercice1 et 3 à la fois");
           // Déclarer un tableau pour stocker les 20 nombres
           int N;
           N=int.Parse(Console.ReadLine());
               int[] numbers = new int[N];
           int Somme, Produit, Moyenne;

               // Lire les 20 nombres saisis au clavier
               for (int i = 0; i < N; i++)
               {
                   Console.Write($"Entrez le nombre {i + 1}: ");
                   numbers[i] = Convert.ToInt32(Console.ReadLine());
               }

               // Afficher les 20 nombres saisis
               Console.WriteLine("Les nombres saisis sont:");
               for (int i = 0; i < N; i++)
               {
                   Console.WriteLine(numbers[i]);
               }
           Console.WriteLine("La somme de ces nombres est:");
           for (int i = 0; i < 5; i++)
           {
               Console.WriteLine( numbers[i]);
           }

           */



            ///
            /*  int N, somme, produit,numbers;
              double moyenne;
              somme = 0;
              moyenne = 0;
              produit = 1;
              do
              {
                  Console.WriteLine("Veuillez entrer le N nombres entiers");
                  N = int.Parse(Console.ReadLine());
              }while(N<=0); 
                  for (int i = 0; i < N; i++)
              {
                  Console.Write($"Entrez le nombre {i + 1}: ");
                 numbers = Convert.ToInt32(Console.ReadLine());
                  somme = +numbers;
                  produit = produit * numbers;
                  moyenne = (double)somme / N;
              }
              Console.WriteLine($"La somme est: {somme}, le produit:{produit},la moyenne: {moyenne}");
            */


            /*
          //  Déclarer un tableau pour stocker les notes de 15 cours
            double[] notes = new double[15];
            double somme = 0;
            double moyenne;
            for(int i=0; i<15; i++) 
            {
                Console.Write("notes[{0}] =", i);/// ("notes[{0}] =", i)  tres important  pour la bonne synthaxe et affichage.
                notes[i] = double.Parse(Console.ReadLine());
                somme += notes[i];
            }
            // afficher les notes
            Console.WriteLine("les notes de l'etudiant sont:");
            foreach (int n in notes)   ///  n= variable choisi , pas forcement n 
            {
                Console.WriteLine(n+ " ");
            }
            // pour la moyenne
            moyenne = somme / 15;   /// moyenne hors de la boucle for sinon il faudra initialiser le compteur de  la moyenne ie moy=0;
            Console.WriteLine($"La moyenne de l'étudiant est :{moyenne}");

           */

            /* Console.WriteLine("Exercice1 de UA");
             String Phrase;
             int CompteurVoyelle = 0;
             Console.WriteLine("Entrer une chaine de charactère:");
             Phrase = Console.ReadLine();
             for(int i = 0; i < Phrase.Length; i++) 
             {
                 if (Phrase[i] =='a'|| Phrase[i]='e'|| Phrase[i] = 'i' || Phrase[i] = 'o' || Phrase[i] = 'u')
                 {
                     CompteurVoyelle++;
                 }
             }

             /*Char[] Voyelle = new Char[] { 'a', 'e', 'i', 'o', 'u' };
             foreach (char c in Phrase)
             {
                 if (Char.IsLetter(c))
                 {
                     if (Voyelle.Contains(c))
                         CompteurVoyelle++;
                 }

             }
             Console.WriteLine($"la voyelle {Voyelle} est contenu : {CompteurVoyelle} fois ");
 */

            /*   Console.WriteLine("Exercice1 de UA");
               String Phrase;
               int CompteurVoyelle = 0;
               Console.WriteLine("Entrer une chaine de charactère:");
               Phrase = Console.ReadLine();
               for (int i = 0; i < Phrase.Length; i++)
               {
                   char c = Phrase[i];
                   if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                   {
                       CompteurVoyelle++;
                   }
                   Console.WriteLine($"la voyelle {c} est contenu : {CompteurVoyelle} fois ");
               }
              */


            /* Console.WriteLine(".............Exercice3: Max,Min,Moyenne,Somme.......... ");
             // Déclaration d'un tableau de 20 entiers en C#
             int[] Nombres = new int[5];
             double Somme = 0;
             double Moyenne;
             int Max, Min;

             for (int i = 0; i < Nombres.Length; i++)
             {
                 /// ConsoleColor color = ConsoleColor.Green;
                 Console.Write(" Entrer le Nombres[{0}] =", i);   /// tres important pour pouvoir lire les var
                 Nombres[i] = Convert.ToInt32(Console.ReadLine());
                 Somme += Nombres[i];
             }
             // Affichage du contenu initialisé du tableau

             Console.Write("Les nombres sont : " );
             foreach (int Nbr in Nombres)
             {
                 Console.Write( Nbr + " ");
             }
             Console.WriteLine();/// afin de sauter la ligne
             Moyenne = Somme / 5;

             Max = Nombres[0];
             Min = Nombres[0];

             for (int i = 1; i < Nombres.Length; i++)
             {
                 if (Nombres[i] > Max)
                 {
                     Max = Nombres[i];
                 }


                 if (Nombres[i] < Min)
                 {
                     Min = Nombres[i];
                 }
             }

             Console.Write($"La Somme des nombres est :{Somme}");
             Console.WriteLine(" ");
             Console.Write($" La moyenne est:{Moyenne}");
             Console.WriteLine(" ") ;
             Console.Write("Max est : {0}\n", Max);
             Console.Write("Min est : {0}\n\n", Min);

 */


            /* Console.WriteLine("Exercice 6: ");
             int N;
             Console.Write("Entrer le nombre N de lignes du triangle Rectangle:  ");
             N = int.Parse(Console.ReadLine());
             for(int i = 1; i < N; i++)
             {
                 for(int j = 1; j < i; j++)
                 {
                     Console.Write(" * ");
                 }
                 Console.WriteLine();
             }
            */

            /* Console.WriteLine("Exercice6");
             int N;
             Console.Write("Entrer le nombre N lignes du Carré:");
             N= int.Parse(Console.ReadLine());
             for(int i = 0; i < N; i++)
             { 
                 for(int j = 0; j < N; j++)
                 {
                     Console.Write(" ");
                 }for(int k = 0; k < N; k++) 
                 {
                     Console.Write(" * ");
                 }
                 Console.WriteLine();
             }
            */
            /*
              Console.WriteLine("Exercice6");
               int N;
               Console.Write("Entrer le nombre N lignes du Isocèles:");
               N = int.Parse(Console.ReadLine());
               for (int i = 1; i <= N; i++)
               {
                   for (int j = 0; j <= N-i+1; j++)
                   {
                       Console.Write(" ");
                   }
                   for (int k = 1; k <=i; k++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine();
               }

               
            */

            /* Console.WriteLine("Exercice7:");
             int Somme = 0;
             for (int i = 1; i <= 100; i++)
             {
                 double a = i / 10;
                 double b = i % 10;
                 double entier = a + b;
                 if (entier == 11)
                 {
                     Console.WriteLine(i);
                 }
             }
             */


            /*  Console.WriteLine("Exercice 8");
              int N, Nombre,
               CompteurPositif = 0,
               CompteurNégatif = 0,
               CompteurPair = 0,
               CompteurImpair=0;
              do
              {
                  Console.Write("Entrer un entier Naturel N: ");
                  N = int.Parse(Console.ReadLine());
              } 
              while (N<= 0);


              int Max=int.MinValue;//tres important
              int Min=int.MaxValue;//tres important
              for (int i = 0; i < N; i++) 
              { 
                  Console.Write($"Entrez le nombre {i + 1}: ");
                  Nombre = Convert.ToInt32(Console.ReadLine());
                  if ( Nombre > 0 ) 
                  {
                      CompteurPositif++;
                  }
                  else      // if (Nombre < 0)
                  {
                      CompteurNégatif++;  
                  }
                  if(Nombre%2 == 0) 
                  { 
                      CompteurPair++;
                  }
                  else        //if(Nombre%2 != 0)
                  {
                      CompteurImpair++;
                  }

                  // Trouver le minimum et le maximum

                  //1ere methode 
                  // Max = Math.Max(Max, Nombre);
                  //  Min=Math.Min(Min, Nombre);

                  //2eme methode
                  if (Nombre < Min) Min = Nombre;
                  if (Nombre > Max) Max = Nombre;


              }
              Console.WriteLine($"Le nombre d'elts  positifs sont:{CompteurPositif}");
              Console.WriteLine($"Le nombre d'elts  Négatifs sont:{CompteurNégatif}");
              Console.WriteLine($"Le nombre d'elts  Pairs sont:{CompteurPair}");
              Console.WriteLine($"Le nombre d'elts  Impairs sont:{CompteurImpair}");
              Console.WriteLine($"Le Maximum des nombres est:{Max}");
              Console.WriteLine($"Le Minimum des nombres est:{Min}");

              */


            /*  Console.WriteLine("Exercice UA");
              int N;
              int Pair = 0;
              int CompteurPair=0;
              double Moyenne = 0;
              Console.Write("Veuillez entrer la taille du tableau : ");
              N= int.Parse(Console.ReadLine());
              int[] Tableau = new int[N];
              int Somme = 0;
              for (int i = 0; i < N; i++) 
              {
                  Console.Write("Entrer la valeur de Tableau[{0}] =", i);
                  Tableau[i] = Convert.ToInt32(Console.ReadLine());
                  Somme += Tableau[i];
                   if (Tableau[i] %2 == 0) 
                   {
                       CompteurPair++;
                   }
              }
              Moyenne +=(double) Somme/N;

              Console.Write("Les Valeurs du Tableau sont :"); // message avanrt la boucle afin que il n' y ai pas de message repetitives.
              foreach (int Tab in Tableau)   // boucle permettant l'affichage du tableau
              {
                  Console.Write(Tab+" ");
              }

              Console.WriteLine();   // sauter la ligne
              Console.Write($"La Moyenne de ce tableau est: {Moyenne}");

              Console.WriteLine();
              Console.Write($"Dans ce tableau il y a : {CompteurPair} nombres pairs");

              Console.WriteLine();
              Console.Write("Les éléments pairs du tableau sont : ");  // boucle foreach permettant d'aficher les nombres qui sont tous pairs.
              foreach (int nombre in Tableau)
              {
                  if (nombre % 2 == 0)
                  {
                      Console.Write(nombre + " ");
                  }
              }

              Console.WriteLine();
              Console.Write("Les Valeurs  divisés par 2 du Tableau sont:");
              foreach (double tab in Tableau)
              {
                  Console.Write(tab/2 + " ");
              }

              */

            /*  Console.WriteLine("Exercice d'UA");
              bool res;
              double note;
              ArrayList notes = new ArrayList();
              while (true)
              {
                  do
                  {
                      Console.WriteLine("saisir une note entre 0 et 20");
                      res = double.TryParse(Console.ReadLine(), out note);    
                  }while (!res || (note<0 ||note>20));
                  notes.Add(note);
                  Console.WriteLine("voulez vous continuer ? O/N ");
                  string continuer = Console.ReadLine();
                  if (continuer.ToUpper() == "N") ;
                  break;

              }


              */

            Console.WriteLine("Exercice d'appli sur ArrayList");
            int N;
            Console.WriteLine("Entrer la dimension du tableau: N= ");
            N = int.Parse(Console.ReadLine());
            do
            {
                ArrayList Tab = new ArrayList(N);
                Console.Write($"Entrez la valeur de Tab =  ");
                Tab
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    = Convert.ToInt32(Console.ReadLine());

            } while(N <= 50);

            // Lire les N éléments saisis au clavier
            for (int i = 0; i < N; i++)
            {
                
            }

            foreach (var i in Tab)
            {
                Console.WriteLine($"{i}");
            }
































        }

    }
}


 
  
