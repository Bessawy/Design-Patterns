namespace Bridge;

abstract class Shape
{
    //
    readonly Color ShapeColor;

    public Shape(Color color)
    {
        ShapeColor = color;
    }

    public int getColorNumber()
    {
        return ShapeColor.GetColor();
    }
    public abstract int Area();
}

class Circle : Shape
{
    readonly int r;

    public Circle(int radius, Color color) : base(color)
    {
        r = radius;
    }

    public override int Area()
    {
        return (int)Math.PI * r * r;
    }
}

abstract class Color
{
    abstract public int GetColor();
}

class Red : Color
{
    int number = 10;
    public override int GetColor()
    {
        return this.number;
    }
}

class Brown : Color
{
    int number = 20;
    public override int GetColor()
    {
        return number;
    }
}