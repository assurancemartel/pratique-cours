 using System;
using System.Runtime.InteropServices;

internal class program
{
    static void Main (string[] args)
    {
        //Exercice1
       /* double a, b;
         Console.WriteLine("Saisir un premier nombre: ");
         a = double.Parse(Console.ReadLine());
         Console.WriteLine("Saisir le second nombre: ");
         b = double.Parse(Console.ReadLine());
        // res = a * b;
         //Console.WriteLine("Le produit de " + a + " et de " + b + " est" + res);
        // Console.WriteLine("le produit de {0} et de {1} est {2}",a,b,res);
        // Console.WriteLine($"Le produit de {a} et de {b} est {res}");*/
        

        //Exercice2

         double a, b, res;
         Console.WriteLine("Saisir un premier nombre: ");
         a = double.Parse(Console.ReadLine());
         Console.WriteLine("Saisir le second nombre: ");
         b = double.Parse(Console.ReadLine());
         Console.WriteLine("Avant la permutation :");
         Console.WriteLine($"a={a} et b={b}");// le dollard en tout debut permet de mettre les variables entre parentheses
         res = a;
         a = b;
         b = res;
         Console.WriteLine("Apres la permutation: ");
         Console.WriteLine($"a = {a} et b={b}");
            


        //Exercice4

        /*double prixHT, prixTTC, prixTHT, tauxTVA;//THT(total hors taxe)
        int nbArticle;
        Console.WriteLine("combien d'articles voulez-vous? ");
        nbArticle = int.Parse(Console.ReadLine());// convertir la valeur en entier 
                                                  // nbArticle = Convert.ToInt32(Console.ReadLine()); // convertir la valeur en entier en 32 bits. toute les 2 lignes ont le meme but .  
        Console.WriteLine("Entrerle prix hors taxe de l'article");
        prixHT = double.Parse(Console.ReadLine());
        Console.WriteLine("Saisir le taux TVA (entre 0 et 100): ");
        tauxTVA = double.Parse(Console.ReadLine());
        prixTHT = prixHT * nbArticle;//THT(total hors taxe)
        prixTTC = prixTHT * (1 + tauxTVA / 100);// TTC( toute taxe compris)
        Console.WriteLine("Prix total hors taxe = " + prixTHT);
        Console.WriteLine("prix TTC = "+prixTTC);*/
    }
}