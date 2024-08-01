/*  Ci dessous,la classe abstraite Salarie ayant les attributs suivants :matricule, nom et prénom. 
La classe Salarie comprend les méthodes suivantes :

-un constructeur d’initialisation
-des propriétés avec des getters et setters pour les différents attributs
-une méthode Tostring()
-une méthode abstraite calculerSalaire().

Travail à faire: compléter le code pour avoir les bons résultats
en repectant la syntaxe du langage C# pour les notions
de la Programmation Orientée Objet et les exigences d'assurance qualité
logicielle vus dans le cours.

-Un exemple de résultat affiché à la console:
***********************************
Infos du salarié de troisième échelon:  Matricule: 3,  Nom: Poirrier,  Prénom: Tom,  Pourcentage: 3%
Le salaire: 51000
 */
using System;
using System.Text;
public abstract class Salarie
{
    //Attributs de la classe abstraite Salarie
    private int matricule;
    private String nom;
    private String prenom;


    //Propriétés pour les différents attributs
    public int Matricule
    {
        get { return matricule; }
        set { matricule = value; }
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }

    //un constructeur d’initialisation
    public Salarie(int Matricule, String nom, String prenom)
    {
        this.matricule = Matricule;
        this.nom = nom;
        this.prenom = prenom;
    }

    //méthode ToString()
   
    public override String ToString()
    {
        return "Matricule: " + matricule + ",  Nom: " + nom + ",  Prénom: " + prenom;
    }

    // méthode abstraite calculerSalaire()

    public abstract double calculerSalaire();



}







