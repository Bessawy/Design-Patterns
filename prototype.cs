using System.Security.Cryptography.X509Certificates;

namespace Prototype;

/// <summary>
/// Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.
/// Copy constructor or Assign Operators
/// Deep copy not shallow
/// </summary>
abstract class AbstractProtype
{
    public int x;
    public int y;

    // copy constructor
    public AbstractProtype(AbstractProtype source)
    {
        this.x = source.x;
        this.y = source.y;
    }

    public AbstractProtype()
    {}

    public abstract AbstractProtype Clone();
}

class ToCloneA : AbstractProtype
{
    public int m;

    public ToCloneA(ToCloneA source) : base(source)
    {
        this.m = source.m;
    } 

    public ToCloneA()
    {}

    public override AbstractProtype Clone()
    {
        return new ToCloneA(this);
    }
}

class ToCloneB : AbstractProtype
{
    public string? d = null;

    public ToCloneB(ToCloneB source) : base(source)
    {
        this.d = source.d;
    } 

    public ToCloneB()
    {}

    public override AbstractProtype Clone()
    {
        return new ToCloneB(this);
    }
}
