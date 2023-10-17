namespace Chain;

class Component
{
    public string toottipText = "This is the main component";
    public void Help()
    {
        Console.WriteLine(toottipText);
    }
}

class Container : Component
{
}

class Dialog : Container
{
    public string? dialogHelp = null;

    public new void Help()
    {
        if(dialogHelp != null)
            Console.WriteLine(dialogHelp);
        else
            base.Help();
    }
}


