using System;

public class SalarieTroisiemeEchelon : Salarie
{
    //attribut pour le chiffre d'affaire commun pour tous les salariés du troisiéme échelon
    private static double chiffreAffaire;
    //attribut pour le pourcentage
    private double pourcentage;

    //propriétés
    public double Pourcentage
    {
        get { return  pourcentage; }
        set { pourcentage = value; }
    }

    public static double ChiffreAffaire
    {
        get { return chiffreAffaire; }
    }



    // constructeur
    public SalarieTroisiemeEchelon(int matricule, string nom, string prenom, double pourcentage)
      :base(matricule, nom, prenom) 
    {
        this.pourcentage = pourcentage;
    }


    public override string ToString()
    {
        return pourcentage + base.ToString();
    }

    public override double calculerSalaire()
    {
        double salaire = 51000;
       return Math.Round((chiffreAffaire * pourcentage / 100) );
    }
}


