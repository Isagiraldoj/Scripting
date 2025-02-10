using System;

abstract class AbstractSample
{
    private string message;

    public AbstractSample(string message)//constructor
    {
        this.message = message;//atributos
    }

    public abstract void PrintMessage();//método

    public virtual void InvertMessage()//método virtual
    {
        char[] charArray = message.ToCharArray();//convertir el mensaje en un arreglo de caracteres
        Array.Reverse(charArray);
        message = new string(charArray);
    }

    protected string GetMessage()
    {
        return message;
    }

    protected void SetMessage(string newMessage)
    {
        message = newMessage;
    }
}

// Primera subclase que imprime el mensaje normal
class NormalPrinter : AbstractSample
{
    public NormalPrinter(string message) : base(message) { }

    public override void PrintMessage()
    {
        Console.WriteLine(GetMessage());
    }
}

// Segunda subclase que imprime el mensaje con mayúsculas y minúsculas invertidas
class CaseInverterPrinter : AbstractSample
{
    public CaseInverterPrinter(string message) : base(message) { }

    public override void PrintMessage()
    {
        string invertedCaseMessage = "";
        foreach (char c in GetMessage())
        {
            if (char.IsUpper(c))
                invertedCaseMessage += char.ToLower(c);
            else
                invertedCaseMessage += char.ToUpper(c);
        }
        Console.WriteLine(invertedCaseMessage);
    }

    // Sobreescribe InvertMessage para invertir también mayúsculas y minúsculas
    public override void InvertMessage()
    {
        base.InvertMessage(); // Primero invierte el orden
        string original = GetMessage();
        string modified = "";

        foreach (char c in original)
        {
            if (char.IsUpper(c))
                modified += char.ToLower(c);
            else
                modified += char.ToUpper(c);
        }

        SetMessage(modified); // Guarda el mensaje transformado
    }
}

// Programa principal para probar la implementación
class Program
{
    static void Main()
    {
        AbstractSample obj1 = new NormalPrinter("La mejor clase es SCRIPTING");
        AbstractSample obj2 = new CaseInverterPrinter("La mejor clase es SCRIPTING");

        Console.WriteLine("Mensaje normal:");
        obj1.PrintMessage();

        Console.WriteLine("\nMensaje con inversión de mayúsculas/minúsculas:");
        obj2.PrintMessage();

        Console.WriteLine("\nInvirtiendo mensaje en obj1:");
        obj1.InvertMessage();
        obj1.PrintMessage();

        Console.WriteLine("\nInvirtiendo mensaje en obj2 con cambio de mayúsculas/minúsculas:");
        obj2.InvertMessage();
        obj2.PrintMessage();
    }
}
