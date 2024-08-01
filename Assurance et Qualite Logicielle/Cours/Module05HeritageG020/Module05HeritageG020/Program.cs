using System;

public class CompteBancaire
{
    //Attributs

    public String titulaire;
    public Double solde;
    public String devise;

    public String Titulaire
    {

        get { return titulaire; }
    }

    public Double Solde
    {

        get { return solde; }
    }

    public String Devise
    {

        get { return devise; }
    }

    //Constructeur de classe
    public CompteBancaire(String leTitulaire = "", Double soldeInitial = 0, String laDevise = "")
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

    public String decrire()
    {
        //description du compte
        String description = "Le compte de " + this.titulaire + " est de " + this.solde + " " + this.devise;
        return description; ;
    }

}
public class CompteEpargne : CompteBancaire
{
    private Double tauxInteret;

    public CompteEpargne (String leTitulaire, Double soldeInitial, String laDevise, Double leTauxInteret)
        : base (leTitulaire, soldeInitial, laDevise)
    {
        tauxInteret = leTauxInteret;

    }
    //calculer et ajouter les interets au solde initial
    public void ajouterInteret()
    {
        //calcul des interets sur le solde
        Double interet = solde * tauxInteret;
        //Ajout des interets au solde
        solde += interet;
    }
    public static void Main() {
        Double tauxInteret = 0.05;
        CompteEpargne comptePaul = new CompteEpargne("Paul", 100, "Dollars", tauxInteret);
        //appel des méthodes de la classe mére CompteBancaire pour les utiliser dans la classe fille CompteEpargne
        comptePaul.debiter(1000);
        comptePaul.crediter(1500);
        Console.WriteLine(comptePaul.decrire());

    }

}
