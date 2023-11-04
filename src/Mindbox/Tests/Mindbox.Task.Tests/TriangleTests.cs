using NUnit.Framework;

namespace Mindbox.Task.Tests
{
    public class TriangleTests
    {
        [Test]
        public void GetArea_ValidTriangle_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6;

            var actualArea = triangle.GetArea();

            Assert.That(actualArea, Is.EqualTo(expectedArea), $"Expected area {expectedArea}, but was {actualArea}");
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
            var triangle = new Triangle(3, 4, 5);
            var expectedPerimeter = 12;

            var actualPerimeter = triangle.GetPerimeter();

            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter), $"Expected perimiter {expectedPerimeter}, but was {actualPerimeter}");
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
            Assert.That(triangle.Value.SideA, Is.EqualTo(sideA),
                $"Side {sideA} is not equals trianlge side {triangle.Value.SideA}");
            Assert.That(triangle.Value.SideB, Is.EqualTo(sideB), 
                $"Side {sideB} is not equals trianlge side {triangle.Value.SideB}");
            Assert.That(triangle.Value.SideC, Is.EqualTo(sideC), 
                $"Side {sideC} is not equals trianlge side {triangle.Value.SideC}");
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
    }
}