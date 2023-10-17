using System.Security.Cryptography.X509Certificates;

namespace Adapter;

public interface ICircleHole
{
    public int GetRadius();
}

class RoundPeg : ICircleHole
{
    readonly int r;

    public RoundPeg(int radius)
    {
        r = radius;
    }

    public int GetRadius()
    {
        return r;
    }
}

public interface ISquareHole
{
    public int GetLegth();
}

class SquarePeg : ISquareHole
{
    readonly int length;

    public SquarePeg(int length)
    {
        this.length = length;
    }

    public int GetLegth()
    {
        return length;
    }
}

class SquarePegAdaptor : ICircleHole
{
    readonly ISquareHole _square;

    public SquarePegAdaptor(ISquareHole square)
    {
        _square = square;
    }

    public int GetRadius()
    {
        return _square.GetLegth() * (int)Math.Sqrt(2) / 2;
    }
}