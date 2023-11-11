using NUnit.Framework;

namespace Mindbox.Task.Tests
{
    public class TriangleTests
    {
        [Test]
        public void GetArea_ValidTriangle_ReturnsCorrectArea()
        {
            var triangle     = new Triangle(3, 4, 5);
            var expectedArea = 6;

            var actualArea = triangle.GetArea();

            Assert.That(actualArea, Is.EqualTo(expectedArea), "Expected area is not equals actual area.", actualArea, actualArea );
        }

        [Test]
        public void GetArea_InvalidTriangle_ThrowsArgumentException()
        {
            var triangle = default(Triangle);

            Assert.Throws<ArgumentException>(() => triangle = new Triangle(1, 2, 3), "Triangle is not be created.");
        }

        [Test]
        public void GetPerimeter_ValidTriangle_ReturnsCorrectPerimeter()
        {
            var triangle          = new Triangle(3, 4, 5);
            var expectedPerimeter = 12;

            var actualPerimeter = triangle.GetPerimeter();

            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter), $"Expected perimeter is not equals actual perimeter", actualPerimeter, expectedPerimeter);
        }

        [Test]
        public void TryCreate_ValidTriangle_ReturnsTrueAndTriangle()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;

            var result = Triangle.TryCreate(sideA, sideB, sideC, out var triangle);

            Assert.That(result, Is.True, "Triangle must be a created.");
            Assert.That(triangle, Is.Not.Null, "Triangle is null.");
            Assert.That(triangle.SideA, Is.EqualTo(sideA),
                $"Side A {sideA} is not equals triangle side A {triangle.SideA}");
            Assert.That(triangle.SideB, Is.EqualTo(sideB), 
                $"Side B {sideB} is not equals triangle side B {triangle.SideB}");
            Assert.That(triangle.SideC, Is.EqualTo(sideC), 
                $"Side C {sideC} is not equals triangle side C {triangle.SideC}");
        }

        [Test]
        public void TryCreate_InvalidTriangle_ReturnsFalseAndNull()
        {
            var sideA = 1;
            var sideB = 2;
            var sideC = 3;

            var result = Triangle.TryCreate(sideA, sideB, sideC, out var triangle);

            Assert.That(result, Is.False, "Triangle is not be created.");
            Assert.That(triangle, Is.Null, "Triangle is not be created.");
        }

        [Test]
        public void TryCreate_InvalidTriangleWithZeroSide_ReturnsFalseAndNull()
        {
            var sideA = 0;
            var sideB = 5;
            var sideC = 8;

            var result = Triangle.TryCreate(sideA, sideB, sideC, out var triangle);

            Assert.That(result, Is.False, "Triangle is not be created.");
            Assert.That(triangle, Is.Null, "Triangle is not be created.");
        }
    }
}