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
        [TestCase(null, double.NaN)] //temporary
        public void GetArea_IFigure_Tests(IFigure figure, double expectedArea)
        {
            var actualArea = figure.GetArea();

            Assert.That(actualArea, Is.EqualTo(expectedArea), 
                "Actual area is not equals expected area!", actualArea, expectedArea);
        }
    }
}