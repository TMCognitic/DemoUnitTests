using Newtonsoft.Json.Linq;

namespace Tools.XTests
{
    public class ToolsTest
    {
        [Theory]
        [InlineData(0, "Invalid value '0' - Primes numbers must be > than 0")]
        [InlineData(-1, "Invalid value '-1' - Primes numbers must be > than 0")]
        [InlineData(-2, $"Invalid value '-2' - Primes numbers must be > than 0")]
        [InlineData(-1000, $"Invalid value '-1000' - Primes numbers must be > than 0")]
        public void TestIsPrimeWithLessOrEqualsZero(int value, string errorMessage)
        {
            //Arrange 
            int x = value;
            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => x.IsPrime());
            //Assert
            Assert.Equal(errorMessage, exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-1000)]
        public void TestIsPrimeWithLessOrEqualsZeroBis(int value)
        {
            //Arrange 
            int x = value;
            //Act
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => x.IsPrime());
            //Assert
            Assert.Equal($"Invalid value '{value}' - Primes numbers must be > than 0", exception.Message);
        }

        [Fact]
        public void TestIsPrimeWith1()
        {
            //Arrange 
            int x = 1;
            //Act
            bool result = x.IsPrime();
            //Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(23)]
        public void TestIsPrimeWithPrimesValues(int value)
        {
            //Arrange 
            int x = value;
            //Act
            bool result = x.IsPrime();
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(15)]
        public void TestIsPrimeWithNoPrimeValues(int value)
        {
            //Arrange 
            int x = value;
            //Act
            bool result = x.IsPrime();
            //Assert
            Assert.False(result);
        }
    }
}