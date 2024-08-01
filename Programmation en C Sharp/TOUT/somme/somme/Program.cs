using System;
public class Somme
{
    //Méthode avec 2 paramètres a et b
  public static  int calculerSomme(int a, int b)
  {
        return a + b;
  }
    // tester le code 
  public static void  Main ()
  {
        Console.WriteLine(calculerSomme(1, 2));
        Console.WriteLine(calculerSomme(0, -200));
        Console.WriteLine(calculerSomme(-3, -2));

  }
}