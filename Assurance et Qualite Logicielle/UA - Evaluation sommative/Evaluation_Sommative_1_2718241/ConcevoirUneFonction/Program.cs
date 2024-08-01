/* Écrivez en C# une classe nommée Pyramide disposant:
- de deux attributs privés : largeur et hauteur.
-d'un constructeur paramétré permettant d'initialiser l'instance aux valeurs d'attributs fournis;
-des propriétés avec des accesseurs (getters) et mutateurs(setters) publics Largeur et Hauteur permettant de manipuler les attributs d'une instance de Pyramide,
et refusant d'attribuer une valeur négative à ceux-ci, et
-d'une méthode publique volume() retournant le volume de la pyramide.
volume(pyramide) = (h*l²)/3 (avec h: auteur et l: largeur)

-Voici un exemple de résultat à la console:

Veuillez saisir la Hauteur de la pyramide: 12
Veuillez saisir la Largeur de la pyramide: 5
Le volume de la pyramide est : 100
 */
using System;
public class Pyramide
{
    private double largeur;
    private double hauteur;

    public Pyramide(double largeur, double hauteur)
    {
        Largeur = largeur;
        Hauteur = hauteur;
    }
    public double Largeur
    {
        get { return largeur; }
        set { 
        
            if (value > 0)
                largeur = value;
            else throw new Exception();
            }
    }

    public double Hauteur
    {
        get { return hauteur; }
        set {
            if (value > 0)
                largeur = value;
            else throw new Exception();
             }
    }

    public double VolumePyramide()
    {
        return (hauteur * largeur * largeur) / 3;
    }

}   




public class Test
{
    public static void Main(string[] args)
    {


        double hauteur, largeur;

        Console.Write("Entrer la hauteur de la pyramide: ");
        hauteur= double.Parse(Console.ReadLine());

        Console.Write("Entrer la largeur de la pyramide: ");
        largeur = double.Parse(Console.ReadLine());

        Pyramide pyramide1 = new Pyramide(largeur, hauteur);

        double VolumePyramide = pyramide1.VolumePyramide();
        Console.Write($"Le Volume de la Pyramide est :{VolumePyramide}");


    }
}
