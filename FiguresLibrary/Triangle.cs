namespace FiguresLibrary;

public class Triangle : Figure
{
    public Triangle(decimal a, decimal b, decimal c)
        : base(new[] { a, b, c }.OrderBy(t => t).ToArray())
    {
        if (
            Edges[0] + Edges[1] < Edges[2]
            || Edges[0] + Edges[2] < Edges[1]
            || Edges[1] + Edges[2] < Edges[0]
        )
        {
            throw new Exception("Parameters error");
        }
    }

    public bool IsRight()
    {
        return Edges[0] * Edges[0] + Edges[1] * Edges[1] == Edges[2] * Edges[2];
    }

    public override decimal GetArea()
    {
        if (IsRight())
        {
            return Edges[0] * Edges[1] / 2;
        }

        var semiPerimeter = GetPerimeter() / 2;

        return (decimal)Math.Sqrt((double)(
                semiPerimeter
                * (semiPerimeter - Edges[0])
                * (semiPerimeter - Edges[1])
                * (semiPerimeter - Edges[2])
            )
        );
    }
}