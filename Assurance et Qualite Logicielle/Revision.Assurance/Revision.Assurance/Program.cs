using System;
public class person
{
    private int age;
 



    public int Age
    {
        get { return age; }
      set {  age = value; }
    }
    // methode d'age
    public void SetAge(int n)
    {
        age = n;
    }
    // methode pour afficher le mot hello
    public void SayHello()
    {
        Console.WriteLine("hello");
    }
    public person (int age)
    {
        this.age = age;
    }
    override
        public String ToString()
    {
        return $"L'âge de la personne est :{age}";
    }
}


public class student : person
{
    public student(int age) : base(age) { }
    
    public  void GoToClasses ()
    {
        Console.WriteLine("I'm going to class");
    }

    public void DisplayAge ()
    {
        Console.WriteLine($"My age is :{Age} years old."); // {age} a pu s'ecrire car il y a le get de age dans la classe parent.
    }
    // on pouvait encore écrire {GetAge()} ie prendre encore la methode get de age.
    
}

public class teacher : person
{
    private string subject;
    public teacher (int age): base(age) { }
     
    public void Explain ()
    {
        Console.WriteLine("Explanation begins");
    }

    public void Setsubject(string subject)
    {
        this.subject = subject;
    }

   
}


public class test
{
    public static void Main(string[] args)
    {
        person personne1 = new person (15);//j,ai definit une valeur , parce que j,ai aussi defini un constructeur dans la classe person
        Console.WriteLine(personne1.ToString());
        personne1.SayHello();

        student etudiant = new student (15);
        Console.WriteLine(etudiant.ToString());
        etudiant.DisplayAge();
        etudiant.GoToClasses();


        teacher prof = new teacher(40);
        Console.WriteLine(prof.ToString());
        prof.Explain();






    }
}
