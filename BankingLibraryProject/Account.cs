using AccountLibrary;
using System;

namespace BankingLibraryProject {
    /// <summary>
    /// This class is for demonstrating Class Libraries
    /// </summary>
    public class Account {

        public int AccountNumber { get; set; } = 1;
        public string Description { get; set; } = "Interest-bearing account";
        public decimal Balance { get; set; } = 100;
        public decimal InterestRate { get; set; } = 0.12m;

        /// <summary>
        /// This method calls CalculateInterestByMonths() from FormatAccount and puts the result into interestAmount
        /// </summary>
        /// <param name="months"></param>
        /// <returns>calculates the expression and then returns the result and stores it into the variable interestAmount</returns>
        public decimal CalculateInterest(int months) {
            decimal interestAmount 
                = FormatAccount.CalculateInterestByMonths(months, InterestRate, Balance);
            Balance += interestAmount;
            return interestAmount;
        }
    }
}
