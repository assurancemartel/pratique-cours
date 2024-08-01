using System;
public class AgeException : Exception
{
    public AgeException()
        : base()
    {
    }

    public override string Message                                   //Redéfinition de la propriété Message
    {
        get
        {
            return "L’âge doit être entre 16 et 30";
        }
    }
}


