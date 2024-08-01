using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_POO
{
    public class Rectangle
    {
        private double longueur;
        private double largeur;

        // methode de get et set 
        public double Longueur
        {
            get { return longueur; }
            set
            {
                if (value > 0) /// value est la valeur que l'utilisateur entre alors que longueur/largeur est un attribut
                {
                    longueur = value;
                }
                else
                {
                    longueur = 1.0;
                }
            }
        }

        public double Largeur
        {
            get { return largeur; }
            set
            {
                if (value > 0)
                {
                    largeur = value;
                }
                else
                {
                    largeur = 1.0;
                }
            }
        }

        //  constructeurs
        public Rectangle(double longueur)
        {
            this.longueur = longueur;
        }

        public Rectangle(double longueur, double largeur) : this(longueur)
        {
            this.largeur = largeur;
        }

        public double Surface()
        {
            return this.Longueur * this.Largeur;
        }

        public double Perimetre()
        {
            return 2 * (Longueur + Largeur);
        }

        public void Afficher()
        {
            Console.WriteLine("###########");

            Console.WriteLine($"La longueur de ce rectangle est :{this.longueur} ");
            Console.WriteLine($"La largeur de ce rectangle est : {this.largeur}");
            Console.WriteLine($"Le perimetre de ce rectangle est : {this.Perimetre()}"); // Les parentheses sont là du fait que ce sont des methodes perimetres et surfaces.
            Console.WriteLine($"La surface de ce rectangle est : {this.Surface()}");
        }

        // methode pour tester l`égalité de deux rectangles.
        public bool Egalite (Rectangle rectangleAutre)
        {
            return Longueur == rectangleAutre.longueur && 
                   largeur == rectangleAutre.largeur;
        }
    }

    
















}
