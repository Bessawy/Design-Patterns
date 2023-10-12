namespace Singleton;

/// <summary>
/// Singleton Class: Global entity
/// Class only have one instances at anytime.
/// </summary>
class SingletonClass
{
    static private SingletonClass? _object = null;
    private string _name;

    public string Name 
    {
        get {return _name;}
    }

    private SingletonClass(string name) 
    {
        _name = name;
    }

    public static SingletonClass GetSingletonClass()
    {
        if(_object == null)
        {
            _object = new SingletonClass("Singleton");
            return _object;
        }
        return _object;
    }
}