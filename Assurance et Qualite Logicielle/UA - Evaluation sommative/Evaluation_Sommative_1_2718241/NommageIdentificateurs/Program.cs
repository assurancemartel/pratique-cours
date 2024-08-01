/*
 Écrire un programme dans lequel on demande à l’utilisateur de saisir
un entier en gérant l’exception dans le cas où il ne saisit pas un entier correctement
en lui demandant de refaire la saisie.
Travail à faire: corriger ce code pour qu'il respecte
les notions de nommage d'identificateurs vues dans le cours.
-Voici un 1er exemple de resultat attendu:

Donner un entier :
12
Votre entier est : 12

-Voici un deuxième exemple de résultat

Donner un entier :
@@
The input string '@@' was not in a correct format.
Donner un entier :

 */
using System;
class Program
{
    public static void Main(string[] args)
    {

        int A;
        bool R;
        do
        {
            try
            {
                R = true;
                Console.Out.WriteLine("Donner un entier: ");
                A = Int16.Parse(Console.In.ReadLine());
                Console.Out.WriteLine("Votre entier est: " + A);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                R = false;
            }
        } while (R == false);
        Console.ReadKey();
    }
}