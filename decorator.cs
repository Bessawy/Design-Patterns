namespace Decorator;

public interface IPrintConsole
{
    public void PrintText();
}

public class BasePrinter : IPrintConsole
{
    public void PrintText()
    {
        Console.WriteLine("Base printer");
    }
}

public interface IPrintConsoleDecrator : IPrintConsole
{
}

public class DecoretorPrinter_0 : IPrintConsoleDecrator
{

    private readonly IPrintConsole _printer;
    public DecoretorPrinter_0(IPrintConsole printer)
    {
        this._printer = printer;
    }

    public void PrintText()
    {
        Console.WriteLine("DecoretorPrinter_0 printer");
        _printer.PrintText();
    }
}

public class DecoretorPrinter_1 : IPrintConsoleDecrator
{
    private readonly IPrintConsole _printer;
    public DecoretorPrinter_1(IPrintConsole printer)
    {
        this._printer = printer;
    }
    public void PrintText()
    {
        Console.WriteLine("DecoretorPrinter_1 printer");
        _printer.PrintText();
    }
}