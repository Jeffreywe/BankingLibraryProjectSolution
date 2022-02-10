using System;
using Xunit;
using AccountLibrary;

namespace TestInterestCalculation {
    /// <summary>
    /// Tests the Calculation of Interest
    /// </summary>
    public class UnitTest1 {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(36, 36, 0.12, 100)]
        public void TestCalcIntByMonths(decimal interestAmount, int months, decimal interestRate, decimal balance) {
            Assert.Equal(interestAmount,
                FormatAccount.CalculateInterestByMonths(months, interestRate, balance));
        }

        [Fact]
        public void TestNegativeBalance() {
            Action MakeBalanceNegative = () =>
                FormatAccount.CalculateInterestByMonths(1, 0.01m, -100);
            Assert.Throws<ArgumentException>(MakeBalanceNegative);
        }
    }
}
