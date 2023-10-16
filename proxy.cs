namespace Proxy;

public interface IDatabase
{
    public void Save(string key, string value);
    public string? Query(string key);
}

public class ServiceDatabase : IDatabase
{
    private Dictionary<string, string> Store = new Dictionary<string, string>
    {
        { "Name", "Amr" },
        { "Age", "25" }
    };

    public string? Query(string key)
    {
        if(Store.ContainsKey(key))
            return Store[key];
        return null;
    }

    public void Save(string key, string value)
    {
        Store[key] = value;
    }
}

public class LoggerProxy : IDatabase
{
    private readonly IDatabase _database;

    public LoggerProxy(IDatabase database)
    {
        _database = database;
    }

    public string? Query(string key)
    {
        Console.WriteLine("Query: " + key);
        return _database.Query(key);
    }

    public void Save(string key, string value)
    {
        Console.WriteLine("Save-  Key: " + key + " val: " + value);
        _database.Save(key, value);
    }
}