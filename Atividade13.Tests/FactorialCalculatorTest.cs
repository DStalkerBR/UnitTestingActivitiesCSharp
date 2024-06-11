namespace Atividade13.Tests
{
    public class FactorialCalculatorTest
    {
        [Fact]
        public void Calculate_ShouldThrowArgumentException_WhenInputIsNegative()
        {
            // Arrange
            var calculator = new FactorialCalculator();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-1));
        }

        [Fact]
        public void Calculate_ShouldReturnOne_WhenInputIsZero()
        {
            // Arrange
            var calculator = new FactorialCalculator();

            // Act
            var result = calculator.Calculate(0);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_ShouldReturnOne_WhenInputIsOne()
        {
            // Arrange
            var calculator = new FactorialCalculator();

            // Act
            var result = calculator.Calculate(1);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_ShouldReturnCorrectFactorial_WhenInputIsPositive()
        {
            // Arrange
            var calculator = new FactorialCalculator();

            // Act & Assert
            Assert.Equal(2, calculator.Calculate(2));
            Assert.Equal(6, calculator.Calculate(3));
            Assert.Equal(24, calculator.Calculate(4));
            Assert.Equal(120, calculator.Calculate(5));
        }

        [Fact]
        public void Calculate_ShouldHandleLargeInputs()
        {
            // Arrange
            var calculator = new FactorialCalculator();

            // Act & Assert
            Assert.Equal(3628800, calculator.Calculate(10));
        }
    }
}
