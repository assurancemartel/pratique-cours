/* Écrire un programme dans lequel on demande à l’utilisateur de saisir 
une note. La note doit être entre 10 et 30 sinon une exception avec message personnalisée est générée: (avec le message "La note doit être entre 10 et 30")
-Voici un 1er exemple de resultat:
Veuillez saisir une note entre 10 et 30 : 20
La note saisie est : 20
-Voici une 2eme exemple de résultat:
Veuillez saisir une note entre 10 et 30 : 1
La note doit être entre 10 et 30

*/

class Program
{
    public static void Main(string[] args)
    {
        //Ajouter votre code ici
        double Note = 0;
        Console.WriteLine("Saisir une note comprise entre 10 et 30 : ");
        try
            {
                Note = double.Parse(Console.ReadLine());
                if (Note <10 || Note  > 30)
                {
                     Console.WriteLine("La Note doit etre comprise entre 10 et 30");
                }
                else
                {
                    Console.WriteLine($"la note saisie est : {Note}");
                }

            }
            catch (Exception)
            {
               Console.WriteLine("Veuillez saisir une note comprise entre 10 et 30");
            }
     
        
    }
}
