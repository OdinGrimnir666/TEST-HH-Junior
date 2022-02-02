using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEST_HH_Junior;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Circle_Radius_5_returned78_5()
        {
            double x = 5;

            double expected = 78.5;

            Assert.AreEqual(expected, Figure_Square.Circle_Radius(x));
        }


        [TestMethod]

        public void Triangle_Side5_7_8_returned()
        {
            double a = 5, b = 6, c = 8;

            double expected = 14.98;

            double x = Figure_Square.Triangle_Side(a, b, c);

            Assert.AreEqual(expected,x);


        }
    }
}
