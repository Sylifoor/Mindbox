namespace Mindbox.Task;

/// <summary>The class of triangle shape.</summary>
public record Triangle : IShape
{
    /// <summary>Get length of the side A.</summary>
    /// <value>Length of the side A.</value>
    public double SideA { get; init; }

    /// <summary>Get length of the side B.</summary>
    /// <value>Length of the side B.</value>
    public double SideB { get; init; }

    /// <summary>Get length of the side C.</summary>
    /// <value>Length of the side C.</value>
    public double SideC { get; init; }

    /// <summary>Get value for determining whether a triangle is a right triangle.</summary>
    /// <value>
    /// <see langword="true"/> - Triangle is right.
    /// <see langword="false"/> - Triangle is not right.
    /// </value>
    public bool IsRightTriangle { get; init; }

    /// <summary>Created <see cref="Triangle"/> instance.</summary>
    /// <param name="sideA">The side A.</param>
    /// <param name="sideB">The side B.</param>
    /// <param name="sideC">The side C.</param>
    /// <exception cref="ArgumentException" />
    public Triangle(double sideA, double sideB, double sideC)
    {
        if(IsValidTriangle(sideA, sideB, sideC))
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            IsRightTriangle = CheckIsRight(sideA, sideB, sideC);
        }
        else
        {
            throw new ArgumentException("Each side must be smaller than the other two sides.");
        }
    }

    /// <inheritdoc/>
    public double GetArea()
    {
        var halfPerimeter = GetPerimeter() / 2;
        var area          = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        return area;
    }

    /// <summary>Get perimeter of triangle.</summary>
    /// <returns>Perimeter a triangle.</returns>
    public double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    /// <summary>Try create rectangle from sides.</summary>
    /// <param name="sideA">The side A.</param>
    /// <param name="sideB">The side B.</param>
    /// <param name="sideC">The side C.</param>
    /// <param name="triangle">Created rectangle.</param>
    /// <returns>
    /// <see langword="true"/> - triangle successfully created.
    /// <see langword="false"/> - triangle not created.
    /// </returns>
    /// <exception cref="ArgumentException" />
    public static bool TryCreate(double sideA, double sideB, double sideC, out Triangle? triangle)
    {
        if(IsValidTriangle(sideA, sideB, sideC))
        {
            triangle = new Triangle(sideA, sideB, sideC);
            return true;
        }
        triangle = null;
        return false;
    }

    private static bool CheckIsRight(double sideA, double sideB, double sideC)
    {
        var hypotenuse   = Math.Max(Math.Max(sideA, sideB), sideC);
        var firstCathet  = Math.Min(Math.Min(sideA, sideB), sideC);
        var secondCathet = sideA + sideB + sideC - hypotenuse - firstCathet;
        
        return Math.Pow(hypotenuse, 2) == Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2);
    }

    private static bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        CheckZeroSide(sideA, nameof(sideA));
        CheckZeroSide(sideB, nameof(sideB));
        CheckZeroSide(sideC, nameof(sideC));
        
        //Согласно теоремы, любая сторона треугольника должна быть меньше суммы двух других сторон.
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }

    private static void CheckZeroSide(double side, string parameterName)
    {
        if (double.IsNormal(side) && side > 0) return;

        throw new ArgumentException($"The value of parameter '{parameterName}' must be a positive number, but was '{side}'.");
    }
}
