namespace Mindbox.Task.Tests;

[TestFixture]
internal class CircleTests
{
    [Test]
    public void CircleConstructor_WithValidRadius_SetsRadiusAndDiameter()
    {
        var radius           = 5d;
        var expectedDiameter = radius * 2;

        var circle = new Circle(radius);

        Assert.That(circle.Radius, Is.EqualTo(radius), 
            $"Expected radius {radius}, but was {circle.Radius}");
        Assert.That(circle.Diameter, Is.EqualTo(expectedDiameter), 
            $"Expected diameter {expectedDiameter}, but was {circle.Diameter}");
    }

    [Test]
    public void CircleConstructor_WithNegativeRadius_ThrowsArgumentException()
    {
        var radius = -5;
        
        Assert.Throws<ArgumentException>(() => new Circle(radius), "Circle is not be created.");
    }

    [Test]
    public void GetLength_WithRadiusOf5_Returns31Point42()
    {
        var radius         = 5d;
        var circle         = new Circle(radius);
        var expectedLength = 31.42;

        var length = circle.GetLength();

        Assert.That(length, Is.EqualTo(expectedLength).Within(0.01), $"Expected length {expectedLength}, but was {length}.");
    }

    [Test]
    public void GetArea_WithRadiusOf5_Returns78Point54()
    {
        var radius       = 5d;
        var circle       = new Circle(radius);
        var expectedArea = 78.54;

        var area = circle.GetArea();

        Assert.That(area, Is.EqualTo(expectedArea).Within(0.01), $"Expected area {expectedArea}, but was {area}.");
    }
}
