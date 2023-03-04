namespace FiguresLibrary;

public class Circle : Figure
{
    public Circle(decimal radius) : base(radius)
    {
    }

    public override decimal GetPerimeter()
    {
        return (decimal)Math.PI * Edges[0] * 2;
    }

    public override decimal GetArea()
    {
        return (decimal)Math.PI * Edges[0] * Edges[0];
    }
}