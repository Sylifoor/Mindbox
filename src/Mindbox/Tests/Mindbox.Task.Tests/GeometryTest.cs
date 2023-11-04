using System.Security.Principal;

namespace Mindbox.Task.Tests
{
    [TestFixture]
    public class GeometryTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Teardown() 
        { 
        }

        [Test]
        [TestCase(0d, 0d, 0d, false)]
        public void CreateTriangleTest(double sideA, double sideB, double sideC, bool createSuccess)
        {
            Assert.That(Triangle.TryCreate(sideA, sideB, sideC, out var triangle), Is.EqualTo(createSuccess),
                $"Try create triangle test failed: expected {createSuccess}, but was {!createSuccess}.");

            if(createSuccess)
            {
                Assert.That(triangle, Is.Not.Null, "Triangle must be created, but was not.");
            }
        }

        [Test]
        [TestCase(null, double.NaN)] //temporary
        public void IFigureCalculateAreaTests(IFigure figure, double expectedArea)
        {
            var actualArea = figure.GetArea();

            Assert.That(actualArea, Is.EqualTo(expectedArea), 
                "Actual area is not equals expected area!", actualArea, expectedArea);
        }
    }
}