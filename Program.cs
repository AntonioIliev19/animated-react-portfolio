namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("John", "Doe", false, true); // Bank client
            Customer customer2 = new Customer("Jane", "Smith", true, true); // Bank client and pensioner
            Customer customer3 = new Customer("Jim", "Beam", false, false); // Not a bank client

            CreditAccount creditAccount = new CreditAccount("BankClient1", 1000);

            creditAccount.GetCredit(500, customer1); // Should calculate with bank client interest rate
            creditAccount.GetCredit(500, customer2); // Should calculate with pensioner interest rate
            creditAccount.GetCredit(500, customer3); // Should calculate with default high interest rate
        }

    }
}
