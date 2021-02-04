using Xunit;

namespace Financial.Tests
{
    public class TaxCalculatorTest
    {
        [Fact]
        public void ShouldSumTwoNumbers()
        {
            Assert.Equal(5, TaxCalculator.Add(2, 3));
        }
    }
}
