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
        public void GetArea_IFigure_Circle_Test()
        {
            IShape circle = new Circle(1);
            var expectedArea = 3.14;

            var actualArea = GetArea(circle);

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.01), 
                "Actual area is not equals expected area!", actualArea, expectedArea);
        }

        [Test]
        public void GetArea_IFigure_Triangle_Test()
        {
            IShape triangle = new Triangle(3, 4, 5);
            var expectedArea = 6;
            
            var actualArea = GetArea(triangle);

            Assert.That(actualArea, Is.EqualTo(expectedArea),
                "Actual area is not equals expected area", actualArea, expectedArea);
        }

        private double GetArea(IShape shape)
         => shape.GetArea();
    }
}