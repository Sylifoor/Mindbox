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
            "Expected radius is not equals actual radius.", circle.Radius, radius);
        Assert.That(circle.Diameter, Is.EqualTo(expectedDiameter), 
            "Expected diameter is not equals actual diameter", circle.Diameter, expectedDiameter);
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

        var actualLength = circle.GetLength();

        Assert.That(actualLength, Is.EqualTo(expectedLength).Within(0.01), 
            "Expected length is not equals actual length.", expectedLength, actualLength);
    }

    [Test]
    public void GetArea_WithRadiusOf5_Returns78Point54()
    {
        var radius       = 5d;
        var circle       = new Circle(radius);
        var expectedArea = 78.54;

        var actualArea = circle.GetArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.01), 
            $"Expected area is not equals actual area.", expectedArea, actualArea);
    }
}
