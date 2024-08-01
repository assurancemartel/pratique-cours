using System;

public class CompteBancaire
{
    //Attributs

    public String titulaire;
    public Double solde;
    public String devise;

    //Constructeur de classe
    public CompteBancaire(String leTitulaire = "", Double soldeInitial = 0, String laDevise ="" )
    {
        titulaire = leTitulaire;
        solde = soldeInitial;
        devise = laDevise;


    }

    //Méthodes
    public void crediter(Double montant)
    {
        solde = solde + montant;
    }
    public void debiter(Double montant)
    {
        solde = solde - montant;
    }
    

    static void Main()
    {
        //declaration et instanciation d'un 1er objet
        CompteBancaire comptePierre = new CompteBancaire();

        //affection des valeurs aux attributs du 1er objet
        comptePierre.titulaire = "Pierre";
        comptePierre.solde = 500;
        comptePierre.devise = "Euros";

        //declaration et instanciation d'un 2 eme objet
        CompteBancaire comptePaul = new CompteBancaire();
        //affection des valeurs aux attributs du 2eme objet
        comptePaul.titulaire = "Paul";
        comptePaul.solde = 150;
        comptePaul.devise = "Euros";

        //demander à l'utilisateur d'entrer un montant de transfert
        Console.WriteLine("Entrer le montant du transfert");
        Double montantTransfert = Convert.ToDouble(Console.ReadLine());
        comptePaul.crediter(montantTransfert);
        comptePierre.debiter(montantTransfert);



        //appels des méthodes
        //comptePierre.crediter(300);
        //comptePierre.debiter(500);
        //Appel de la méthode decrire () pour afficher les informations des 2 objets
        Console.WriteLine(comptePierre.decrire());
        Console.WriteLine(comptePaul.decrire());
    }

    public String decrire()
    {
        //description du compte
        String description = "Le compte de " + this.titulaire + " est de " + this.solde + " " + this.devise;
        return description; ;
    }



}
