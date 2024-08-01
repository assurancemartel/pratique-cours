/* Exemple du résultat attendu:
 
 ***********************************
Infos du salarié de troisième échelon:  Matricule: 3,  Nom: Poirrier,  Prénom: Tom,  Pourcentage: 3%
Le salaire: 51000
 */

class Program
{
   public static void Main(string[] args)
    {
        // un exemple de programme de test simple
         
        Console.Out.WriteLine("***********************************");
        // Le chiffre d'affaire est commun à tous les salariès du troisième échelon
        SalarieTroisiemeEchelon.ChiffreAffaire = 1700000;
        SalarieTroisiemeEchelon p = new SalarieTroisiemeEchelon(3, "Poirrier", "Tom", 3);
        Console.Out.WriteLine(p);
        Console.Out.WriteLine("Le salaire: "+  p.calculerSalaire());
        Console.ReadKey();
    }
}
