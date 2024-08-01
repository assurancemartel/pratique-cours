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

    public CompteEpargne(String leTitulaire, Double soldeInitial, String laDevise, Double leTauxInteret)
        : base(leTitulaire, soldeInitial, laDevise)
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

    //On peut appliquer le même code "générique" à des objets de types différents,
    //lorsque les classes de ces objets sont liées par héritage.
    //C'est le principe du polymorphisme.
    public static void Main()
    {
        CompteBancaire compte1 = new CompteBancaire("Pierre", 300, "euros");
        CompteEpargne compte2 = new CompteEpargne("Paul", 200,"dollars", 0.05);
        CompteBancaire compte3 = new CompteBancaire("Jacques", 50,"euros");
        List<CompteBancaire> listeComptes = new List<CompteBancaire>();
        listeComptes.Add(compte1);
        listeComptes.Add(compte2);//est-ce bien un compte bancaire?
        listeComptes.Add(compte3);
        foreach (CompteBancaire compte in listeComptes)
            Console.WriteLine(compte.decrire());
        //Un compte épargne « est un » compte bancaire.
        //On peut donc stocker un compte épargne dans une liste 
        //de comptes bancaires. On peut même appeler la méthode Decrire
        //sur chacun des éléments de la liste de comptes bancaires. 

    }

}
