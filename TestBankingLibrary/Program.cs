using BankingLibraryProject;
using System;

namespace TestBankingLibrary {
/// <summary>
/// Succesfully created a Project library 
/// Bolded project selects start up solution, which is now set to TestBankingLibrary after right clicking
/// class libraries allows us to reference to the class we want and use it in our console app. 1 class can talk to library but not the
/// other way around. right click on project in sln explorer and select reference project and check so that you can reference to it.
/// you cannot do a circular reference, where a to b, b to c, you cannot c to a
/// </summary>
    public class Program {

        /// <summary>
        /// Account creates an instance, calls account.CalculateInterest() parameter inside, then cw for account.Balance
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
           
            Account account = new Account();
            account.CalculateInterest(36);
            Console.WriteLine(account.Balance);
        }
    }
}
