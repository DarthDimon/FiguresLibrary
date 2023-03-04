using FiguresLibrary;
using NUnit.Framework;

namespace Tests;

public class Test
{
    [Test]
    [TestCase(1, 6.28)]
    [TestCase(2, 12.57)]
    public void TestPerimeterCircle(decimal radius, decimal result)
    {
        var circle = new Circle(radius);
        var length = Math.Round(circle.GetPerimeter(), 2);

        Assert.AreEqual(length, result);
    }

    [Test]
    [TestCase(3, 4, 5, true)]
    [TestCase(1, 2, 3, false)]
    public void TriangleIsRight(decimal a, decimal b, decimal c, bool result)
    {
        var triangle = new Triangle(a, b, c);

        Assert.AreEqual(result, triangle.IsRight());
    }

    [Test]
    [TestCase(1, 2, 3, true)]
    [TestCase(1, 2, 500, false)]
    public void CreateTriangle(decimal a, decimal b, decimal c, bool result)
    {
        Triangle? triangle = null;
        try
        {
            triangle = new Triangle(a, b, c);
        }
        catch
        {
            // ignored
        }

        Assert.AreEqual(result, triangle != null);
    }
}