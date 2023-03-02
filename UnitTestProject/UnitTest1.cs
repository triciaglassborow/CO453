using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FeetToMies()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.InputSelected = 1; //feet
            converter.UniversalOutputSelected = 2; //miles

            converter.Input = 5280;

            DistanceConverter.Conversions();

            Assert.AreEqual(1);
        }
    }
}
