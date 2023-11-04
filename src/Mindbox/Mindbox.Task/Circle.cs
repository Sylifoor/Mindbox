namespace Mindbox.Task;

/// <summary>The class of circle figure.</summary>
public readonly struct Circle : IFigure
{
    /// <summary>Get radius of circle.</summary>
    /// <value>Radius of value.</value>
    public double Radius { get; init; }

    /// <summary>Get diameter of circle.</summary>
    /// <value>Diameter of value.</value>
    public double Diameter => 2 * Radius;
 
    /// <summary>Created <see cref="Circle"/> instance.</summary>
    /// <param name="radius">Radius of circle.</param>
    /// <exception cref="ArgumentException"/>
    public Circle(double radius)
    {
        if(radius <= 0)
        {
            throw new ArgumentException(); //TODO: add exception message 
        }

        Radius = radius;
    }

    public double GetLength()
    {
        return 2 * Radius * Math.PI;
    }

    public double GetArea()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }
}
