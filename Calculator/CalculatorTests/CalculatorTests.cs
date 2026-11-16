namespace CalculatorTests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        [TestMethod]
        public void TestAdd5And6Result11()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(5, 6);

            Assert.AreEqual(11, result);
        }
       
        [TestMethod]
        public void TestAdd7And8Result15()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(7, 8);

            Assert.AreEqual(15, result);
        }
       
        [TestMethod]
        public void TestDivide6And3Result2()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Divide(6, 3);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestDivide9And2Result4_5()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Divide(9, 2);

            Assert.AreEqual(4.5, result);
        }

       [ TestMethod]
        public void TestIsPrime13ResultTrue()
        {
            Calculator calculator = new Calculator();

            bool result = calculator.isPrime(13);

            Assert.IsTrue(result);
        }
       
        [ TestMethod]
        public void TestIsPrime25ResultFalse()
        {
            Calculator calculator = new Calculator();

            bool result = calculator.isPrime(25);

            Assert.IsFalse(result);
        }

        [ TestMethod]
        public void TestIsPrime2ResultTrue()
        {
            Calculator calculator = new Calculator();

            bool result = calculator.isPrime(2);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestIsPrime1ResultFalse()
        {
            Calculator calculator = new Calculator();

            bool result = calculator.isPrime(1);

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void TestIsPrimeNegativeNumberResultFalse()
        {
            Calculator calculator = new Calculator();

            bool result = calculator.isPrime(-13);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIsPrime0ResultFalse()
        {
            Calculator calculator = new Calculator();

            bool result = calculator.isPrime(0);

            Assert.AreEqual(false, result);
        }
    }
}
