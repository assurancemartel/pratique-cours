using System;
public class NoteException : Exception
{
    public NoteException() : base() { }

    public override string Message                                    //Redéfinition de la propriété Message
    {
        get
        {
            return "La note doit être entre 10 et 20";
        }
    }
}

