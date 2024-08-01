/*
 Dans la classe EtudiantAdmis, ci-dessous, on verifie l'admissibilité d'un étudiant selon son âge et sa moyenne.
Révisez le code et apportez-lui les modifications nécessaires pour qu’il respecte les notions vues dans le cours (nommage identificateur, syntaxe C#, indentation, formatage…). 
-Un exemple de resultat attendu:
Nom: Ferhat Ait Ouslimane Age: 20 Moyenne: 15.5
 */
using System;
public class etudiantAdmis

{
    private string nom;
    private int age;
    private double moyenne;

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    
     public int Age
     {
        get { return age ; }
        set {
            if (value >= 16 && value <= 30)
                age = value;
            else throw new AgeException();                            //Générer une exception de type InvalidAgeException
            }
     }
    
     public double Moyenne       
     {
        get { return moyenne; }
        set
        {
            if (value >= 10 && value <= 20)
                moyenne = value;
            else throw new NoteException();                                 //Générer une exception de type InvalidNoteException  
        }
     }

     public etudiantAdmis() { }

     public etudiantAdmis (string n="",  int a=0, double m =0.0)
     {
       nom = n;
       age = a;                                                                //Initialiser l'age à travers sa propriété pour tenir compte de l'exception InvalidAgeException
       moyenne = m;
     }

//Initialiser la moyenne à travers sa propriété pour tenir compte de l'exception InvalidNoteException

override
    public String ToString() 
    {
        return "Nom: " + nom + " Age: " + age + " Moyenne: " + moyenne;
    }
}


public class Test
{
    public static void Main(string[] args)
    {
        String Nom;
        int Age;
        double Moyenne;

        Console.Write("Veuillez entrer un nom:");
        Nom = Console.ReadLine();

        Console.Write("veuillez entrer l'age de la personne:");
        Age = int.Parse(Console.ReadLine());

        Console.Write("Veuillez entrer la moyenne de la personne ");
        Moyenne = double.Parse(Console.ReadLine());

        etudiantAdmis Etudiant = new etudiantAdmis(Nom,Age,Moyenne);
        Console.Write(Etudiant);








    }




}


