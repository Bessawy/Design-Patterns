using System.Security.Cryptography.X509Certificates;

namespace Factory;

// product
public interface IDialog
{
    public void Render(ref int x,ref int y);
    public (int x, int y) GetCoordinates();
}

// Concreate Products
public class StylishDialog : IDialog
{
    private readonly string _dialog = "This is stylish Console!";
    private int x;
    private int y;

    public (int x, int y) GetCoordinates()
    {
        Console.WriteLine("x: " + x + " y: " + y);
        return (this.x, this.y);
    }

    public void Render(ref int x, ref int y)
    {
        this.x = x;
        this.y = y;

        Console.WriteLine("<---------------------------------------------->");
        Console.WriteLine(_dialog);
    }
}

public class BoringDialog : IDialog
{
    private readonly string _dialog = "This is boring Console!";
    private int x;
    private int y;

    public (int x, int y) GetCoordinates()
    {
        Console.WriteLine("x: " + x + " y: " + y);
        return (this.x, this.y);
    }

    public void Render(ref int x, ref int y)
    {
        this.x = x;
        this.y = y;

        Console.WriteLine(_dialog);
    }
}

// Creator
public abstract class Dialog
{
    public abstract IDialog CreateDialog();

    public void Render(ref int x, ref int y)
    {
        IDialog dialog = CreateDialog();
        dialog.Render(ref x, ref y);       
        (int x, int y) coordinates = dialog.GetCoordinates();
    }
}

// concreate creator
public class StylishDialogFactory : Dialog
{
    public override IDialog CreateDialog()
    {
        return new StylishDialog();
    }
}

// concreate creator
public class BoringDialogFactory : Dialog
{
    public override IDialog CreateDialog()
    {
        return new BoringDialog();
    }
}