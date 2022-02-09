using System;

namespace AccountLibrary {
    public class FormatAccount {

        /// <summary>
        /// calculate and pay interest method
        /// </summary>
        /// <param name="months">12</param>
        /// <param name="interestRate">0.12</param>
        /// <param name="balance">= interestRate per month * months</param>
        /// <returns></returns>
        public static decimal CalculateInterestByMonths(int months, decimal interestRate, decimal balance) {

            return balance * (interestRate / 12) * months;
        }
    }
}
