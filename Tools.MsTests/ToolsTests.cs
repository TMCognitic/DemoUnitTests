namespace Tools.MsTests
{
    [TestClass]
    public class ToolsTests
    {
        [TestMethod]
        [DataRow(0, "Invalid value '0' - Primes numbers must be > than 0")]
        [DataRow(-1, "Invalid value '-1' - Primes numbers must be > than 0")]
        [DataRow(-2, "Invalid value '-2' - Primes numbers must be > than 0")]
        [DataRow(-1000, "Invalid value '-1000' - Primes numbers must be > than 0")]
        public void TestIsPrimeWithLessOrEqualsZero(int value, string errorMessage)
        {
            //Arrange 
            int x = value;
            //Act
            InvalidOperationException exception = Assert.ThrowsException<InvalidOperationException>(() => x.IsPrime());
            //Assert
            Assert.AreEqual(errorMessage, exception.Message);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-2)]
        [DataRow(-1000)]
        public void TestIsPrimeWithLessOrEqualsZeroBis(int value)
        {
            //Arrange 
            int x = value;
            //Act
            InvalidOperationException exception = Assert.ThrowsException<InvalidOperationException>(() => x.IsPrime());
            //Assert
            Assert.AreEqual($"Invalid value '{value}' - Primes numbers must be > than 0", exception.Message);           
        }

        [TestMethod]
        public void TestIsPrimeWith1()
        {
            //Arrange 
            int x = 1;
            //Act
            bool result = x.IsPrime();
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(17)]
        [DataRow(19)]
        [DataRow(23)]
        public void TestIsPrimeWithPrimesValues(int value)
        {
            //Arrange 
            int x = value;
            //Act
            bool result = x.IsPrime();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(12)]
        [DataRow(14)]
        [DataRow(15)]
        public void TestIsPrimeWithNoPrimeValues(int value)
        {
            //Arrange
            int x = value;
            //Act
            bool result = x.IsPrime();
            //Assert
            Assert.IsFalse(result);
        }
    }
}