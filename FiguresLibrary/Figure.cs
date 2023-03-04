namespace FiguresLibrary;

public abstract class Figure
{
    protected decimal[] Edges { get; }

    protected Figure(params decimal[] edgesLength)
    {
        Edges = edgesLength;
    }

    public virtual decimal GetPerimeter()
    {
        return this.Edges.Sum();
    }

    public abstract decimal GetArea();
}