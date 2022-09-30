using Test_Mindbox;

namespace Test_Mindbox_Test
{
    [TestClass]
    public class ÑalculatorTests
    {
        [TestMethod]
        public void GetSquare_TooManyArguments()
        {
            var input = new[] { 1d, 2, 3, 4, 5 };

            Assert.ThrowsException<Exception>(() => Ñalculator.GetSquare(input));
        }

        [TestMethod]
        public void GetSquare_TooFewArguments()
        {
            var input = Array.Empty<double>();

            Assert.ThrowsException<Exception>(() => Ñalculator.GetSquare(input));
        }

        [TestMethod]
        public void GetSquare_OKForCircle()
        {
            double expected = 706.8583470577034;

            var input = new[] { 15d, };

            var output = Ñalculator.GetSquare(input);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void GetSquare_OKForTriangle()
        {
            double expected = 6d;

            var input = new[] { 3d, 4, 5 };

            var output = Ñalculator.GetSquare(input);

            Assert.AreEqual(expected, output);
        }


        [TestMethod]
        public void GetSquare_IsRightTriangle()
        {
            bool expected = true;

            var input = new[] { 3d, 4, 5 }; ;

            var output = Ñalculator.IsRightTriangle(input);

            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void GetSquare_IsNotRightTriangle()
        {
            bool expected = false;

            var input = new[] { 3d, 4, 6 }; ;

            var output = Ñalculator.IsRightTriangle(input);

            Assert.AreEqual(expected, output);
        }
    }
}