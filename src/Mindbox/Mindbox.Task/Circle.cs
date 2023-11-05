namespace Mindbox.Task;

/// <summary>The class of circle shape.</summary>
public record Circle : IShape
{
    /// <summary>Get radius of circle.</summary>
    /// <value>Radius of value.</value>
    public double Radius { get; init; }

    /// <summary>Get diameter of circle.</summary>
    /// <value>Diameter of value.</value>
    public double Diameter { get; init; }
 
    /// <summary>Created <see cref="Circle"/> instance.</summary>
    /// <param name="radius">Radius of circle.</param>
    /// <exception cref="ArgumentException"/>
    public Circle(double radius)
    {
        if(radius <= 0)
        {
            throw new ArgumentException($"The value of 'radius' must be a positive number, but was '{radius}'.");
        }

        Radius   = radius;
        Diameter = radius * 2;
    }

    /// <summary>Get length of circle.</summary>
    /// <returns>Length of circle.</returns>
    public double GetLength()
    {
        return Diameter * Math.PI;
    }

    /// <inheritdoc/>
    public double GetArea()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }
}
