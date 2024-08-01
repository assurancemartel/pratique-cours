using System;
//une classe abstraite définit un concept abstrait,
//incomplet ou théorique. Elle rassemble des éléments communs
//à plusieurs classes dérivées.Elle n'est pas destinée à être instanciée.

public abstract class CompteBancaire
{
    //Attributs

    private String titulaire;
    private Double solde;
    private String devise;

    //Constructeur de classe
    public CompteBancaire(String leTitulaire = "", Double soldeInitial = 0, String laDevise = "")
    {
        titulaire = leTitulaire;
        solde = soldeInitial;
        devise = laDevise;


    }

    public String Titulaire
    {

        get { return titulaire; }
    }
    //Acces au solde en lecture et en ecriture
    public Double Solde
    {

        get { return solde; }
        protected set { solde = value; }
    }

    public String Devise
    {

        get { return devise; }
    }

    

    //Méthodes

    //le dèpôt d'argent avec la méthode créditer() est pareil pour tous
    //les types de compte (CompteEpargne, CompteCourant )
    public void crediter(Double montant)
    {
        solde = solde + montant;
    }
    //Ce n'est pas pareil pour le débit, c'est différent pour chaque type de compte  
    //Un compte courant autorise un découvert maximal
    //Un compte épargne limite le montant du retrait par rapport au solde
    // Pour traiter la problématique de débit du solde,
    // il faut déclarer l'opération de débit dans la classe mère CompteBancaire
    //et laisser les classes dérivées définir comment cette opération est effectuée
    //et ceci avec la méthode abstraite: la méthode débiter() de la classe mére
    //CompteBancaire sera alors abstraite en la précédant par le mot clé abstract
    //Elle n'aura plus de corps car elle est abstraite
    public abstract void debiter(Double montant);
    

    public String decrire()
    {
        //description du compte
        String description = "Le compte de " + this.titulaire + " est de " + this.solde + " " + this.devise;
        return description; ;
    }

}

//On ajoute dans la classe CompteCourant la méthode debiter requise
//avec la même signature que la classe mère
public class CompteCourant : CompteBancaire
{
    private String numeroCB;
    private Double decouvertMaxi;
    //Constructeur de la classe dérivée CompteCourant
    public CompteCourant (String leTitulaire, Double soldeInitial, String laDevise,
        String numeroCB, Double decouvertMaxi)
        //Appel du constructeur de la classe mère CompteBancaire
        : base (leTitulaire, soldeInitial, laDevise)
    {
        this.numeroCB = numeroCB;
        this.decouvertMaxi = decouvertMaxi;
    }
    //Redéfinition de la méthode débiter en utilisant le mot clé override

    public override void debiter(double montant)
    {
        //On n'effectue le débit que si le solde final reste supérieur au découvert
        if (Solde - montant >= decouvertMaxi)
            Solde -= montant;
    }
}

//Avec le même principe, on complète la définiton de la classe CompteEpargne
//pour préciciser de quelle manière un compte d'épargne est débité

public class CompteEpargne : CompteBancaire
{
    private Double tauxInteret;

    public CompteEpargne(String leTitulaire, Double soldeInitial, String laDevise, Double leTauxInteret)
        : base(leTitulaire, soldeInitial, laDevise)
    {
        tauxInteret = leTauxInteret;

    }
    //calculer et ajouter les interets au solde initial
    public void ajouterInteret()
    {
        //calcul des interets sur le solde
        Double interet = Solde * tauxInteret;
        //Ajout des interets au solde
        Solde += interet;
    }
    //Redéfinition de la méthode debiter()
    public override void debiter(double montant)
    {
        //Le montant maximal d'un retrait est de moitié du solde actuel
        if (montant <= Solde / 2)
            Solde -= montant;
    }



    public static void Main()
    {//Instancier nos classes dérivées et les tester:
        CompteCourant comptecourant = new CompteCourant("Pierre", 250, "dollars", "1234 5678 9123 4567", -500);
        comptecourant.debiter(300);
        comptecourant.debiter(500);//le second retrait de 500 n'aurait pas lieu 
        //puisqu'il fait passer le solde en dessous du découvert autorisé.
        //Remarque: le programme principal n'est pas informé de l'échec du second retrait,
        //ce qui peut laisser croire que ce retrait a réussi.
        //Nous découvrirons prochainement le mécanisme de remontée d'erreur
        //que l'on utilise dans ces cas de figure.
        Console.WriteLine(comptecourant.decrire());
        /*
        CompteEpargne compteEpargne = new CompteEpargne("Paul", 1000, "euros", 0.04);
        compteEpargne.debiter(300);
        compteEpargne.debiter(500);
        Console.WriteLine(compteEpargne.decrire());
        //Ici encore, le second retrait n'a pas eu lieu :
        //son montant est supérieur à la moitié du solde
        //(700 euros au moment de l'appel).
        */




    }

}

